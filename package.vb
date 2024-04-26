Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Public Class package
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim package As String = packname.Text.Trim()
        Dim description As String = desc.Text.Trim()


        If package = "" Or description = "" Then
            MsgBox("All fields required!", vbExclamation)
            Return
        End If

        If String.IsNullOrEmpty(cost.Text) Then
            MsgBox("Price field is required!", vbExclamation)
            Return
        End If

        Dim price As Integer
        If Not Integer.TryParse(cost.Text.Trim(), price) Then
            MsgBox("Invalid price format! enter valid integer")
            Return
        End If


        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            'open onnetion'
            conn.Open()
            Using conn
                Dim cmd = New MySqlCommand("INSERT INTO packages (packname,description,price) VALUES (@packname,@description,@price)", conn)

                With cmd.Parameters
                    .AddWithValue("@packname", package)
                    .AddWithValue("@description", description)
                    .AddWithValue("@price", price)


                End With

                Dim Status As Integer

                Status = cmd.ExecuteNonQuery()

                If (Status > 0) Then
                    MsgBox("Record inserted!", vbExclamation)

                    Me.Close()

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