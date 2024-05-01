Imports System.Drawing.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Reservations
    Private loggedInUserID As Integer
    Private loggedInUsername As String

    Public Sub New(userID As Integer, username As String)
        InitializeComponent()
        loggedInUserID = userID
        loggedInUsername = username
    End Sub
    Private Sub Reservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reservedate As DateTime = DateTime.Now
        txtdate.Text = reservedate.ToString("yyyy-MM-dd HH:mm:ss")
        txtname.Text = loggedInUsername
        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            conn.Open()
            Dim query As String = "SELECT package_id, packname FROM packages"

            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim packageTable As New DataTable()
            adapter.Fill(packageTable)

            'bind data
            txtpack.DataSource = packageTable
            txtpack.DisplayMember = "Packname"
            txtpack.ValueMember = "Package_id"

            AddHandler txtpack.SelectedIndexChanged, AddressOf txtpack_SelectedIndexChanged

            UpdatePrice()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Dispose()
            conn.Close()
        End Try
        LoadReservations()
    End Sub

    Private Sub txtpack_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Update the price whenever the selected package changes
        UpdatePrice()
    End Sub

    Private Sub UpdatePrice()
        Dim selectedPackageId As Integer = Convert.ToInt32(txtpack.SelectedValue)

        ' Update the price based on the selected package
        If selectedPackageId = 1 Then
            txtprice.Text = "15000"
        ElseIf selectedPackageId = 2 Then
            txtprice.Text = "25000"
        ElseIf selectedPackageId = 3 Then
            txtprice.Text = "30000"
        Else
            txtprice.Text = "" ' Set default value if package ID is not recognized
        End If
    End Sub
    Private Sub reserve_Click(sender As Object, e As EventArgs) Handles reserve.Click
        Dim user As String = txtname.Text.Trim()
        Dim packageId As String = Convert.ToInt32(txtpack.SelectedValue)
        Dim reservedate As DateTime = DateTime.Now
        txtdate.Text = reservedate.ToString()
        Dim price As Integer = txtprice.Text.Trim()
        Dim status As String = "pending"

        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            'open onnetion'
            conn.Open()

            Dim checkreservation As String = "SELECT COUNT(*) FROM reservations WHERE username = @username"
            Using checkReservationCmd As New MySqlCommand(checkreservation, conn)
                checkReservationCmd.Parameters.AddWithValue("@username", user)
                Dim existingReservationsCount As Integer = Convert.ToInt32(checkReservationCmd.ExecuteScalar())

                ' If the user already has a reservation, display a message and return
                If existingReservationsCount > 0 Then
                    MessageBox.Show("You have already made a reservation.", "Reservation Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            End Using


            Dim cmd = New MySqlCommand("INSERT INTO reservations (userid, username, `pack_id`, date, price, status) VALUES (@userid, @username, @packid, @date, @price, @status)", conn)

            With cmd.Parameters
                .AddWithValue("@userid", loggedInUserID)
                .AddWithValue("@username", user)
                .AddWithValue("@packid", packageId)
                .AddWithValue("@date", reservedate)
                .AddWithValue("@price", price)
                .AddWithValue("@status", status)

            End With
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            ' Check if the insertion was successful
            If rowsAffected > 0 Then
                'log into audittrail

                Dim auditCmd As New MySqlCommand("INSERT INTO audittrail (timestamp, userid, eventType, Description) VALUES (@timestamp, @userid, @eventType, @Description)", conn)
                With auditCmd.Parameters
                    .AddWithValue("@timestamp", DateTime.Now)
                    .AddWithValue("@userid", loggedInUserID)
                    .AddWithValue("@eventType", "Reservation")
                    .AddWithValue("@Description", $"User '{user}' made a reservation for package ID '{packageId}'")
                End With
                auditCmd.ExecuteNonQuery()

                'load datagrid
                LoadReservations()


                MessageBox.Show("Reservation saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to save reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadReservations()
        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            conn.Open()
            Dim query As String = "SELECT userid, username, date, price, status FROM reservations WHERE userid = @userid"
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@userid", loggedInUserID)
            Dim reservationsTable As New DataTable()
            adapter.Fill(reservationsTable)
            dgvreservation.DataSource = reservationsTable
            dgvreservation.Columns("userid").Visible = False
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading reservations: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btndash_Click(sender As Object, e As EventArgs) Handles btndash.Click
        Me.Hide()
        Dim loggedInUserID As Integer = Frmlogin.loggedInUserID
        Dim loggedInUsername As String = Frmlogin.loggedInUsername

        Dim frmUdash As New FrmUdash(loggedInUserID, loggedInUsername)
        frmUdash.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        splash.Show()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        ' Check if a reservation is selected in the DataGridView
        If dgvreservation.SelectedRows.Count > 0 Then
            ' Get the selected reservation's status
            Dim selectedRow As DataGridViewRow = dgvreservation.SelectedRows(0)
            Dim userId As Integer = Convert.ToInt32(selectedRow.Cells("userid").Value)
            Dim status As String = selectedRow.Cells("status").Value.ToString()

            ' Check if the status is "pending"
            If status = "pending" Then

                ' Confirmation dialog before deletion
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this reservation for ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    ' Perform deletion from the database
                    Dim conn As New MySqlConnection(My.Settings.connString)
                    Try
                        conn.Open()

                        Dim deleteQuery As String = "DELETE FROM reservations WHERE userid = @userid"
                        Dim cmd As New MySqlCommand(deleteQuery, conn)
                        cmd.Parameters.AddWithValue("@userid", userId)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Reservation deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Refresh the DataGridView to reflect the deletion
                            LoadReservations()
                        Else
                            MessageBox.Show("Failed to delete reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        conn.Close()
                    End Try
                End If
            Else
                MessageBox.Show("You can only delete reservations with status 'pending'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a reservation to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class