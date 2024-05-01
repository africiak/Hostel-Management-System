Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Drawing.Drawing2D
Public Class profile
    Private LoggedInForm As Frmlogin

    Public Sub New(ByVal frmLogin As Frmlogin)

        InitializeComponent()
        Me.LoggedInForm = frmLogin

        MessageBox.Show("User ID: " & LoggedInForm.GetLoggedInUserID())
    End Sub



    Private Sub browse_Click(sender As Object, e As EventArgs) Handles browse.Click

        Dim openfiledialog1 As New OpenFileDialog

        openfiledialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"

        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim originalImage As Image = Image.FromFile(openfiledialog1.FileName)
            Profilepic.Image = ResizeImage(originalImage, 440, 300)
        End If

    End Sub

    Private Function ResizeImage(ByVal image As Image, ByVal width As Integer, ByVal height As Integer) As Image
        Dim resizedImage As New Bitmap(width, height)

        Using graphics As Graphics = Graphics.FromImage(resizedImage)
            graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            graphics.DrawImage(image, 0, 0, width, height)
        End Using

        Return resizedImage
    End Function

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click

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

                    Me.Close()
                    Dim loggedInUserID As Integer = Frmlogin.loggedInUserID
                    Dim loggedInUsername As String = Frmlogin.loggedInUsername

                    Dim frmUdash As New FrmUdash(loggedInUserID, loggedInUsername)
                    frmUdash.Show()
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

    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As New GraphicsPath()
        Dim radius As Integer = 20 ' Adjust the radius to change the roundness of the corners

        ' Add arcs to the path to create rounded corners
        path.AddArc(New Rectangle(0, 0, radius * 2, radius * 2), 180, 90) ' Top-left corner
        path.AddArc(New Rectangle(Panel2.Width - 2 * radius, 0, radius * 2, radius * 2), 270, 90) ' Top-right corner
        path.AddArc(New Rectangle(Panel2.Width - 2 * radius, Panel2.Height - 2 * radius, radius * 2, radius * 2), 0, 90) ' Bottom-right corner
        path.AddArc(New Rectangle(0, Panel2.Height - 2 * radius, radius * 2, radius * 2), 90, 90) ' Bottom-left corner
        path.CloseFigure()

        ' Set the panel's Region property to the created path
        Panel2.Region = New Region(path)
    End Sub
End Class