Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class visitors

    Private loggedInUserID As Integer
    Private loggedInUsername As String

    Public Sub New(userID As Integer, username As String)
        InitializeComponent()
        loggedInUserID = userID
        loggedInUsername = username
    End Sub
    Private Sub visitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim timein As DateTime = DateTime.Now
        Dim timeout As DateTime = DateTime.Now
        checkin.Text = timein.ToString("yyyy-MM-dd HH:mm:ss")
        checkout.Text = timeout.ToString("yyyy-MM-dd HH:mm:ss")
        txthost.Text = loggedInUsername
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim visitor As String = txtname.Text.Trim()
        Dim host As String = txthost.Text.Trim()
        Dim contact As Integer = txtcontact.Text.Trim()
        Dim purpose As String = txtpurpose.Text.Trim()
        Dim timein As DateTime = DateTime.Now
        checkin.Text = timein.ToString()
        Dim timeout As DateTime = DateTime.Now
        checkout.Text = timeout.ToString()

        If visitor = "" Or host = "" Or purpose = "" Then
            MsgBox("All fields required!", vbExclamation)
        End If

        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            conn.Open()
            Using conn
                Dim cmd = New MySqlCommand("INSERT INTO visitors (vname,host,userid,contact,purpose,`check-in`,`check-out`) VALUES (@vname,@host,@userid,@contact,@purpose,@checkin,@checkout)", conn)
                With cmd.Parameters
                    .AddWithValue("@vname", visitor)
                    .AddWithValue("@host", host)
                    .AddWithValue("@userid", loggedInUserID)
                    .AddWithValue("@contact", contact)
                    .AddWithValue("@purpose", purpose)
                    .AddWithValue("@checkin", timein)
                    .AddWithValue("@checkout", timeout)
                End With

                cmd.ExecuteNonQuery()
                MsgBox("Visitor information saved successfully.", vbInformation)

                txtname.Clear()
                txtcontact.Clear()
                txtpurpose.Clear()

            End Using

        Catch ex As Exception
            MsgBox("An error occurred while saving visitor information.", vbCritical)
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
        Me.Close()
        Frmlogin.Show()
        Frmlogin.txtemail.Clear()
        Frmlogin.txtpass.Clear()

    End Sub
End Class