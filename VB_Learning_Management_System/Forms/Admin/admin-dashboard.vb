Public Class admin_home
    Private currentChildForm As Form
    Private Sub Sbackbtn_Click(sender As Object, e As EventArgs) Handles Abackbtn.Click
        Me.Close()
        admin_login.Show()
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        AdminDesktop.Controls.Add(childForm)
        AdminDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub StdntListbtn_Click(sender As Object, e As EventArgs) Handles StdntListbtn.Click
        OpenChildForm(New Student_List)
    End Sub


End Class