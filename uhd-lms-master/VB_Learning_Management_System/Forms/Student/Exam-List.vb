Public Class Exam_List
    Private Sub Exam_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_uhd_databaseDataSet1.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me._uhd_databaseDataSet1.Student)

    End Sub
End Class