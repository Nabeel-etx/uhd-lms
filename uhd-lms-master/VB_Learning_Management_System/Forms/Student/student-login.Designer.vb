<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class student_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(student_login))
        Me.Sshowpass = New System.Windows.Forms.CheckBox()
        Me.Sexitlbl = New System.Windows.Forms.Label()
        Me.Sbackbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Studentloginbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Spasswordtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Susernametxt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sshowpass
        '
        Me.Sshowpass.AutoSize = True
        Me.Sshowpass.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sshowpass.Location = New System.Drawing.Point(253, 356)
        Me.Sshowpass.Name = "Sshowpass"
        Me.Sshowpass.Size = New System.Drawing.Size(113, 21)
        Me.Sshowpass.TabIndex = 18
        Me.Sshowpass.Text = "Show Password"
        Me.Sshowpass.UseVisualStyleBackColor = True
        '
        'Sexitlbl
        '
        Me.Sexitlbl.AutoSize = True
        Me.Sexitlbl.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sexitlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Sexitlbl.Location = New System.Drawing.Point(188, 487)
        Me.Sexitlbl.Name = "Sexitlbl"
        Me.Sexitlbl.Size = New System.Drawing.Size(45, 27)
        Me.Sexitlbl.TabIndex = 17
        Me.Sexitlbl.Text = "Exit"
        '
        'Sbackbtn
        '
        Me.Sbackbtn.AccessibleName = "back"
        Me.Sbackbtn.Location = New System.Drawing.Point(12, 12)
        Me.Sbackbtn.Name = "Sbackbtn"
        Me.Sbackbtn.Size = New System.Drawing.Size(71, 48)
        Me.Sbackbtn.TabIndex = 16
        Me.Sbackbtn.Text = "back"
        Me.Sbackbtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 42)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Student Login"
        '
        'Studentloginbtn
        '
        Me.Studentloginbtn.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Studentloginbtn.Location = New System.Drawing.Point(147, 414)
        Me.Studentloginbtn.Name = "Studentloginbtn"
        Me.Studentloginbtn.Size = New System.Drawing.Size(138, 50)
        Me.Studentloginbtn.TabIndex = 14
        Me.Studentloginbtn.Text = "Login"
        Me.Studentloginbtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 316)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 27)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password:"
        '
        'Spasswordtxt
        '
        Me.Spasswordtxt.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spasswordtxt.Location = New System.Drawing.Point(186, 316)
        Me.Spasswordtxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Spasswordtxt.MaxLength = 30
        Me.Spasswordtxt.Name = "Spasswordtxt"
        Me.Spasswordtxt.Size = New System.Drawing.Size(208, 27)
        Me.Spasswordtxt.TabIndex = 12
        Me.Spasswordtxt.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 251)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 27)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Username:"
        '
        'Susernametxt
        '
        Me.Susernametxt.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Susernametxt.Location = New System.Drawing.Point(186, 254)
        Me.Susernametxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Susernametxt.MaxLength = 30
        Me.Susernametxt.Name = "Susernametxt"
        Me.Susernametxt.Size = New System.Drawing.Size(208, 27)
        Me.Susernametxt.TabIndex = 10
        Me.Susernametxt.Text = "first"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(190, 156)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'student_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 553)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Sshowpass)
        Me.Controls.Add(Me.Sexitlbl)
        Me.Controls.Add(Me.Sbackbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Studentloginbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Spasswordtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Susernametxt)
        Me.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "student_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sshowpass As CheckBox
    Friend WithEvents Sexitlbl As Label
    Friend WithEvents Sbackbtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Studentloginbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Spasswordtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Susernametxt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
