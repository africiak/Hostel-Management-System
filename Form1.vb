Imports Hostel_Management_System.My
Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Llogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Llogin.LinkClicked
        Me.Hide()
        Dim loginForm As New Frmlogin()
        Frmlogin.Show()
        Frmlogin.txtemail.Clear()
        Frmlogin.txtpass.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String = uname.Text.Trim()
        Dim Email As String = uemail.Text.Trim()
        Dim Password As String = upass.Text.Trim()
        Dim ConfirmPassword As String = upass2.Text.Trim()

        If Username = "" Or Email = "" Or Password = "" Or ConfirmPassword = "" Then
            MsgBox("All fields required!", vbExclamation)
        ElseIf Password <> ConfirmPassword Then
            MsgBox("Password and Confirm Password do not match!")
        Else
            'check if email exists'
            If EmailExists(Email) Then
                MsgBox("Email already exists!", vbExclamation)
                Return
            End If

            'insert record'
            Dim conn = New MySqlConnection(My.Settings.connString)
            Try
                'open connection'
                conn.Open()

                Using conn

                    Dim cmd = New MySqlCommand("INSERT INTO users (username,email,password) VALUES (@uname,@uemail,@upass)", conn)

                    With cmd.Parameters
                        .AddWithValue("@uname", Username)
                        .AddWithValue("@uemail", Email)
                        .AddWithValue("@upass", Password)
                    End With

                    Dim Status As Integer

                    Status = cmd.ExecuteNonQuery()

                    If (Status > 0) Then
                        MsgBox("Record inserted!", vbExclamation)

                        'redirect'
                        Me.Hide()
                        Frmlogin.Show()
                        Frmlogin.txtemail.Clear()
                        Frmlogin.txtpass.Clear()


                    Else
                        MsgBox("Record not inserted!", vbExclamation)

                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                conn.Dispose()
                conn.Close()
            End Try
        End If
    End Sub

    Private Function EmailExists(email As String) As Boolean
        Dim conn = New MySqlConnection(My.Settings.connString)
        Dim cmd = New MySqlCommand("SELECT COUNT(*) FROM users WHERE email = @email", conn)
        cmd.Parameters.AddWithValue("@email", email)
        Dim count As Integer
        Try
            conn.Open()
            count = Convert.ToInt32(cmd.ExecuteScalar)
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            conn.Dispose()
            conn.Close()
        End Try

        Return count > 0
    End Function


End Class
