Public Class Grade_List

    Private Sub Grade_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StudentTableAdapter.Fill(Me._uhd_databaseDataSet1.Student)

    End Sub

End Class