Imports MySql.Data.MySqlClient

Public Class residents
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

    Private Sub residents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadResidentsData()
    End Sub
    Private Sub LoadResidentsData()
        Dim conn As New MySqlConnection(My.Settings.connString)
        Dim adapter As New MySqlDataAdapter()
        Dim dataTable As New DataTable()

        Try
            conn.Open()


            Dim query As String = "SELECT user_id, username, email FROM users "


            adapter.SelectCommand = New MySqlCommand(query, conn)
            adapter.Fill(dataTable)


            dgvreservation.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    'select user logic
    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click

        If dgvreservation.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvreservation.SelectedRows(0)

            Dim username As String = selectedRow.Cells("username").Value.ToString()
            Dim email As String = selectedRow.Cells("email").Value.ToString()


            txtname.Text = username
            txtemail.Text = email
        Else
            MessageBox.Show("Please select a row.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    'update user logic
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If dgvreservation.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvreservation.SelectedRows(0)
            Dim userId As Integer = Convert.ToInt32(selectedRow.Cells("user_id").Value)


            Dim Username As String = txtname.Text
            Dim Email As String = txtemail.Text


            Dim conn As New MySqlConnection(My.Settings.connString)
            Try

                Dim query As String = "UPDATE users SET username = @Username, email = @Email WHERE user_id = @userId"

                conn.Open()
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", Username)
                cmd.Parameters.AddWithValue("@Email", Email)
                cmd.Parameters.AddWithValue("@userId", userId)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadResidentsData()

                txtname.Text = ""
                txtemail.Text = ""
            Catch ex As Exception
                MessageBox.Show("An error occurred while updating data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please select a row.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    'delete user logic
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If dgvreservation.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvreservation.SelectedRows(0)
            Dim userId As Integer = Convert.ToInt32(selectedRow.Cells("user_id").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim conn As New MySqlConnection(My.Settings.connString)
                Try

                    Dim query As String = "DELETE FROM users WHERE user_id = @userId"

                    conn.Open()
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", userId)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Entry deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadResidentsData()

                    txtname.Text = ""
                    txtemail.Text = ""
                Catch ex As Exception
                    MessageBox.Show("An error occurred while deleting the entry: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try
            End If
        Else
            MessageBox.Show("Please select a row.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class