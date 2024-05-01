<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmlogin))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Lregister = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(352, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 5)
        Me.Label2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(342, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 65)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtpass)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(118, 231)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(594, 95)
        Me.Panel3.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Location = New System.Drawing.Point(91, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(486, 5)
        Me.Label5.TabIndex = 5
        '
        'txtpass
        '
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpass.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtpass.Location = New System.Drawing.Point(91, 23)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(486, 36)
        Me.txtpass.TabIndex = 2
        Me.txtpass.UseSystemPasswordChar = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(44, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtemail)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(118, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(594, 95)
        Me.Panel2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(91, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(486, 5)
        Me.Label4.TabIndex = 5
        '
        'txtemail
        '
        Me.txtemail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtemail.Location = New System.Drawing.Point(91, 23)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(486, 36)
        Me.txtemail.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(44, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.Font = New System.Drawing.Font("Poppins Medium", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.Location = New System.Drawing.Point(108, 348)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(604, 89)
        Me.btnlogin.TabIndex = 10
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'Lregister
        '
        Me.Lregister.ActiveLinkColor = System.Drawing.SystemColors.MenuText
        Me.Lregister.AutoSize = True
        Me.Lregister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lregister.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lregister.LinkColor = System.Drawing.SystemColors.Highlight
        Me.Lregister.Location = New System.Drawing.Point(520, 479)
        Me.Lregister.Name = "Lregister"
        Me.Lregister.Size = New System.Drawing.Size(112, 42)
        Me.Lregister.TabIndex = 11
        Me.Lregister.TabStop = True
        Me.Lregister.Text = " Sign up"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(136, 479)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(359, 42)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Already have an account?"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Lregister)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnlogin)
        Me.Panel1.Location = New System.Drawing.Point(95, 96)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 40, 3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 548)
        Me.Panel1.TabIndex = 13
        '
        'Frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1156, 771)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frmlogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmlogin"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpass As MaskedTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtemail As MaskedTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents Lregister As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
End Class
