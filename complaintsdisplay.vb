Imports MySql.Data.MySqlClient

Public Class complaintsdisplay
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

    Private Sub LoadComplaints()
        Try
            Dim conn As New MySqlConnection(My.Settings.connString)
            Dim adapter As New MySqlDataAdapter("SELECT * FROM complaints", conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("An error occurred while loading audit trail data: " & ex.Message, MsgBoxStyle.Exclamation)
            Console.WriteLine("Error loading audit trail data: " & ex.ToString())
        End Try
    End Sub

    Private Sub complaintsdisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComplaints()
    End Sub
End Class