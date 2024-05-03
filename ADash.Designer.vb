<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADash))
        Me.lbltotalusers = New System.Windows.Forms.Label()
        Me.Rooms = New System.Windows.Forms.Button()
        Me.billing = New System.Windows.Forms.Button()
        Me.reservations = New System.Windows.Forms.Button()
        Me.residents = New System.Windows.Forms.Button()
        Me.allocation = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.complaints = New System.Windows.Forms.Button()
        Me.audit = New System.Windows.Forms.Button()
        Me.visitors = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblroom = New System.Windows.Forms.Label()
        Me.lblallocation = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltotalusers
        '
        Me.lbltotalusers.AutoSize = True
        Me.lbltotalusers.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lbltotalusers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotalusers.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalusers.Location = New System.Drawing.Point(231, 113)
        Me.lbltotalusers.Name = "lbltotalusers"
        Me.lbltotalusers.Size = New System.Drawing.Size(162, 44)
        Me.lbltotalusers.TabIndex = 4
        Me.lbltotalusers.Text = "Total Users :"
        '
        'Rooms
        '
        Me.Rooms.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rooms.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Rooms.Location = New System.Drawing.Point(-1, 18)
        Me.Rooms.Name = "Rooms"
        Me.Rooms.Size = New System.Drawing.Size(213, 87)
        Me.Rooms.TabIndex = 0
        Me.Rooms.Text = "Rooms"
        Me.Rooms.UseVisualStyleBackColor = True
        '
        'billing
        '
        Me.billing.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billing.ForeColor = System.Drawing.SystemColors.Highlight
        Me.billing.Location = New System.Drawing.Point(0, 297)
        Me.billing.Name = "billing"
        Me.billing.Size = New System.Drawing.Size(213, 87)
        Me.billing.TabIndex = 1
        Me.billing.Text = "Billing"
        Me.billing.UseVisualStyleBackColor = True
        '
        'reservations
        '
        Me.reservations.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reservations.ForeColor = System.Drawing.SystemColors.Highlight
        Me.reservations.Location = New System.Drawing.Point(0, 111)
        Me.reservations.Name = "reservations"
        Me.reservations.Size = New System.Drawing.Size(213, 87)
        Me.reservations.TabIndex = 2
        Me.reservations.Text = "Reservations"
        Me.reservations.UseVisualStyleBackColor = True
        '
        'residents
        '
        Me.residents.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.residents.ForeColor = System.Drawing.SystemColors.Highlight
        Me.residents.Location = New System.Drawing.Point(-1, 204)
        Me.residents.Name = "residents"
        Me.residents.Size = New System.Drawing.Size(213, 87)
        Me.residents.TabIndex = 1
        Me.residents.Text = "Residents"
        Me.residents.UseVisualStyleBackColor = True
        '
        'allocation
        '
        Me.allocation.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allocation.ForeColor = System.Drawing.SystemColors.Highlight
        Me.allocation.Location = New System.Drawing.Point(-2, 393)
        Me.allocation.Name = "allocation"
        Me.allocation.Size = New System.Drawing.Size(214, 88)
        Me.allocation.TabIndex = 13
        Me.allocation.Text = "Allocation"
        Me.allocation.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 95)
        Me.Panel1.TabIndex = 21
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.complaints)
        Me.Panel2.Controls.Add(Me.audit)
        Me.Panel2.Controls.Add(Me.visitors)
        Me.Panel2.Controls.Add(Me.Rooms)
        Me.Panel2.Controls.Add(Me.reservations)
        Me.Panel2.Controls.Add(Me.allocation)
        Me.Panel2.Controls.Add(Me.residents)
        Me.Panel2.Controls.Add(Me.billing)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(213, 872)
        Me.Panel2.TabIndex = 22
        '
        'complaints
        '
        Me.complaints.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.complaints.ForeColor = System.Drawing.SystemColors.Highlight
        Me.complaints.Location = New System.Drawing.Point(-2, 672)
        Me.complaints.Name = "complaints"
        Me.complaints.Size = New System.Drawing.Size(214, 88)
        Me.complaints.TabIndex = 17
        Me.complaints.Text = "Complaints"
        Me.complaints.UseVisualStyleBackColor = True
        '
        'audit
        '
        Me.audit.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.audit.ForeColor = System.Drawing.SystemColors.Highlight
        Me.audit.Location = New System.Drawing.Point(-4, 578)
        Me.audit.Name = "audit"
        Me.audit.Size = New System.Drawing.Size(214, 88)
        Me.audit.TabIndex = 16
        Me.audit.Text = "Audit trail"
        Me.audit.UseVisualStyleBackColor = True
        '
        'visitors
        '
        Me.visitors.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visitors.ForeColor = System.Drawing.SystemColors.Highlight
        Me.visitors.Location = New System.Drawing.Point(-1, 484)
        Me.visitors.Name = "visitors"
        Me.visitors.Size = New System.Drawing.Size(214, 88)
        Me.visitors.TabIndex = 14
        Me.visitors.Text = "Visitors"
        Me.visitors.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(218, 95)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(938, 872)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'lblroom
        '
        Me.lblroom.AutoSize = True
        Me.lblroom.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblroom.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroom.Location = New System.Drawing.Point(231, 249)
        Me.lblroom.Name = "lblroom"
        Me.lblroom.Size = New System.Drawing.Size(236, 44)
        Me.lblroom.TabIndex = 24
        Me.lblroom.Text = " Rooms Available :"
        '
        'lblallocation
        '
        Me.lblallocation.AutoSize = True
        Me.lblallocation.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblallocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblallocation.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblallocation.Location = New System.Drawing.Point(231, 178)
        Me.lblallocation.Name = "lblallocation"
        Me.lblallocation.Size = New System.Drawing.Size(163, 44)
        Me.lblallocation.TabIndex = 25
        Me.lblallocation.Text = "Allocations :"
        '
        'ADash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1156, 967)
        Me.Controls.Add(Me.lblallocation)
        Me.Controls.Add(Me.lblroom)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbltotalusers)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ADash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADash"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltotalusers As Label
    Friend WithEvents Rooms As Button
    Friend WithEvents billing As Button
    Friend WithEvents reservations As Button
    Friend WithEvents residents As Button
    Friend WithEvents allocation As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnlogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents visitors As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents audit As Button
    Friend WithEvents complaints As Button
    Friend WithEvents lblroom As Label
    Friend WithEvents lblallocation As Label
End Class
