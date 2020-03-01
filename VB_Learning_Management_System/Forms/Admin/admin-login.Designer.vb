<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_login))
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.adminloginbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.showpass = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usernametxt
        '
        Me.usernametxt.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.Location = New System.Drawing.Point(188, 257)
        Me.usernametxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.usernametxt.MaxLength = 30
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(200, 32)
        Me.usernametxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 254)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 324)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 35)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'passwordtxt
        '
        Me.passwordtxt.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtxt.Location = New System.Drawing.Point(188, 324)
        Me.passwordtxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.passwordtxt.MaxLength = 30
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(200, 32)
        Me.passwordtxt.TabIndex = 2
        Me.passwordtxt.UseSystemPasswordChar = True
        '
        'adminloginbtn
        '
        Me.adminloginbtn.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminloginbtn.Location = New System.Drawing.Point(151, 426)
        Me.adminloginbtn.Name = "adminloginbtn"
        Me.adminloginbtn.Size = New System.Drawing.Size(130, 50)
        Me.adminloginbtn.TabIndex = 4
        Me.adminloginbtn.Text = "Login"
        Me.adminloginbtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 54)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Admin Login"
        '
        'Button2
        '
        Me.Button2.AccessibleName = "back"
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 45)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(194, 491)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 35)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Exit"
        '
        'showpass
        '
        Me.showpass.AutoSize = True
        Me.showpass.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpass.Location = New System.Drawing.Point(251, 366)
        Me.showpass.Name = "showpass"
        Me.showpass.Size = New System.Drawing.Size(141, 25)
        Me.showpass.TabIndex = 8
        Me.showpass.Text = "Show Password"
        Me.showpass.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(165, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 97)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'admin_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 553)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.showpass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.adminloginbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.usernametxt)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "admin_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usernametxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents adminloginbtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents showpass As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
