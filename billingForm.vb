Imports Bunifu.UI.WinForms.BunifuSnackbar
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class billingForm
    Private ReadOnly price As Decimal
    Private ReadOnly userID As Integer
    Private ReadOnly username As String

    Public Sub New(ByVal price As Decimal, ByVal userID As Integer, ByVal username As String)
        InitializeComponent()

        Me.price = price
        Me.userID = userID
        Me.username = username

        txtpay.Text = price.ToString()
    End Sub
    Private Sub billingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PayDate As DateTime = DateTime.Now
        txttime.Text = PayDate.ToString()
        txtname.Text = username

        Dim allocatedRoom As Boolean = AllocatedRooms(userID)

        If Not allocatedRoom Then
            MessageBox.Show("You have not been allocated a room. Billing cannot be processed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Else

            ' Check if payment has already been made for the current user
            Dim paymentMade As Boolean = PaymentAlreadyMade(userID)

            If paymentMade Then
                DisablePaymentControls()
            Else
                EnablePaymentControls()
            End If
        End If
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
        splash.Show()
    End Sub

    Private Function PaymentAlreadyMade(userID As Integer) As Boolean
        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            conn.Open()
            Using conn
                Dim cmd = New MySqlCommand("SELECT COUNT(*) FROM Payments WHERE UserID = @UserID", conn)

                With cmd.Parameters
                    .AddWithValue("@UserID", userID)

                End With
                ' Execute the query and check if any payment records exist
                Dim paymentCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return (paymentCount > 0)
            End Using

        Catch ex As Exception
            MsgBox("An error occurred ." & ex.Message, vbCritical)
            Console.WriteLine(ex.ToString())
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Private Sub DisablePaymentControls()
        ' Disable payment controls to prevent the user from making another payment
        txtpay.Enabled = False
        combomethod.Enabled = False
        txtnumber.Enabled = False
        save.Enabled = False

        MessageBox.Show("A payment has already been made for this user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Dim frmUdash As New FrmUdash(userID, username)
        frmUdash.Show()
    End Sub

    Private Sub EnablePaymentControls()
        ' Enable payment controls to allow the user to make a payment
        txtpay.Enabled = True
        combomethod.Enabled = True
        txtnumber.Enabled = True
        save.Enabled = True
    End Sub
    Private Function IsValidCardNumber(cardNumber As String) As Boolean

        If cardNumber.Length <> 16 Then
            Return False
        End If

        Return True
    End Function

    Private Function AllocatedRooms(userID As Integer) As Boolean
        Dim conn As New MySqlConnection(My.Settings.connString)

        Try
            conn.Open()

            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM allocations WHERE userID = @UserID", conn)
                cmd.Parameters.AddWithValue("@UserID", userID)

                ' Execute the query and check if any allocation records exist for the user
                Dim allocationCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return (allocationCount > 0)
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking room allocation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            conn.Close()
        End Try
    End Function


    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click

        Dim paymentAmount As Integer
        Dim paymentMethod As String
        Dim cardNumber As String = Nothing
        Dim PayDate As DateTime = DateTime.Now

        If String.IsNullOrEmpty(txtpay.Text) OrElse
       String.IsNullOrEmpty(combomethod.Text) OrElse
       (combomethod.SelectedItem.ToString() = "Card" AndAlso String.IsNullOrEmpty(txtnumber.Text)) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If Decimal.TryParse(txtpay.Text, paymentAmount) Then
            ' Retrieve payment method
            paymentMethod = combomethod.SelectedItem.ToString()

            ' If payment method is "Card", validate and retrieve card details
            If paymentMethod = "Card" Then
                cardNumber = txtnumber.Text

                ' Perform validation of card details
                If Not IsValidCardNumber(cardNumber) Then
                    MessageBox.Show("Invalid card number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                cardNumber = HashCardNo(cardNumber)
            End If

            Dim conn = New MySqlConnection(My.Settings.connString)
            Try
                conn.Open()
                Using conn
                    Dim cmd = New MySqlCommand("INSERT INTO Payments (userid, Username, PaymentAmount, PaymentMethod, CardNumber, PayDate) " &
                                      "VALUES (@UserID, @Username, @PaymentAmount, @PaymentMethod, @CardNumber, @PayDate)", conn)

                    With cmd.Parameters
                        .AddWithValue("@UserID", userID)
                        .AddWithValue("@Username", username)
                        .AddWithValue("@PaymentAmount", paymentAmount)
                        .AddWithValue("@PaymentMethod", paymentMethod)
                        .AddWithValue("@CardNumber", cardNumber)
                        .AddWithValue("@PayDate", PayDate)

                    End With
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Payment submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtnumber.Clear()
                    combomethod.SelectedIndex = -1

                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while processing the payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()

            End Try
        Else
            MessageBox.Show("Invalid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Function HashCardNo(input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(input))
            Dim builder As New StringBuilder()

            For i As Integer = 0 To hashedBytes.Length - 1
                builder.Append(hashedBytes(i).ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function

End Class