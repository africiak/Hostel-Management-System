Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class visitorsdisplay
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

    Private loggedInUserID As Integer
    Private loggedInUsername As String

    Public Sub New(userID As Integer, username As String)
        InitializeComponent()
        loggedInUserID = userID
        loggedInUsername = username
    End Sub

    Private Sub visitorsdisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVisitorsData()

        Dim timein As DateTime = DateTime.Now
        Dim timeout As DateTime = DateTime.Now
        txtcheckin.Text = timein.ToString("yyyy-MM-dd HH:mm:ss")
        txtcheckout.Text = timeout.ToString("yyyy-MM-dd HH:mm:ss")
        txthost.Text = loggedInUsername

    End Sub

    Private Sub LoadVisitorsData()
        Dim conn As New MySqlConnection(My.Settings.connString)
        Dim adapter As New MySqlDataAdapter()
        Dim dataTable As New DataTable()

        Try
            conn.Open()


            Dim query As String = "SELECT * FROM visitors "


            adapter.SelectCommand = New MySqlCommand(query, conn)
            adapter.Fill(dataTable)


            DataGridView1.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Retrieve room data from the selected row
            Dim visitorId As Integer = Convert.ToInt32(selectedRow.Cells("visitor_id").Value)
            Dim visitorname As String = Convert.ToString(selectedRow.Cells("vname").Value)
            Dim hostname As String = Convert.ToString(selectedRow.Cells("host").Value)
            Dim userid As Integer = Convert.ToInt32(selectedRow.Cells("userid").Value)
            Dim contact As Integer = Convert.ToInt32(selectedRow.Cells("contact").Value)
            Dim purpose As String = Convert.ToString(selectedRow.Cells("purpose").Value)
            Dim checkIn As DateTime = Convert.ToDateTime(selectedRow.Cells("check-out").Value)
            Dim checkOut As DateTime = Convert.ToDateTime(selectedRow.Cells("check-out").Value)

            ' Display room data in the textboxes
            txtname.Text = visitorname
            txthost.Text = hostname
            txtcontact.Text = contact
            txtpurpose.Text = purpose
            txtcheckin.Text = checkIn
            txtcheckout.Text = checkOut

            ' Enable editing of room data
            txtname.Enabled = True
            txthost.Enabled = True
            txtcontact.Enabled = True
            txtpurpose.Enabled = True
            txtcheckin.Enabled = True
            txtcheckout.Enabled = True

            ' Store the visitor ID for later reference
            txtVisitorID.Text = visitorId.ToString()
        Else
            MessageBox.Show("Please select the visitor to edit or delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        ' Check if a visiror is selected
        If Not String.IsNullOrEmpty(txtVisitorID.Text) Then
            ' Retrieve the edited data from the form fields
            Dim visitorId As Integer = Convert.ToInt32(txtVisitorID.Text)
            Dim visitorname As String = Convert.ToString(txtname.Text)
            Dim hostname As String = Convert.ToString(txthost.Text)
            Dim contact As Integer = Convert.ToInt32(txtcontact.Text)
            Dim purpose As String = Convert.ToString(txtpurpose.Text)
            Dim checkIn As DateTime = Convert.ToDateTime(txtcheckin.Text)
            Dim checkOut As DateTime = Convert.ToDateTime(txtcheckout.Text)

            ' Update the data in the database
            Dim conn As New MySqlConnection(My.Settings.connString)
            Try
                conn.Open()
                Dim query As String = "UPDATE visitors SET vname = @vname, host = @host, contact = @contact, purpose = @purpose, `check-in` = @checkin, `check-out` = @checkout WHERE visitor_id = @visitorid"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@vname", visitorname)
                cmd.Parameters.AddWithValue("@host", hostname)
                cmd.Parameters.AddWithValue("@contact", contact)
                cmd.Parameters.AddWithValue("@purpose", purpose)
                cmd.Parameters.AddWithValue("@checkin", checkIn)
                cmd.Parameters.AddWithValue("@checkout", checkOut)
                cmd.Parameters.AddWithValue("@visitorid", visitorId)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Visitor information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("An error occurred while updating visitor information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
                LoadVisitorsData() ' Refresh the DataGridView with updated data
            End Try
        Else
            MessageBox.Show("Please select the visitor to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Check if a visitor is selected
        If Not String.IsNullOrEmpty(txtVisitorID.Text) Then
            Dim visitorId As Integer = Convert.ToInt32(txtVisitorID.Text)

            ' Confirm with the user before deleting
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this visitor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Delete the visitor from the database
                Dim conn As New MySqlConnection(My.Settings.connString)
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM visitors WHERE visitor_id = @visitorid"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@visitorid", visitorId)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Visitor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("An error occurred while deleting the visitor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                    LoadVisitorsData() ' Refresh the DataGridView after deletion
                End Try
            End If
        Else
            MessageBox.Show("Please select the visitor to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class