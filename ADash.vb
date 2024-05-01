Imports MySql.Data.MySqlClient

Public Class ADash
    Private Sub btnlogout_Click(sender As Object, e As EventArgs)
        Me.Close()
        Frmlogin.Show()
        Frmlogin.txtemail.Clear()
        Frmlogin.txtpass.Clear()
    End Sub

    Private Sub ADash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim totalUsers As Integer = GetTotalUsersCount()
        lbltotalusers.Text = "Total Residents : " & totalUsers.ToString()


    End Sub

    Private Function GetTotalUsersCount() As Integer
        Dim totalUsers As Integer = 0
        Dim conn As New MySqlConnection(My.Settings.connString)
        Using conn
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM users", conn)
            totalUsers = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        Return totalUsers
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Rooms.Click
        Dim rooms As New Rooms()
        rooms.Show()
        Me.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        frmaudit.Show()


    End Sub
End Class