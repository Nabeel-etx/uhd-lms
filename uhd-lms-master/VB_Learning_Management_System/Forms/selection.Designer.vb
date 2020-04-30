<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class selection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(selection))
        Me.youare = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.userbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'youare
        '
        Me.youare.AutoSize = True
        Me.youare.Font = New System.Drawing.Font("Calibri Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.youare.Location = New System.Drawing.Point(170, 227)
        Me.youare.Name = "youare"
        Me.youare.Size = New System.Drawing.Size(152, 49)
        Me.youare.TabIndex = 0
        Me.youare.Text = "You are:"
        '
        'Button1
        '
        Me.Button1.AccessibleDescription = "adminbtn"
        Me.Button1.AccessibleName = "adminbtn"
        Me.Button1.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(279, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 70)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Admin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'userbtn
        '
        Me.userbtn.AccessibleDescription = "userbtn"
        Me.userbtn.AccessibleName = "userbtn"
        Me.userbtn.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userbtn.Location = New System.Drawing.Point(63, 318)
        Me.userbtn.Name = "userbtn"
        Me.userbtn.Size = New System.Drawing.Size(150, 70)
        Me.userbtn.TabIndex = 2
        Me.userbtn.Text = "User"
        Me.userbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome Screen"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(183, 108)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'selection
        '
        Me.AccessibleDescription = "Selection"
        Me.AccessibleName = "Select One"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 503)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.userbtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.youare)
        Me.Name = "selection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select One"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents youare As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents userbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
