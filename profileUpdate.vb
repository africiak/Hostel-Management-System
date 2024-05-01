Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports Microsoft.VisualBasic.ApplicationServices

Public Class profileUpdate
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        splash.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btndash.Click
        Me.Close()
        Dim loggedInUserID As Integer = Frmlogin.loggedInUserID
        Dim loggedInUsername As String = Frmlogin.loggedInUsername

        Dim frmUdash As New FrmUdash(loggedInUserID, loggedInUsername)
        frmUdash.Show()
    End Sub

    Private loggedInForm As Frmlogin
    Private loggedInUserID As Integer

    ' Constructor to pass the Frmlogin instance
    Public Sub New(userID As Integer)
        InitializeComponent()
        Me.loggedInForm = Frmlogin
        Me.loggedInUserID = userID
    End Sub


    Private Sub profileUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userID As Integer = loggedInUserID



        Dim profileData As New Dictionary(Of String, String)()
        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            conn.Open()
            Using conn
                Dim cmd = New MySqlCommand("SELECT * FROM profile WHERE userid = @userid", conn)
                cmd.Parameters.AddWithValue("@userid", userID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    profileData("profile_id") = reader("profile_id").ToString()
                    profileData("userid") = reader("userid").ToString()
                    txtname.Text = reader("name").ToString()
                    txtgender.Text = reader("gender").ToString()
                    txtdate.Text = reader("date").ToString()
                    txtphone.Text = reader("phone").ToString()


                    Dim imageBytes As Byte() = DirectCast(reader("picture"), Byte())
                    Dim ms As New MemoryStream(imageBytes)
                    picProfile.Image = Image.FromStream(ms)


                Else
                    MsgBox("No profile data found for the logged-in user.", MsgBoxStyle.Exclamation)
                    Return

                End If
            End Using

        Catch ex As Exception
            MsgBox("An error occurred while loading profile information.")
            Console.WriteLine(ex.ToString())
        Finally
            conn.Close()

        End Try

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

    Private Sub browse_Click(sender As Object, e As EventArgs) Handles browse.Click
        Dim openfiledialog1 As New OpenFileDialog

        openfiledialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"

        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim originalImage As Image = Image.FromFile(openfiledialog1.FileName)
            picProfile.Image = ResizeImage(originalImage, 440, 300)
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

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        ' Get the updated profile information from the textboxes
        Dim newName As String = txtname.Text.Trim()
        Dim newGender As String = txtgender.Text.Trim()
        Dim newDate As String = txtdate.Text.Trim()
        Dim newPhone As String = txtphone.Text.Trim()


        ' Update the profile information in the database
        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            conn.Open()
            Using conn
                Dim cmd = New MySqlCommand("UPDATE profile SET name = @name, gender = @gender, date = @date, phone = @phone WHERE userid = @userid  ", conn)

                cmd.Parameters.AddWithValue("@name", newName)
                cmd.Parameters.AddWithValue("@gender", newGender)
                cmd.Parameters.AddWithValue("@date", newDate)
                cmd.Parameters.AddWithValue("@phone", newPhone)

                If picProfile.Image IsNot Nothing Then
                    Dim ms As New MemoryStream()
                    picProfile.Image.Save(ms, Imaging.ImageFormat.Png)
                    Dim imageBytes As Byte() = ms.ToArray()
                    cmd.Parameters.AddWithValue("@picture", imageBytes)
                End If

                cmd.Parameters.AddWithValue("@userid", loggedInUserID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Profile updated successfully.", MsgBoxStyle.Information)
                Else
                    MsgBox("No rows were updated.", MsgBoxStyle.Exclamation)
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while updating the profile information.", MsgBoxStyle.Critical)
            Console.WriteLine(ex.ToString())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete your profile?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Delete the profile from the database
            Dim conn As New MySqlConnection(My.Settings.connString)
            Try
                conn.Open()
                Using conn
                    Dim cmd As New MySqlCommand("DELETE FROM profile WHERE userid = @userid", conn)
                    cmd.Parameters.AddWithValue("@userid", loggedInUserID)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MsgBox("Profile deleted successfully.", MsgBoxStyle.Information)
                        Me.Close()
                        Form1.Show()

                    Else
                        MsgBox("Profile not deleted.", MsgBoxStyle.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("An error occurred while deleting the profile.", MsgBoxStyle.Critical)
                Console.WriteLine(ex.ToString())
            Finally
                conn.Close()
            End Try
        End If
    End Sub
End Class