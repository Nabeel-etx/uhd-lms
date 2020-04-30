Public Class student_dashboard
    Private nowChildForm As Form
    Private Sub Sbackbtn_Click(sender As Object, e As EventArgs) Handles Sbackbtn.Click
        Me.Close()
        student_login.Show()
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        If nowChildForm IsNot Nothing Then
            nowChildForm.Close()
        End If
        nowChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        StudentDesktop.Controls.Add(childForm)
        StudentDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub studentGrade_Click(sender As Object, e As EventArgs)
        OpenChildForm(New Student_List)
    End Sub

    Private Sub ClassList_Click(sender As Object, e As EventArgs) Handles studentClass.Click
        OpenChildForm(New Grade_List)
    End Sub

    Private Sub ExamList_Click(sender As Object, e As EventArgs) Handles studentGrade.Click
        OpenChildForm(New Exam_List)
    End Sub

    Private Sub GPAList_Click(sender As Object, e As EventArgs) Handles studentGPA.Click
        OpenChildForm(New GPA_List)
    End Sub

    Private Sub StudentDesktop_Paint(sender As Object, e As PaintEventArgs) Handles StudentDesktop.Paint

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Me.Location = New Point(100, 100)
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll

    End Sub
End Class