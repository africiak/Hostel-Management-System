<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profile))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.MaskedTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tel = New System.Windows.Forms.MaskedTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sex = New System.Windows.Forms.MaskedTextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.MaskedTextBox()
        Me.Profilepic = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Profilepic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(442, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(505, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 7)
        Me.Label3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(494, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 65)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Profile"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.fname)
        Me.Panel2.Location = New System.Drawing.Point(59, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 95)
        Me.Panel2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Location = New System.Drawing.Point(121, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(376, 10)
        Me.Label5.TabIndex = 5
        '
        'fname
        '
        Me.fname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fname.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.fname.Location = New System.Drawing.Point(121, 23)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(376, 36)
        Me.fname.TabIndex = 2
        Me.fname.UseWaitCursor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.tel)
        Me.Panel3.Location = New System.Drawing.Point(59, 525)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(518, 95)
        Me.Panel3.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.Location = New System.Drawing.Point(121, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(376, 10)
        Me.Label6.TabIndex = 5
        '
        'tel
        '
        Me.tel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tel.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tel.Location = New System.Drawing.Point(121, 24)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(376, 36)
        Me.tel.TabIndex = 2
        Me.tel.UseWaitCursor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.sex)
        Me.Panel4.Location = New System.Drawing.Point(59, 276)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(518, 95)
        Me.Panel4.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label7.Location = New System.Drawing.Point(121, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(376, 10)
        Me.Label7.TabIndex = 5
        '
        'sex
        '
        Me.sex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sex.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sex.Location = New System.Drawing.Point(121, 23)
        Me.sex.Name = "sex"
        Me.sex.Size = New System.Drawing.Size(376, 36)
        Me.sex.TabIndex = 2
        Me.sex.UseWaitCursor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.DOB)
        Me.Panel5.Location = New System.Drawing.Point(59, 403)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(518, 95)
        Me.Panel5.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label8.Location = New System.Drawing.Point(121, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(376, 10)
        Me.Label8.TabIndex = 5
        '
        'DOB
        '
        Me.DOB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DOB.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DOB.Location = New System.Drawing.Point(121, 23)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(376, 36)
        Me.DOB.TabIndex = 2
        Me.DOB.UseWaitCursor = True
        '
        'Profilepic
        '
        Me.Profilepic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Profilepic.Location = New System.Drawing.Point(670, 149)
        Me.Profilepic.Name = "Profilepic"
        Me.Profilepic.Size = New System.Drawing.Size(415, 259)
        Me.Profilepic.TabIndex = 8
        Me.Profilepic.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(670, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(415, 71)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(670, 549)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(415, 71)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Names"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 25)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "DOB"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 25)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Phone"
        '
        'profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 771)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Profilepic)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Name = "profile"
        Me.Text = "profile"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Profilepic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents fname As MaskedTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents tel As MaskedTextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents sex As MaskedTextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents DOB As MaskedTextBox
    Friend WithEvents Profilepic As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
End Class
