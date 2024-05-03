Imports MySql.Data.MySqlClient

Public Class roomsdisplay
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles add.Click
        Dim rooms As New Rooms()
        rooms.Show()
        Me.Close()
    End Sub

    Private Sub roomsdisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPackages()
        LoadRoomData()
    End Sub
    Private Sub LoadRoomData()
        Dim conn As New MySqlConnection(My.Settings.connString)
        Dim adapter As New MySqlDataAdapter()
        Dim dataTable As New DataTable()

        Try
            conn.Open()


            Dim query As String = "SELECT * FROM rooms"


            adapter.SelectCommand = New MySqlCommand(query, conn)
            adapter.Fill(dataTable)


            DataGridView1.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadPackages()
        Dim conn As New MySqlConnection(My.Settings.connString)
        Dim adapter As New MySqlDataAdapter()
        Dim dataTable As New DataTable()

        Try
            conn.Open()

            Dim query As String = "SELECT package_id, packname FROM packages"

            adapter.SelectCommand = New MySqlCommand(query, conn)
            adapter.Fill(dataTable)

            ' Bind data to the ComboBox
            pack.DataSource = dataTable
            pack.DisplayMember = "packname"
            pack.ValueMember = "package_id"

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading package data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Retrieve room data from the selected row
            Dim roomId As Integer = Convert.ToInt32(selectedRow.Cells("room_id").Value)
            Dim roomNo As String = Convert.ToString(selectedRow.Cells("room_no").Value)
            Dim roomType As String = Convert.ToString(selectedRow.Cells("room_type").Value)
            Dim packageId As Integer = Convert.ToInt32(selectedRow.Cells("package").Value)
            Dim status As Boolean = Convert.ToBoolean(selectedRow.Cells("status").Value)

            ' Display room data in the textboxes
            txtroomno.Text = roomNo
            txtroomtype.Text = roomType
            pack.SelectedValue = packageId
            RadioButton1.Checked = status ' True
            RadioButton2.Checked = Not status ' False

            ' Enable editing of room data
            txtroomno.Enabled = True
            txtroomtype.Enabled = True
            pack.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True

            ' Store the room ID for later reference
            txtRoomID.Text = roomId.ToString()
        Else
            MessageBox.Show("Please select a room to edit or delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        ' Check if a room is selected
        If Not String.IsNullOrEmpty(txtRoomID.Text) Then
            ' Retrieve the edited data from the form fields
            Dim roomId As Integer = Convert.ToInt32(txtRoomID.Text)
            Dim roomNo As String = txtroomno.Text
            Dim roomType As String = txtroomtype.Text
            Dim packageId As Integer = Convert.ToInt32(pack.SelectedValue)
            Dim status As Boolean = RadioButton1.Checked

            ' Update the room data in the database
            Dim conn As New MySqlConnection(My.Settings.connString)
            Try
                conn.Open()

                Dim query As String = "UPDATE rooms SET room_no = @RoomNo, room_type = @RoomType, package = @PackageId, status = @Status WHERE room_id = @RoomId"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RoomNo", roomNo)
                    cmd.Parameters.AddWithValue("@RoomType", roomType)
                    cmd.Parameters.AddWithValue("@PackageId", packageId)
                    cmd.Parameters.AddWithValue("@Status", status)
                    cmd.Parameters.AddWithValue("@RoomId", roomId)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Room data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Refresh the data grid to reflect the changes
                        LoadRoomData()
                    Else
                        MessageBox.Show("Failed to update room data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while updating room data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please select a room to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Check if a room is selected
        If Not String.IsNullOrEmpty(txtRoomID.Text) Then
            Dim roomId As Integer = Convert.ToInt32(txtRoomID.Text)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim conn As New MySqlConnection(My.Settings.connString)


                Try
                    conn.Open()

                    Dim query As String = "DELETE FROM rooms WHERE room_id = @RoomID"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RoomID", roomId)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadRoomData()
                    Else
                        MessageBox.Show("Failed to delete room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("An error occurred while deleting the room: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try
            End If
        Else
            MessageBox.Show("Please select a room to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

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


End Class