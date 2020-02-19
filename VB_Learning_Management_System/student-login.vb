Imports System.Data.SqlClient

Public Class student_login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Sbackbtn.Click
        Me.Close()
        selection.Show()
    End Sub

    Private Sub Sexitlbl_Click(sender As Object, e As EventArgs) Handles Sexitlbl.Click
        Application.Exit()
    End Sub

    Private Sub Studentloginbtn_Click(sender As Object, e As EventArgs) Handles Studentloginbtn.Click
        Dim connection As New SqlConnection("Server=tcp:uhd-lms.database.windows.net,1433;Database=uhd-lms;
                                            User ID=uhdadmin@uhd-lms;Password=Password1;Trusted_Connection=False;Encrypt=True; ")

        Dim command As New SqlCommand("select * from Students where Username = @Username and Password = @Password", connection)

        command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Susernametxt.Text
        command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Spasswordtxt.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or password is invalid")
        Else
            Dim frm As New student_dashboard()
            Me.Hide()
            frm.Show()
        End If

    End Sub

    Private Sub Sshowpass_CheckedChanged(sender As Object, e As EventArgs) Handles Sshowpass.CheckedChanged
        With Sshowpass

            If .Checked Then
                Spasswordtxt.UseSystemPasswordChar = False
            Else
                Spasswordtxt.UseSystemPasswordChar = True
            End If

        End With
    End Sub
End Class