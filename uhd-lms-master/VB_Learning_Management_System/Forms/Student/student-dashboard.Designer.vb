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
        Me.StudentDesktop = New System.Windows.Forms.Panel()
        Me.studentGPA = New System.Windows.Forms.Button()
        Me.studentGrade = New System.Windows.Forms.Button()
        Me.studentClass = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(394, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 27)
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
        'StudentDesktop
        '
        Me.StudentDesktop.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.StudentDesktop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StudentDesktop.Location = New System.Drawing.Point(151, 59)
        Me.StudentDesktop.Name = "StudentDesktop"
        Me.StudentDesktop.Size = New System.Drawing.Size(700, 460)
        Me.StudentDesktop.TabIndex = 19
        '
        'studentGPA
        '
        Me.studentGPA.AutoEllipsis = True
        Me.studentGPA.BackColor = System.Drawing.SystemColors.ControlLight
        Me.studentGPA.Location = New System.Drawing.Point(12, 442)
        Me.studentGPA.Name = "studentGPA"
        Me.studentGPA.Size = New System.Drawing.Size(104, 31)
        Me.studentGPA.TabIndex = 20
        Me.studentGPA.Text = "GPA"
        Me.studentGPA.UseVisualStyleBackColor = False
        '
        'studentGrade
        '
        Me.studentGrade.Location = New System.Drawing.Point(12, 256)
        Me.studentGrade.Name = "studentGrade"
        Me.studentGrade.Size = New System.Drawing.Size(104, 32)
        Me.studentGrade.TabIndex = 21
        Me.studentGrade.Text = "Exams"
        Me.studentGrade.UseVisualStyleBackColor = True
        '
        'studentClass
        '
        Me.studentClass.Location = New System.Drawing.Point(12, 101)
        Me.studentClass.Name = "studentClass"
        Me.studentClass.Size = New System.Drawing.Size(104, 36)
        Me.studentClass.TabIndex = 22
        Me.studentClass.Text = "Classes Enrolled"
        Me.studentClass.UseVisualStyleBackColor = True
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(149, 522)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(700, 17)
        Me.HScrollBar1.TabIndex = 23
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(858, 59)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 460)
        Me.VScrollBar1.TabIndex = 24
        '
        'student_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 553)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.studentClass)
        Me.Controls.Add(Me.studentGrade)
        Me.Controls.Add(Me.studentGPA)
        Me.Controls.Add(Me.StudentDesktop)
        Me.Controls.Add(Me.Sbackbtn)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "student_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Sbackbtn As Button
    Friend WithEvents StudentDesktop As Panel
    Friend WithEvents studentGPA As Button
    Friend WithEvents studentGrade As Button
    Friend WithEvents studentClass As Button
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
