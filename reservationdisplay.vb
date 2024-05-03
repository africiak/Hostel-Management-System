Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class reservationdisplay
    Private Sub reservationdisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReservationsData()
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

    End Sub
    Private Sub txtpack_SelectedIndexChanged(sender As Object, e As EventArgs)

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
            MsgBox("error")
        End If
    End Sub
    Private Sub LoadReservationsData()
        Dim conn As New MySqlConnection(My.Settings.connString)
        Dim adapter As New MySqlDataAdapter()
        Dim dataTable As New DataTable()

        Try
            conn.Open()


            Dim query As String = "SELECT * FROM reservations "


            adapter.SelectCommand = New MySqlCommand(query, conn)
            adapter.Fill(dataTable)


            dgvreservation.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub allocation_Click(sender As Object, e As EventArgs) Handles allocation.Click
        Dim packageId As Integer = Convert.ToInt32(txtpack.SelectedValue)
        Dim userId As Integer = Convert.ToInt32(txtuserid.Text)
        Dim reservationId As Integer = Convert.ToInt32(txtreservationid.Text)


        GetReservationDetails(packageId, userId, reservationId)

        ' Use the retrieved values here
        Console.WriteLine("Reservation ID: " & reservationId)
        Console.WriteLine("User ID: " & userId)
        Console.WriteLine("Package ID: " & packageId)

        AllocateRooms(packageId, userId, reservationId)
    End Sub

    Private Sub AllocateRooms(packageId As Integer, userId As Integer, reservationId As Integer)
        Dim conn As New MySqlConnection(My.Settings.connString)
        Using conn
            conn.Open()
            Dim cmd As New MySqlCommand("AllocateRoomss", conn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Add parameters to the stored procedure
            cmd.Parameters.AddWithValue("@p_user_id", userId)
            cmd.Parameters.AddWithValue("@p_package_id", packageId)
            cmd.Parameters.AddWithValue("@p_reservation_id", reservationId)

            ' Execute the stored procedure
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub GetReservationDetails(ByVal packageId As Integer, ByVal userId As Integer, ByVal reservationId As Integer)

        Dim conn As New MySqlConnection(My.Settings.connString)
        Using conn
            conn.Open()
            Dim query As String = "SELECT reservation_id, userid, pack_id FROM reservations WHERE reservation_id = @reservationid AND userid = @userid AND pack_id = @packid"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@reservationid", reservationId)
            cmd.Parameters.AddWithValue("@userid", userId)
            cmd.Parameters.AddWithValue("@packid", packageId)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Assign retrieved values to variables
                reservationId = Convert.ToInt32(reader("reservation_id"))
                userId = Convert.ToInt32(reader("userid"))
                packageId = Convert.ToInt32(reader("pack_id"))

                Console.WriteLine("Reservation ID: " & reservationId)
                Console.WriteLine("User ID: " & userId)
                Console.WriteLine("Package ID: " & packageId)

            Else
                Console.WriteLine("No reservation found for the provided IDs.")
            End If


            reader.Close()
        End Using
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        If dgvreservation.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvreservation.SelectedRows(0)

            Dim reservationId As Integer = Convert.ToInt32(selectedRow.Cells("reservation_id").Value)
            Dim userId As Integer = Convert.ToInt32(selectedRow.Cells("userid").Value)
            Dim username As String = Convert.ToString(selectedRow.Cells("username").Value)
            Dim packageId As Integer = Convert.ToInt32(selectedRow.Cells("pack_id").Value)
            Dim dateValue As DateTime = Convert.ToDateTime(selectedRow.Cells("date").Value)
            Dim price As Integer = Convert.ToInt32(selectedRow.Cells("price").Value)

            txtname.Text = username
            txtpack.SelectedValue = packageId
            txtdate.Text = dateValue.ToString()
            txtprice.Text = price.ToString()

            txtuserid.Text = userId.ToString()
            txtreservationid.Text = reservationId.ToString()


        Else
            MessageBox.Show("Please select a row from the DataGridView.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

        If dgvreservation.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvreservation.SelectedRows(0)

            Dim reservationId As Integer = Convert.ToInt32(selectedRow.Cells("reservation_id").Value)
            Dim userId As Integer = Convert.ToInt32(selectedRow.Cells("userid").Value)
            Dim packageId As Integer = Convert.ToInt32(selectedRow.Cells("pack_id").Value)


            Dim username As String = txtname.Text
            Dim dateValue As DateTime = Convert.ToDateTime(txtdate.Text)
            Dim price As Integer = Convert.ToInt32(txtprice.Text)


            Try
                Dim conn As New MySqlConnection(My.Settings.connString)
                conn.Open()

                Dim query As String = "UPDATE reservations SET username = @username, date = @date, price = @price WHERE reservation_id = @reservationId AND userid = @userId AND pack_id = @packageId"
                Dim cmd As New MySqlCommand(query, conn)


                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@date", dateValue)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@reservationId", reservationId)
                cmd.Parameters.AddWithValue("@userId", userId)
                cmd.Parameters.AddWithValue("@packageId", packageId)


                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()


                If rowsAffected > 0 Then
                    MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    LoadReservationsData()
                Else
                    MessageBox.Show("Update operation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                conn.Close()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select a row from the DataGridView.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If dgvreservation.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvreservation.SelectedRows(0)


            Dim reservationId As Integer = Convert.ToInt32(selectedRow.Cells("reservation_id").Value)
            Dim userId As Integer = Convert.ToInt32(selectedRow.Cells("userid").Value)
            Dim packageId As Integer = Convert.ToInt32(selectedRow.Cells("pack_id").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Try
                    Dim conn As New MySqlConnection(My.Settings.connString)
                    conn.Open()

                    Dim query As String = "DELETE FROM reservations WHERE reservation_id = @reservationId AND userid = @userId AND pack_id = @packageId"
                    Dim cmd As New MySqlCommand(query, conn)


                    cmd.Parameters.AddWithValue("@reservationId", reservationId)
                    cmd.Parameters.AddWithValue("@userId", userId)
                    cmd.Parameters.AddWithValue("@packageId", packageId)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()


                    If rowsAffected > 0 Then
                        MessageBox.Show("Entry deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        LoadReservationsData()
                    Else
                        MessageBox.Show("Delete operation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Please select a row from the DataGridView.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btndash_Click(sender As Object, e As EventArgs) Handles btndash.Click
        Me.Close()
        Dim loggedInUserID As Integer = Frmlogin.loggedInUserID
        Dim loggedInUsername As String = Frmlogin.loggedInUsername

        Dim ADash As New ADash(loggedInUserID, loggedInUsername)
        ADash.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        splash.Show()
    End Sub
End Class