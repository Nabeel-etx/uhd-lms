<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_home
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Abackbtn = New System.Windows.Forms.Button()
        Me.adminCtrl = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StdntListbtn = New System.Windows.Forms.Button()
        Me.AdminDesktop = New System.Windows.Forms.Panel()
        Me.adminCtrl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(419, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to admin dashboard"
        '
        'Abackbtn
        '
        Me.Abackbtn.AccessibleName = "back"
        Me.Abackbtn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abackbtn.Location = New System.Drawing.Point(13, 15)
        Me.Abackbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Abackbtn.Name = "Abackbtn"
        Me.Abackbtn.Size = New System.Drawing.Size(83, 44)
        Me.Abackbtn.TabIndex = 17
        Me.Abackbtn.Text = "Logout"
        Me.Abackbtn.UseVisualStyleBackColor = True
        '
        'adminCtrl
        '
        Me.adminCtrl.Controls.Add(Me.Button3)
        Me.adminCtrl.Controls.Add(Me.Button2)
        Me.adminCtrl.Controls.Add(Me.Button1)
        Me.adminCtrl.Controls.Add(Me.Label2)
        Me.adminCtrl.Controls.Add(Me.StdntListbtn)
        Me.adminCtrl.Location = New System.Drawing.Point(13, 82)
        Me.adminCtrl.Name = "adminCtrl"
        Me.adminCtrl.Size = New System.Drawing.Size(209, 570)
        Me.adminCtrl.TabIndex = 18
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(0, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(209, 57)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Assignments"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(209, 57)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Grades"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 57)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Courses"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dashboard"
        '
        'StdntListbtn
        '
        Me.StdntListbtn.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StdntListbtn.Location = New System.Drawing.Point(0, 69)
        Me.StdntListbtn.Name = "StdntListbtn"
        Me.StdntListbtn.Size = New System.Drawing.Size(209, 57)
        Me.StdntListbtn.TabIndex = 0
        Me.StdntListbtn.Text = "Students"
        Me.StdntListbtn.UseVisualStyleBackColor = True
        '
        'AdminDesktop
        '
        Me.AdminDesktop.AutoScroll = True
        Me.AdminDesktop.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminDesktop.Location = New System.Drawing.Point(238, 62)
        Me.AdminDesktop.Name = "AdminDesktop"
        Me.AdminDesktop.Size = New System.Drawing.Size(756, 590)
        Me.AdminDesktop.TabIndex = 19
        '
        'admin_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 703)
        Me.Controls.Add(Me.AdminDesktop)
        Me.Controls.Add(Me.adminCtrl)
        Me.Controls.Add(Me.Abackbtn)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimumSize = New System.Drawing.Size(1024, 750)
        Me.Name = "admin_home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_dashboard"
        Me.adminCtrl.ResumeLayout(False)
        Me.adminCtrl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Abackbtn As Button
    Friend WithEvents adminCtrl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents StdntListbtn As Button
    Friend WithEvents AdminDesktop As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
