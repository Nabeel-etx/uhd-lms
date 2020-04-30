Public Class GPA_List
    Private Sub GPA_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_uhd_databaseDataSet1.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me._uhd_databaseDataSet1.Student)

    End Sub
End Class