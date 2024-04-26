Imports MySql.Data.MySqlClient
Public Class Frmlogin

    Private loggedInUserID As Integer
    Private Sub Lregister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lregister.LinkClicked
        Me.Hide()
        Dim Registration As New Form1()
        Form1.Show()

        Form1.uname.Clear()
        Form1.uemail.Clear()
        Form1.upass.Clear()
        Form1.upass2.Clear()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim Email As String = txtemail.Text.Trim()
        Dim Password As String = txtpass.Text.Trim()

        If Email = "" Or Password = "" Then
            MsgBox("Enter your credentials!", vbExclamation)
        Else
            'select from the db'

            Dim conn = New MySqlConnection(My.Settings.connString)
            Try
                conn.Open()

                Dim adapter = New MySqlDataAdapter("SELECT user_id FROM users WHERE email = @uemail AND password = @upass", conn)

                With adapter.SelectCommand.Parameters
                    .AddWithValue("@uemail", Email)
                    .AddWithValue("@upass", Password)

                End With

                Dim table = New DataTable()

                adapter.Fill(table)

                'check for record match'

                If (table.Rows.Count > 0) Then

                    loggedInUserID = Convert.ToInt32(table.Rows(0)("user_id"))
                    MsgBox("Logged in successfully", vbInformation)


                    If Email.ToLower().Contains("admin@gmail.com") Then

                        Me.Hide()
                        ADash.Show()
                    Else
                        'check profile
                        Dim profileExists As Boolean = CheckProfile(loggedInUserID)

                        If profileExists Then
                            Me.Hide()
                            FrmUdash.Show()
                        Else

                            Dim profileForm As New profile(Me)
                            profileForm.Show()
                            Me.Hide()
                        End If
                    End If
                Else
                    MsgBox("Invalid email or password", vbCritical)

                End If

            Catch ex As Exception
                MsgBox("An error occured while logging in.Please try again later.", vbCritical)
                Console.WriteLine(ex.ToString())

            Finally
                conn.Dispose()
                conn.Close()
            End Try

        End If
    End Sub

    Public Function GetLoggedInUserID() As Integer
        Return loggedInUserID
    End Function

    Public Function CheckProfile(userID As Integer) As Boolean
        Dim conn = New MySqlConnection(My.Settings.connString)
        Dim profileExists As Boolean = False
        Try
            conn.Open()

            Dim cmd = New MySqlCommand("SELECT * FROM profile WHERE userId = @userID", conn)
            cmd.Parameters.AddWithValue("@userID", userID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            profileExists = reader.HasRows
            reader.Close()

        Catch ex As Exception
            MsgBox("An error occurred while checking the profile.", vbCritical)
            Console.WriteLine(ex.ToString())
        Finally
            conn.Dispose()
            conn.Close()
        End Try

        Return profileExists
    End Function

    Private Sub Frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim button As New Button()
        button.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        button.Text = "Click Me"
        button.Location = New Point(Me.ClientSize.Width - button.Width - 150, Me.ClientSize.Height - button.Height - 100)
        Me.Controls.Add(button)
    End Sub
End Class