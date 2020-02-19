Public Class selection
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles youare.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        admin_login.Show()
        Me.Hide()
    End Sub

    Private Sub userbtn_Click(sender As Object, e As EventArgs) Handles userbtn.Click
        Me.Hide()
        student_login.Show()
    End Sub

    Private Sub selection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userbtn.Select()
    End Sub
End Class
