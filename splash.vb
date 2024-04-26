Public Class splash

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim loginForm As New Frmlogin()
        Frmlogin.Show()
        Frmlogin.txtemail.Clear()
        Frmlogin.txtpass.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim Registration As New Form1()
        Form1.Show()

        Form1.uname.Clear()
        Form1.uemail.Clear()
        Form1.upass.Clear()
        Form1.upass2.Clear()
    End Sub
End Class