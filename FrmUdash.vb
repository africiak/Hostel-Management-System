Imports System.Data.SqlClient
Imports Bunifu.UI.WinForms.BunifuSnackbar
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Linq.Expressions

Public Class FrmUdash

    Private Sub btnlogout_Click_1(sender As Object, e As EventArgs)
        Me.Close()
        splash.Show()

    End Sub

    Public loggedInUserID As Integer
    Public loggedInUsername As String
    Public Property userID As Integer
    Public Property username As String
    Public Sub New(userID As Integer, username As String)
        InitializeComponent()
        loggedInUserID = userID
        loggedInUsername = username
    End Sub

    Public Sub New()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim profileUpdateForm As New profileUpdate(Me.loggedInUserID)
        profileUpdateForm.Show()
    End Sub

    Private Sub FrmUdash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If loggedInUsername IsNot Nothing AndAlso lblUsername IsNot Nothing Then
            Dim welcome As String = "Welcome, " & loggedInUsername & "!"
            Dim allocatedRoomInfo As String = GetAllocatedRoomInfo(loggedInUserID)
            lblUsername.Text = welcome & allocatedRoomInfo
        End If
    End Sub

    Private Function GetAllocatedRoomInfo(userID As Integer) As String
        Dim allocatedRoomInfo As String = ""


        Dim connectionString As String = My.Settings.connString


        Dim query As String = "SELECT room_no, room_type FROM allocation WHERE user_id = @userID"


        Using conn As New MySqlConnection(connectionString)

            Using cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@userID", userID)

                Try

                    conn.Open()


                    Dim reader As MySqlDataReader = cmd.ExecuteReader()


                    If reader.HasRows Then

                        While reader.Read()

                            allocatedRoomInfo &= "Room Number: " & reader("room_no").ToString() & ", Room Type: " & reader("room_type").ToString() & vbCrLf
                        End While
                    Else

                        allocatedRoomInfo = "No room allocated."
                    End If


                    reader.Close()
                Catch ex As Exception

                    MessageBox.Show("An error occurred while retrieving allocated room information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using


        Return allocatedRoomInfo
    End Function


    Private Sub visitors_Click(sender As Object, e As EventArgs) Handles visitors.Click
        Me.Hide()

        Dim visitorsForm As New visitors(loggedInUserID, loggedInUsername)
        visitorsForm.Show()

    End Sub

    Private Sub reservation_Click(sender As Object, e As EventArgs) Handles reservation.Click
        Me.Hide()

        Dim reservationForm As New Reservations(loggedInUserID, loggedInUsername)
        reservationForm.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        splash.Show()

    End Sub


    Private Sub complaints_Click(sender As Object, e As EventArgs) Handles complaints.Click

        Dim complaintsForm As New complaints(loggedInUserID)
        complaintsForm.Show()
        Me.Hide()
    End Sub

    Private Function GetPriceReservations(userID As Integer) As Decimal
        Dim price As Decimal = 0


        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            conn.Open()
            Using conn


                Dim cmd = New MySqlCommand("SELECT price FROM reservations WHERE userid = @UserID", conn)

                With cmd.Parameters
                    .AddWithValue("@UserID", userID)

                End With

                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then

                    price = Convert.ToDecimal(result)
                End If
            End Using
        Catch ex As Exception

            MessageBox.Show("An error occurred while retrieving price from reservations table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()

        End Try
        Return price
    End Function


    Private Sub billing_Click(sender As Object, e As EventArgs) Handles billing.Click
        Dim price As Decimal = GetPriceReservations(loggedInUserID)
        Dim billingForm As New billingForm(price, loggedInUserID, loggedInUsername)
        billingForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim helpForm As New helpForm()
        helpForm.Show()
    End Sub

    Private Sub receipt_Click(sender As Object, e As EventArgs) Handles receipt.Click
        Dim receiptFilePath As String = "receipt.txt"
        If File.Exists(receiptFilePath) Then
            Dim receiptContent As String = File.ReadAllText(receiptFilePath)

            If Not String.IsNullOrEmpty(receiptContent) Then
                MessageBox.Show(receiptContent, "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LogAuditTrail(userID)
            Else

                MessageBox.Show("Receipts will display after payment is processed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else

            MessageBox.Show("No receipt found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub LogAuditTrail(userID As Integer)
        Try
            Using conn As New MySqlConnection(My.Settings.connString)

                conn.Open()


                Dim sql As String = "INSERT INTO audittrail (timestamp, userid, eventType, Description) VALUES (@Timestamp, @UserID, @EventType, @Description)"
                Using cmd As New MySqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@Timestamp", DateTime.Now)
                    cmd.Parameters.AddWithValue("@UserID", userID)
                    cmd.Parameters.AddWithValue("@EventType", "ViewReceipt")
                    cmd.Parameters.AddWithValue("@Description", "User '" & userID & "' viewed receipt.")

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then

                    Else
                        MessageBox.Show("Failed to log audit trail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while logging the login event: " & ex.Message, MsgBoxStyle.Exclamation)
            Console.WriteLine("Error logging login event: " & ex.ToString())
        End Try
    End Sub

End Class