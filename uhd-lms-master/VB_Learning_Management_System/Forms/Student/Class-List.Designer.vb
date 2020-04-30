<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Grade_List
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
        Me.components = New System.ComponentModel.Container()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UhddatabaseDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._uhd_databaseDataSet1 = New VB_Learning_Management_System._uhd_databaseDataSet1()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New VB_Learning_Management_System._uhd_databaseDataSet1TableAdapters.StudentTableAdapter()
        Me.AdminTableAdapter = New VB_Learning_Management_System._uhd_databaseDataSet1TableAdapters.AdminTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Class1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Class2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Class3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Class4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Class5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UhddatabaseDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._uhd_databaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.UhddatabaseDataSet1BindingSource
        '
        'UhddatabaseDataSet1BindingSource
        '
        Me.UhddatabaseDataSet1BindingSource.DataSource = Me._uhd_databaseDataSet1
        Me.UhddatabaseDataSet1BindingSource.Position = 0
        '
        '_uhd_databaseDataSet1
        '
        Me._uhd_databaseDataSet1.DataSetName = "_uhd_databaseDataSet1"
        Me._uhd_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "Admin"
        Me.AdminBindingSource.DataSource = Me.UhddatabaseDataSet1BindingSource
        '
        'StudentBindingSource1
        '
        Me.StudentBindingSource1.DataMember = "Student"
        Me.StudentBindingSource1.DataSource = Me.UhddatabaseDataSet1BindingSource
        '
        'AdminBindingSource1
        '
        Me.AdminBindingSource1.DataMember = "Admin"
        Me.AdminBindingSource1.DataSource = Me.UhddatabaseDataSet1BindingSource
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.Class1DataGridViewTextBoxColumn, Me.Class2DataGridViewTextBoxColumn, Me.Class3DataGridViewTextBoxColumn, Me.Class4DataGridViewTextBoxColumn, Me.Class5DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(1, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(787, 382)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
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
        'Class1DataGridViewTextBoxColumn
        '
        Me.Class1DataGridViewTextBoxColumn.DataPropertyName = "Class1"
        Me.Class1DataGridViewTextBoxColumn.HeaderText = "Class1"
        Me.Class1DataGridViewTextBoxColumn.Name = "Class1DataGridViewTextBoxColumn"
        '
        'Class2DataGridViewTextBoxColumn
        '
        Me.Class2DataGridViewTextBoxColumn.DataPropertyName = "Class2"
        Me.Class2DataGridViewTextBoxColumn.HeaderText = "Class2"
        Me.Class2DataGridViewTextBoxColumn.Name = "Class2DataGridViewTextBoxColumn"
        '
        'Class3DataGridViewTextBoxColumn
        '
        Me.Class3DataGridViewTextBoxColumn.DataPropertyName = "Class3"
        Me.Class3DataGridViewTextBoxColumn.HeaderText = "Class3"
        Me.Class3DataGridViewTextBoxColumn.Name = "Class3DataGridViewTextBoxColumn"
        '
        'Class4DataGridViewTextBoxColumn
        '
        Me.Class4DataGridViewTextBoxColumn.DataPropertyName = "Class4"
        Me.Class4DataGridViewTextBoxColumn.HeaderText = "Class4"
        Me.Class4DataGridViewTextBoxColumn.Name = "Class4DataGridViewTextBoxColumn"
        '
        'Class5DataGridViewTextBoxColumn
        '
        Me.Class5DataGridViewTextBoxColumn.DataPropertyName = "Class5"
        Me.Class5DataGridViewTextBoxColumn.HeaderText = "Class5"
        Me.Class5DataGridViewTextBoxColumn.Name = "Class5DataGridViewTextBoxColumn"
        '
        'StudentBindingSource2
        '
        Me.StudentBindingSource2.DataMember = "Student"
        Me.StudentBindingSource2.DataSource = Me.UhddatabaseDataSet1BindingSource
        '
        'Grade_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Grade_List"
        Me.Text = "Grade_List"
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UhddatabaseDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._uhd_databaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UhddatabaseDataSet1BindingSource As BindingSource
    Friend WithEvents _uhd_databaseDataSet1 As _uhd_databaseDataSet1
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As _uhd_databaseDataSet1TableAdapters.StudentTableAdapter
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents AdminTableAdapter As _uhd_databaseDataSet1TableAdapters.AdminTableAdapter
    Friend WithEvents StudentBindingSource1 As BindingSource
    Friend WithEvents AdminBindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Class1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Class2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Class3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Class4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Class5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentBindingSource2 As BindingSource
End Class
