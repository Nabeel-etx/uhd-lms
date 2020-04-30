<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exam_List
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._uhd_databaseDataSet1 = New VB_Learning_Management_System._uhd_databaseDataSet1()
        Me.UhddatabaseDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New VB_Learning_Management_System._uhd_databaseDataSet1TableAdapters.StudentTableAdapter()
        Me.StudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Class1ExamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Class2ExamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Class3ExamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Class4ExamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Class5ExamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._uhd_databaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UhddatabaseDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.Class1ExamDataGridViewTextBoxColumn, Me.Class2ExamDataGridViewTextBoxColumn, Me.Class3ExamDataGridViewTextBoxColumn, Me.Class4ExamDataGridViewTextBoxColumn, Me.Class5ExamDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(798, 450)
        Me.DataGridView1.TabIndex = 0
        '
        '_uhd_databaseDataSet1
        '
        Me._uhd_databaseDataSet1.DataSetName = "_uhd_databaseDataSet1"
        Me._uhd_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UhddatabaseDataSet1BindingSource
        '
        Me.UhddatabaseDataSet1BindingSource.DataSource = Me._uhd_databaseDataSet1
        Me.UhddatabaseDataSet1BindingSource.Position = 0
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.UhddatabaseDataSet1BindingSource
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'StudentBindingSource1
        '
        Me.StudentBindingSource1.DataMember = "Student"
        Me.StudentBindingSource1.DataSource = Me.UhddatabaseDataSet1BindingSource
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "Student-ID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student-ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'Class1ExamDataGridViewTextBoxColumn
        '
        Me.Class1ExamDataGridViewTextBoxColumn.DataPropertyName = "Class1 Exam"
        Me.Class1ExamDataGridViewTextBoxColumn.HeaderText = "Class1 Exam"
        Me.Class1ExamDataGridViewTextBoxColumn.Name = "Class1ExamDataGridViewTextBoxColumn"
        '
        'Class2ExamDataGridViewTextBoxColumn
        '
        Me.Class2ExamDataGridViewTextBoxColumn.DataPropertyName = "Class2 Exam"
        Me.Class2ExamDataGridViewTextBoxColumn.HeaderText = "Class2 Exam"
        Me.Class2ExamDataGridViewTextBoxColumn.Name = "Class2ExamDataGridViewTextBoxColumn"
        '
        'Class3ExamDataGridViewTextBoxColumn
        '
        Me.Class3ExamDataGridViewTextBoxColumn.DataPropertyName = "Class3 Exam"
        Me.Class3ExamDataGridViewTextBoxColumn.HeaderText = "Class3 Exam"
        Me.Class3ExamDataGridViewTextBoxColumn.Name = "Class3ExamDataGridViewTextBoxColumn"
        '
        'Class4ExamDataGridViewTextBoxColumn
        '
        Me.Class4ExamDataGridViewTextBoxColumn.DataPropertyName = "Class4 Exam"
        Me.Class4ExamDataGridViewTextBoxColumn.HeaderText = "Class4 Exam"
        Me.Class4ExamDataGridViewTextBoxColumn.Name = "Class4ExamDataGridViewTextBoxColumn"
        '
        'Class5ExamDataGridViewTextBoxColumn
        '
        Me.Class5ExamDataGridViewTextBoxColumn.DataPropertyName = "Class5 Exam"
        Me.Class5ExamDataGridViewTextBoxColumn.HeaderText = "Class5 Exam"
        Me.Class5ExamDataGridViewTextBoxColumn.Name = "Class5ExamDataGridViewTextBoxColumn"
        '
        'Exam_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Exam_List"
        Me.Text = "Exam_List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._uhd_databaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UhddatabaseDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UhddatabaseDataSet1BindingSource As BindingSource
    Friend WithEvents _uhd_databaseDataSet1 As _uhd_databaseDataSet1
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As _uhd_databaseDataSet1TableAdapters.StudentTableAdapter
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Class1ExamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Class2ExamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Class3ExamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Class4ExamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Class5ExamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentBindingSource1 As BindingSource
End Class
