Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class billform
    Private Sub btndash_Click(sender As Object, e As EventArgs) Handles btndash.Click
        Me.Close()
        Dim loggedInUserID As Integer = Frmlogin.loggedInUserID
        Dim loggedInUsername As String = Frmlogin.loggedInUsername

        Dim ADash As New ADash(loggedInUserID, loggedInUsername)
        ADash.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        splash.Show()
    End Sub

    Private Sub billform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBillingData()
    End Sub

    Private Sub LoadBillingData()
        Dim conn As New MySqlConnection(My.Settings.connString)
        Dim adapter As New MySqlDataAdapter()
        Dim dataTable As New DataTable()

        Try
            conn.Open()


            Dim query As String = "SELECT * FROM payments "


            adapter.SelectCommand = New MySqlCommand(query, conn)
            adapter.Fill(dataTable)


            dgvreservation.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        If dgvreservation.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvreservation.SelectedRows(0)


            Dim username As String = selectedRow.Cells("Username").Value.ToString()
            Dim amount As String = selectedRow.Cells("PaymentAmount").Value.ToString()
            Dim paymentMethod As String = selectedRow.Cells("PaymentMethod").Value.ToString()
            Dim paymentDate As DateTime = Convert.ToDateTime(selectedRow.Cells("payDate").Value)


            txtname.Text = username
            txtpay.Text = amount
            combomethod.SelectedItem = paymentMethod
            txttime.Text = paymentDate.ToString("yyyy-MM-dd HH:mm:ss") ' Format the date as needed
        End If
    End Sub

    Private Sub btnreceipt_Click(sender As Object, e As EventArgs) Handles btnreceipt.Click
        ' Check if all necessary data is selected
        If Not String.IsNullOrEmpty(txtname.Text) AndAlso
           Not String.IsNullOrEmpty(txtpay.Text) AndAlso
           Not String.IsNullOrEmpty(combomethod.SelectedItem) AndAlso
           Not String.IsNullOrEmpty(txttime.Text) Then

            ' Gather the data from the textboxes
            Dim username As String = txtname.Text
            Dim amount As String = txtpay.Text
            Dim paymentMethod As String = combomethod.SelectedItem.ToString()
            Dim paymentDate As DateTime = DateTime.ParseExact(txttime.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)

            ' Generate the receipt content
            Dim receiptContent As String = $"Receipt
-----------------------
Username: {username}
Amount: {amount}
Payment Method: {paymentMethod}
Payment Date: {paymentDate.ToString("yyyy-MM-dd HH:mm:ss")}"

            ' Optionally, save the receipt content to a file
            Dim receiptFilePath As String = "receipt.txt"
            File.WriteAllText(receiptFilePath, receiptContent)

            MessageBox.Show("Receipt generated successfully. You can view it in the application.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select a reservation to generate the receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class