Imports MySql.Data.MySqlClient

Public Class ADash

    Public loggedInUserID As Integer
    Public loggedInUsername As String
    Public Property userID As Integer
    Public Property username As String
    Public Sub New(userID As Integer, username As String)
        InitializeComponent()
        loggedInUserID = userID
        loggedInUsername = username
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs)
        Me.Close()
        Frmlogin.Show()
        Frmlogin.txtemail.Clear()
        Frmlogin.txtpass.Clear()
    End Sub

    Private Sub ADash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim totalUsers As Integer = GetTotalUsersCount()
        lbltotalusers.Text = "Total Residents : " & totalUsers.ToString()
        Dim availableRooms As Integer = AvailableRoomsCount()
        lblroom.Text = "Available rooms : " & availableRooms.ToString()
        Dim totalallocations As Integer = TotalallocationsCount()
        lblallocation.Text = "Allocations : " & totalallocations.ToString()



    End Sub

    Private Function GetTotalUsersCount() As Integer
        Dim totalUsers As Integer = 0
        Dim conn As New MySqlConnection(My.Settings.connString)
        Using conn
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM users", conn)
            totalUsers = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        Return totalUsers
    End Function

    Private Function AvailableRoomsCount() As Integer
        Dim availableRooms As Integer = 0
        Dim conn As New MySqlConnection(My.Settings.connString)
        Using conn
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM rooms where status = 0", conn)
            availableRooms = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        Return availableRooms
    End Function

    Private Function TotalallocationsCount() As Integer
        Dim totalallocations As Integer = 0
        Dim conn As New MySqlConnection(My.Settings.connString)
        Using conn
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM allocation", conn)
            totalallocations = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        Return totalallocations
    End Function

    Private Sub complaints_Click(sender As Object, e As EventArgs) Handles complaints.Click
        Me.Hide()
        complaintsdisplay.Show()
    End Sub

    Private Sub visitors_Click(sender As Object, e As EventArgs) Handles visitors.Click
        Me.Hide()

        Dim visitorsdisplay As New visitorsdisplay(loggedInUserID, loggedInUsername)
        visitorsdisplay.Show()

    End Sub

    Private Sub reservations_Click(sender As Object, e As EventArgs) Handles reservations.Click
        Me.Hide()
        Dim reservationdisplay As New reservationdisplay()
        reservationdisplay.Show()

    End Sub

    Private Sub residents_Click(sender As Object, e As EventArgs) Handles residents.Click
        Me.Hide()
        Dim residents As New residents()
        residents.Show()
    End Sub



    Private Sub Rooms_Click(sender As Object, e As EventArgs) Handles Rooms.Click
        Dim roomsdisplay As New roomsdisplay()
        roomsdisplay.Show()
        Me.Close()
    End Sub

    Private Sub billing_Click(sender As Object, e As EventArgs) Handles billing.Click
        Me.Hide()
        Dim billform As New billform()
        billform.Show()
    End Sub

    Private Sub allocation_Click(sender As Object, e As EventArgs) Handles allocation.Click
        Me.Hide()
        Dim allocation As New allocation()
        allocation.Show()
    End Sub

    Private Sub audit_Click(sender As Object, e As EventArgs) Handles audit.Click
        Me.Hide()
        frmaudit.Show()
    End Sub

    Private Sub btnlogout_Click_1(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        splash.Show()

    End Sub
End Class