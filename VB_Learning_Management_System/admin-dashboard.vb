Public Class admin_home
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub admin_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Sbackbtn_Click(sender As Object, e As EventArgs) Handles Sbackbtn.Click
        Me.Close()
        admin_login.Show()
    End Sub
End Class