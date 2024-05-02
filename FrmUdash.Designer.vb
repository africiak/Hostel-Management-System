<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUdash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUdash))
        Me.billing = New System.Windows.Forms.Button()
        Me.reservation = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.complaints = New System.Windows.Forms.Button()
        Me.visitors = New System.Windows.Forms.Button()
        Me.centerpanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.TextBox()
        Me.txtAllocatedroom = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.centerpanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'billing
        '
        Me.billing.BackColor = System.Drawing.Color.White
        Me.billing.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billing.ForeColor = System.Drawing.SystemColors.Highlight
        Me.billing.Location = New System.Drawing.Point(3, 210)
        Me.billing.Name = "billing"
        Me.billing.Size = New System.Drawing.Size(226, 72)
        Me.billing.TabIndex = 3
        Me.billing.Text = "Billing"
        Me.billing.UseVisualStyleBackColor = False
        '
        'reservation
        '
        Me.reservation.BackColor = System.Drawing.Color.White
        Me.reservation.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reservation.ForeColor = System.Drawing.SystemColors.Highlight
        Me.reservation.Location = New System.Drawing.Point(3, 130)
        Me.reservation.Name = "reservation"
        Me.reservation.Size = New System.Drawing.Size(226, 72)
        Me.reservation.TabIndex = 2
        Me.reservation.Text = "Reservations"
        Me.reservation.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Location = New System.Drawing.Point(1, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(228, 72)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Profile"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'complaints
        '
        Me.complaints.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.complaints.ForeColor = System.Drawing.SystemColors.Highlight
        Me.complaints.Location = New System.Drawing.Point(1, 370)
        Me.complaints.Name = "complaints"
        Me.complaints.Size = New System.Drawing.Size(228, 74)
        Me.complaints.TabIndex = 6
        Me.complaints.Text = "Complaints"
        Me.complaints.UseVisualStyleBackColor = True
        '
        'visitors
        '
        Me.visitors.BackColor = System.Drawing.Color.White
        Me.visitors.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visitors.ForeColor = System.Drawing.SystemColors.Highlight
        Me.visitors.Location = New System.Drawing.Point(1, 290)
        Me.visitors.Name = "visitors"
        Me.visitors.Size = New System.Drawing.Size(228, 72)
        Me.visitors.TabIndex = 1
        Me.visitors.Text = "Visitors"
        Me.visitors.UseVisualStyleBackColor = False
        '
        'centerpanel
        '
        Me.centerpanel.AutoSize = True
        Me.centerpanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.centerpanel.Controls.Add(Me.Button2)
        Me.centerpanel.Controls.Add(Me.reservation)
        Me.centerpanel.Controls.Add(Me.complaints)
        Me.centerpanel.Controls.Add(Me.billing)
        Me.centerpanel.Controls.Add(Me.visitors)
        Me.centerpanel.Controls.Add(Me.Button1)
        Me.centerpanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.centerpanel.Location = New System.Drawing.Point(0, 95)
        Me.centerpanel.Name = "centerpanel"
        Me.centerpanel.Size = New System.Drawing.Size(233, 676)
        Me.centerpanel.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(235, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(918, 676)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 95)
        Me.Panel1.TabIndex = 20
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.White
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnlogout.Font = New System.Drawing.Font("Poppins", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnlogout.Location = New System.Drawing.Point(948, 0)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(208, 95)
        Me.btnlogout.TabIndex = 13
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(44, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(107, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 7)
        Me.Label2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(96, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 56)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DormDash"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.BackColor = System.Drawing.Color.ForestGreen
        Me.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblUsername.Font = New System.Drawing.Font("Poppins", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(238, 101)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(915, 44)
        Me.lblUsername.TabIndex = 21
        Me.lblUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAllocatedroom
        '
        Me.txtAllocatedroom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAllocatedroom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAllocatedroom.Font = New System.Drawing.Font("Poppins", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllocatedroom.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtAllocatedroom.Location = New System.Drawing.Point(690, 225)
        Me.txtAllocatedroom.Name = "txtAllocatedroom"
        Me.txtAllocatedroom.Size = New System.Drawing.Size(444, 41)
        Me.txtAllocatedroom.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Location = New System.Drawing.Point(2, 450)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(228, 74)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Help"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmUdash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1156, 771)
        Me.Controls.Add(Me.txtAllocatedroom)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.centerpanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmUdash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUdash"
        Me.centerpanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents complaints As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents visitors As Button
    Friend WithEvents reservation As Button
    Friend WithEvents billing As Button
    Friend WithEvents centerpanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnlogout As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As TextBox
    Friend WithEvents txtAllocatedroom As TextBox
    Friend WithEvents Button2 As Button
End Class
