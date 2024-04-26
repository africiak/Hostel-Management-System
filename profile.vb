Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class profile
    Private LoggedInForm As Frmlogin

    Public Sub New(ByVal frmLogin As Frmlogin)

        InitializeComponent()
        Me.LoggedInForm = frmLogin

        MessageBox.Show("User ID: " & LoggedInForm.GetLoggedInUserID())
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim openfiledialog1 As New OpenFileDialog

        openfiledialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"

        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Profilepic.Image = Image.FromFile(openfiledialog1.FileName)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim User As Integer = LoggedInForm.GetLoggedInUserID()
        Dim fullname As String = fname.Text.Trim()
        Dim gender As String = sex.Text.Trim()
        Dim birth As String = DOB.Text.Trim()
        Dim phone As String = tel.Text.Trim()
        Dim profile As Image = Profilepic.Image

        If fullname = "" Or gender = "" Or birth = "" Or phone = "" Then
            MsgBox("All fields required!", vbExclamation)
        End If

        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            'open onnetion'
            conn.Open()
            Using conn
                Dim cmd = New MySqlCommand("INSERT INTO profile (userId,name,gender,date,phone,picture) VALUES (@userid,@fname,@sex,@DOB,@tel,@profilepic)", conn)

                With cmd.Parameters
                    .AddWithValue("@userId", User)
                    .AddWithValue("@fname", fullname)
                    .AddWithValue("@sex", gender)
                    .AddWithValue("@DOB", birth)
                    .AddWithValue("@tel", phone)
                    'profilepic as blob

                    Using ms As New MemoryStream()
                        profile.Save(ms, Imaging.ImageFormat.Jpeg)
                        Dim pictureData As Byte() = ms.ToArray()
                        cmd.Parameters.AddWithValue("@profilepic", pictureData)

                    End Using


                End With
                Dim Status As Integer

                Status = cmd.ExecuteNonQuery()

                If (Status > 0) Then
                    MsgBox("Record inserted!", vbExclamation)

                    'redirect'
                    Me.Hide()
                    FrmUdash.Show()

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
    End Sub
End Class