<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservations))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.MaskedTextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtpack = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.MaskedTextBox()
        Me.reserve = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btndash = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.delete = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvreservation = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreservation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtprice)
        Me.Panel1.Location = New System.Drawing.Point(101, 390)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 95)
        Me.Panel1.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(132, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 42)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Price"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label10.Location = New System.Drawing.Point(241, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(381, 5)
        Me.Label10.TabIndex = 38
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(241, 23)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(380, 43)
        Me.txtprice.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 42)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Reservation date"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtdate)
        Me.Panel4.Location = New System.Drawing.Point(101, 289)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(647, 95)
        Me.Panel4.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label7.Location = New System.Drawing.Point(241, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(376, 5)
        Me.Label7.TabIndex = 5
        '
        'txtdate
        '
        Me.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdate.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtdate.Location = New System.Drawing.Point(241, 32)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(376, 36)
        Me.txtdate.TabIndex = 2
        Me.txtdate.UseWaitCursor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtpack)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Location = New System.Drawing.Point(101, 188)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(647, 95)
        Me.Panel5.TabIndex = 41
        '
        'txtpack
        '
        Me.txtpack.FormattingEnabled = True
        Me.txtpack.Location = New System.Drawing.Point(241, 42)
        Me.txtpack.Name = "txtpack"
        Me.txtpack.Size = New System.Drawing.Size(376, 33)
        Me.txtpack.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 42)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Package name"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label8.Location = New System.Drawing.Point(241, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(376, 5)
        Me.Label8.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtname)
        Me.Panel2.Location = New System.Drawing.Point(101, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(647, 98)
        Me.Panel2.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 42)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "User"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Location = New System.Drawing.Point(241, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(376, 5)
        Me.Label5.TabIndex = 5
        '
        'txtname
        '
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtname.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtname.Location = New System.Drawing.Point(241, 35)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(376, 36)
        Me.txtname.TabIndex = 2
        Me.txtname.UseWaitCursor = True
        '
        'reserve
        '
        Me.reserve.BackColor = System.Drawing.SystemColors.Highlight
        Me.reserve.Font = New System.Drawing.Font("Poppins", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reserve.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.reserve.Location = New System.Drawing.Point(100, 502)
        Me.reserve.Name = "reserve"
        Me.reserve.Size = New System.Drawing.Size(286, 79)
        Me.reserve.TabIndex = 43
        Me.reserve.Text = "Reserve"
        Me.reserve.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Controls.Add(Me.btndash)
        Me.Panel3.Controls.Add(Me.btnlogout)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1156, 95)
        Me.Panel3.TabIndex = 44
        '
        'btndash
        '
        Me.btndash.BackColor = System.Drawing.Color.White
        Me.btndash.Dock = System.Windows.Forms.DockStyle.Right
        Me.btndash.Font = New System.Drawing.Font("Poppins", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndash.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btndash.Location = New System.Drawing.Point(740, 0)
        Me.btndash.Name = "btndash"
        Me.btndash.Size = New System.Drawing.Size(208, 95)
        Me.btndash.TabIndex = 14
        Me.btndash.Text = "Dashboard"
        Me.btndash.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnlogout.Font = New System.Drawing.Font("Poppins", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.White
        Me.btnlogout.Location = New System.Drawing.Point(948, 0)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(208, 95)
        Me.btnlogout.TabIndex = 13
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(107, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 7)
        Me.Label3.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(96, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 56)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "DormDash"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.delete)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Controls.Add(Me.reserve)
        Me.Panel6.Controls.Add(Me.Panel1)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Location = New System.Drawing.Point(12, 148)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(829, 592)
        Me.Panel6.TabIndex = 45
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(243, 38)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label11.Location = New System.Drawing.Point(306, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 5)
        Me.Label11.TabIndex = 47
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.White
        Me.delete.Font = New System.Drawing.Font("Poppins", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.ForeColor = System.Drawing.Color.Red
        Me.delete.Location = New System.Drawing.Point(491, 502)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(257, 79)
        Me.delete.TabIndex = 44
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Poppins Medium", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label12.Location = New System.Drawing.Point(295, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(281, 65)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Reservations"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvreservation
        '
        Me.dgvreservation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvreservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreservation.Location = New System.Drawing.Point(17, 46)
        Me.dgvreservation.Name = "dgvreservation"
        Me.dgvreservation.RowHeadersWidth = 82
        Me.dgvreservation.RowTemplate.Height = 33
        Me.dgvreservation.Size = New System.Drawing.Size(284, 273)
        Me.dgvreservation.TabIndex = 46
        '
        'Panel7
        '
        Me.Panel7.Location = New System.Drawing.Point(12, 101)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(837, 918)
        Me.Panel7.TabIndex = 47
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.Controls.Add(Me.dgvreservation)
        Me.Panel8.Location = New System.Drawing.Point(855, 101)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(301, 672)
        Me.Panel8.TabIndex = 48
        '
        'Reservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 771)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "Reservations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreservation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdate As MaskedTextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtpack As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtname As MaskedTextBox
    Friend WithEvents reserve As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btndash As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents delete As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvreservation As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
End Class
