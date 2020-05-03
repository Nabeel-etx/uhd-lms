<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_dashboard
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
        Me.Sbackbtn = New System.Windows.Forms.Button()
        Me.adminCtrl = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StdntListbtn = New System.Windows.Forms.Button()
        Me.adminCtrl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(254, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Student Dashboard"
        '
        'Sbackbtn
        '
        Me.Sbackbtn.AccessibleName = "back"
        Me.Sbackbtn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sbackbtn.Location = New System.Drawing.Point(12, 12)
        Me.Sbackbtn.Name = "Sbackbtn"
        Me.Sbackbtn.Size = New System.Drawing.Size(95, 48)
        Me.Sbackbtn.TabIndex = 17
        Me.Sbackbtn.Text = "Logout"
        Me.Sbackbtn.UseVisualStyleBackColor = True
        '
        'adminCtrl
        '
        Me.adminCtrl.Controls.Add(Me.Button3)
        Me.adminCtrl.Controls.Add(Me.Button2)
        Me.adminCtrl.Controls.Add(Me.Button1)
        Me.adminCtrl.Controls.Add(Me.Label3)
        Me.adminCtrl.Controls.Add(Me.StdntListbtn)
        Me.adminCtrl.Location = New System.Drawing.Point(12, 81)
        Me.adminCtrl.Name = "adminCtrl"
        Me.adminCtrl.Size = New System.Drawing.Size(209, 570)
        Me.adminCtrl.TabIndex = 19
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(0, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(209, 57)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Inbox"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(209, 57)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Calendar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 57)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Grades"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Home"
        '
        'StdntListbtn
        '
        Me.StdntListbtn.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StdntListbtn.Location = New System.Drawing.Point(0, 69)
        Me.StdntListbtn.Name = "StdntListbtn"
        Me.StdntListbtn.Size = New System.Drawing.Size(209, 57)
        Me.StdntListbtn.TabIndex = 0
        Me.StdntListbtn.Text = "Courses"
        Me.StdntListbtn.UseVisualStyleBackColor = True
        '
        'student_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 553)
        Me.Controls.Add(Me.adminCtrl)
        Me.Controls.Add(Me.Sbackbtn)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "student_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Dashboard"
        Me.adminCtrl.ResumeLayout(False)
        Me.adminCtrl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Sbackbtn As Button
    Friend WithEvents adminCtrl As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents StdntListbtn As Button
End Class
