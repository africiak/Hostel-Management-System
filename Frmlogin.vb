Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Public Class Frmlogin

    Public loggedInUserID As Integer
    Public loggedInUsername As String
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

                Dim adapter = New MySqlDataAdapter("SELECT user_id, username FROM users WHERE email = @uemail AND password = @upass", conn)

                With adapter.SelectCommand.Parameters
                    .AddWithValue("@uemail", Email)
                    .AddWithValue("@upass", Password)

                End With

                Dim table = New DataTable()

                adapter.Fill(table)

                'check for record match'

                If (table.Rows.Count > 0) Then

                    loggedInUserID = Convert.ToInt32(table.Rows(0)("user_id"))
                    loggedInUsername = table.Rows(0)("username").ToString()
                    MsgBox("Logged in successfully", vbInformation)

                    'callthe LogLoginEvent
                    LogLoginEvent(loggedInUserID, loggedInUsername)

                    If Email.ToLower().Contains("admin@gmail.com") Then

                        Me.Hide()
                        ADash.Show()
                    Else
                        'check profile
                        Dim profileExists As Boolean = CheckProfile(loggedInUserID)

                        If profileExists Then
                            Dim frmUdash As New FrmUdash(loggedInUserID, loggedInUsername)
                            frmUdash.Show()
                            Me.Hide()

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

    Private Sub LogLoginEvent(userID As Integer, username As String)
        ' Create a timestamp for the event
        Dim timestamp As DateTime = DateTime.Now
        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            ' Insert the login event into the database
            conn.Open()
            Using conn
                Dim cmd = New MySqlCommand("INSERT INTO audittrail (timestamp, userid, eventType, Description) VALUES (@timestamp, @userid, @eventType, @Description)", conn)

                With cmd.Parameters
                    .AddWithValue("@timestamp", timestamp)
                    .AddWithValue("@userid", userID)
                    .AddWithValue("@eventType", "User Login")
                    .AddWithValue("@Description", "User '" & username & "' logged in successfully.")

                End With

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Audit trail logged.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to log audit trail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MsgBox("An error occurred while logging the login event: " & ex.Message, MsgBoxStyle.Exclamation)
            Console.WriteLine("Error logging login event: " & ex.ToString())
        End Try
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

        Dim path As New GraphicsPath()
        Dim radius As Integer = 20 ' Adjust the radius to change the roundness of the corners

        ' Add arcs to the path to create rounded corners
        path.AddArc(New Rectangle(0, 0, radius * 2, radius * 2), 180, 90) ' Top-left corner
        path.AddArc(New Rectangle(Panel1.Width - 2 * radius, 0, radius * 2, radius * 2), 270, 90) ' Top-right corner
        path.AddArc(New Rectangle(Panel1.Width - 2 * radius, Panel1.Height - 2 * radius, radius * 2, radius * 2), 0, 90) ' Bottom-right corner
        path.AddArc(New Rectangle(0, Panel1.Height - 2 * radius, radius * 2, radius * 2), 90, 90) ' Bottom-left corner
        path.CloseFigure()

        ' Set the panel's Region property to the created path
        Panel1.Region = New Region(path)
    End Sub


End Class