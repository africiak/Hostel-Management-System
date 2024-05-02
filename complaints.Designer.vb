<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class complaints
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(complaints))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txtmailmessage = New System.Windows.Forms.RichTextBox()
        Me.purpose = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnsend = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtto = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtsubject = New System.Windows.Forms.MaskedTextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtfrom = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btndash = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnsend)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Location = New System.Drawing.Point(123, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(875, 794)
        Me.Panel2.TabIndex = 19
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Txtmailmessage)
        Me.Panel3.Controls.Add(Me.purpose)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(116, 445)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(643, 229)
        Me.Panel3.TabIndex = 21
        '
        'Txtmailmessage
        '
        Me.Txtmailmessage.Location = New System.Drawing.Point(152, 17)
        Me.Txtmailmessage.Name = "Txtmailmessage"
        Me.Txtmailmessage.Size = New System.Drawing.Size(456, 185)
        Me.Txtmailmessage.TabIndex = 23
        Me.Txtmailmessage.Text = ""
        '
        'purpose
        '
        Me.purpose.AutoSize = True
        Me.purpose.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purpose.Location = New System.Drawing.Point(14, 26)
        Me.purpose.Name = "purpose"
        Me.purpose.Size = New System.Drawing.Size(132, 42)
        Me.purpose.TabIndex = 6
        Me.purpose.Text = "Message:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label10.Location = New System.Drawing.Point(152, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(453, 5)
        Me.Label10.TabIndex = 5
        '
        'btnsend
        '
        Me.btnsend.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnsend.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsend.ForeColor = System.Drawing.Color.White
        Me.btnsend.Location = New System.Drawing.Point(116, 701)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(643, 71)
        Me.btnsend.TabIndex = 22
        Me.btnsend.Text = "Send Email"
        Me.btnsend.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(312, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(378, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 5)
        Me.Label3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Txtto)
        Me.Panel4.Location = New System.Drawing.Point(116, 233)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(643, 95)
        Me.Panel4.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 42)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "To:"
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label7.Location = New System.Drawing.Point(157, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(453, 5)
        Me.Label7.TabIndex = 5
        '
        'Txtto
        '
        Me.Txtto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtto.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtto.Location = New System.Drawing.Point(159, 27)
        Me.Txtto.Name = "Txtto"
        Me.Txtto.Size = New System.Drawing.Size(451, 36)
        Me.Txtto.TabIndex = 2
        Me.Txtto.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(364, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 56)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Complaints"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Txtsubject)
        Me.Panel5.Location = New System.Drawing.Point(116, 334)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(643, 95)
        Me.Panel5.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 42)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Subject:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label8.Location = New System.Drawing.Point(157, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(453, 5)
        Me.Label8.TabIndex = 5
        '
        'Txtsubject
        '
        Me.Txtsubject.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtsubject.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsubject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtsubject.Location = New System.Drawing.Point(157, 27)
        Me.Txtsubject.Name = "Txtsubject"
        Me.Txtsubject.Size = New System.Drawing.Size(448, 36)
        Me.Txtsubject.TabIndex = 2
        Me.Txtsubject.UseWaitCursor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Txtfrom)
        Me.Panel6.Location = New System.Drawing.Point(116, 132)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(643, 95)
        Me.Panel6.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 42)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "From:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Location = New System.Drawing.Point(157, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(453, 5)
        Me.Label5.TabIndex = 5
        '
        'Txtfrom
        '
        Me.Txtfrom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtfrom.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtfrom.Location = New System.Drawing.Point(157, 25)
        Me.Txtfrom.Name = "Txtfrom"
        Me.Txtfrom.Size = New System.Drawing.Size(453, 36)
        Me.Txtfrom.TabIndex = 2
        Me.Txtfrom.UseWaitCursor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.btndash)
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 95)
        Me.Panel1.TabIndex = 20
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
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label11.Location = New System.Drawing.Point(107, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 7)
        Me.Label11.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label12.Location = New System.Drawing.Point(96, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(194, 56)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "DormDash"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'complaints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1156, 907)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "complaints"
        Me.Text = "complaints"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents purpose As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnsend As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtto As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Txtsubject As MaskedTextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtfrom As MaskedTextBox
    Friend WithEvents Txtmailmessage As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btndash As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
