Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Rooms

    Public Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            conn.Open()
            Dim query As String = "SELECT package_id, packname FROM packages"

            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim packageTable As New DataTable()
            adapter.Fill(packageTable)

            'bind data
            pack.DataSource = packageTable
            pack.DisplayMember = "Packname"
            pack.ValueMember = "Package_id"


        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        package.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim roomno As Integer
        If Not Integer.TryParse(rnumber.Text, Roomno) Then
            MessageBox.Show("Please enter a valid room number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim roomtype As String = rtype.Text
        Dim package As Integer
        If Not Integer.TryParse(pack.SelectedValue.ToString(), package) Then
            MessageBox.Show("Please select a valid package.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim rstatus As Boolean

        If RadioButton1.Checked Then
            rstatus = True
        ElseIf RadioButton2.Checked Then
            rstatus = False
        Else
            MessageBox.Show("Please select the status of the room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            'open onnetion'
            conn.Open()
            Using conn
                Dim cmd = New MySqlCommand("INSERT INTO rooms (room_no,room_type,package,status) VALUES (@room_no,@room_type,@package,@status)", conn)

                With cmd.Parameters
                    .AddWithValue("@room_no", roomno)
                    .AddWithValue("@room_type", roomtype)
                    .AddWithValue("@package", package)
                    .AddWithValue("@status", rstatus)


                End With

                Dim Status As Integer

                Status = cmd.ExecuteNonQuery()

                If (Status > 0) Then
                    MsgBox("Record inserted!", vbExclamation)

                    rnumber.Clear()
                    rtype.Clear()
                    pack.SelectedIndex = -1
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False

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

    Private Sub btndash_Click(sender As Object, e As EventArgs) Handles btndash.Click
        Me.Hide()
        ADash.Show()

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        splash.Show()

    End Sub
End Class