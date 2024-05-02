Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Net.Mail
Imports Bunifu.UI.WinForms.BunifuSnackbar
Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class complaints
    Private Sub complaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private userId As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        Me.userId = userId

        Txtto.Text = "dormdash@gmail.com"
    End Sub
    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click

        Dim senderEmail As String = Txtfrom.Text
        Dim receiverEmail As String = Txtto.Text
        Dim subject As String = Txtsubject.Text
        Dim message As String = Txtmailmessage.Text

        ' Insert the complaint into the database
        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            conn.Open()
            Using conn
                Dim cmd = New MySqlCommand("INSERT INTO complaints (userid, senderemail, receiveremail, subject, message) VALUES (@UserId, @SenderEmail, @ReceiverEmail, @Subject, @Message)", conn)
                With cmd.Parameters
                    .AddWithValue("@UserId", userId)
                    .AddWithValue("@SenderEmail", senderEmail)
                    .AddWithValue("@ReceiverEmail", receiverEmail)
                    .AddWithValue("@Subject", subject)
                    .AddWithValue("@Message", message)

                End With

                cmd.ExecuteNonQuery()
                MsgBox("Complaint submitted successfully.", vbInformation)

                Txtfrom.Clear()

                Txtto.Clear()

                Txtsubject.Clear()

                Txtmailmessage.Clear()

            End Using

        Catch ex As Exception
            MsgBox("An error occurred while sending complaint.", vbCritical)
            Console.WriteLine(ex.ToString())
        Finally
            conn.Close()
        End Try




    End Sub

    Private Sub btndash_Click(sender As Object, e As EventArgs) Handles btndash.Click
        Me.Close()
        Dim loggedInUserID As Integer = Frmlogin.loggedInUserID
        Dim loggedInUsername As String = Frmlogin.loggedInUsername

        Dim frmUdash As New FrmUdash(loggedInUserID, loggedInUsername)
        frmUdash.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        splash.Show()
    End Sub
End Class