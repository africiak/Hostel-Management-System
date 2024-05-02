Imports System.Data.SqlClient
Imports Bunifu.UI.WinForms.BunifuSnackbar
Imports System.Threading
Imports MySql.Data.MySqlClient

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

        ' Database connection string
        Dim connectionString As String = My.Settings.connString

        ' Query to retrieve allocated room information based on the user's ID
        Dim query As String = "SELECT room_no, room_type FROM allocation WHERE user_id = @userID"

        ' Create a MySqlConnection object
        Using conn As New MySqlConnection(connectionString)
            ' Create a MySqlCommand object with the query and connection
            Using cmd As New MySqlCommand(query, conn)
                ' Add the parameter for user ID
                cmd.Parameters.AddWithValue("@userID", userID)

                Try
                    ' Open the connection
                    conn.Open()

                    ' Execute the query and retrieve data using a MySqlDataReader
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    ' Check if there are rows returned
                    If reader.HasRows Then
                        ' Loop through the rows
                        While reader.Read()
                            ' Construct the allocated room information string
                            allocatedRoomInfo &= "Room Number: " & reader("room_no").ToString() & ", Room Type: " & reader("room_type").ToString() & vbCrLf
                        End While
                    Else
                        ' If no rows are returned, set allocated room info to indicate no allocation
                        allocatedRoomInfo = "No room allocated."
                    End If

                    ' Close the reader
                    reader.Close()
                Catch ex As Exception
                    ' Handle any exceptions
                    MessageBox.Show("An error occurred while retrieving allocated room information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

        ' Return the allocated room information
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

                ' Check if a valid result is returned
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    ' Parse the result to Decimal and assign it to the price variable
                    price = Convert.ToDecimal(result)
                End If
            End Using
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred while retrieving price from reservations table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()

        End Try
        Return price
    End Function


    Private Sub billing_Click(sender As Object, e As EventArgs) Handles billing.Click
        Dim price As Decimal = GetPriceReservations(loggedInUserID)
        Dim billingForm As New BillingForm(price, loggedInUserID, loggedInUsername)
        billingForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim helpForm As New helpForm()
        helpForm.Show()
    End Sub
End Class