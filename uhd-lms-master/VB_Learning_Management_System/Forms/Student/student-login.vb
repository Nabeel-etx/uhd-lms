Imports System.Data.OleDb
Imports System.Data

Public Class student_login
    Dim connection As New OleDbConnection(My.Settings.uhd_databaseConnectionString)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Sbackbtn.Click
        Me.Close()
        selection.Show()
    End Sub

    Private Sub Sexitlbl_Click(sender As Object, e As EventArgs) Handles Sexitlbl.Click
        Application.Exit()
    End Sub

    Private Sub Studentloginbtn_Click(sender As Object, e As EventArgs) Handles Studentloginbtn.Click
        'Dim connection As New SqlConnection("Server=tcp:uhd-lms.database.windows.net,1433;Database=uhd-lms;
        '                                    User ID=uhdadmin@uhd-lms;Password=Password1;Trusted_Connection=False;Encrypt=True; ")

        'Dim command As New SqlCommand("select * from Students where Username = @Username and Password = @Password", connection)

        'command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Susernametxt.Text
        'command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Spasswordtxt.Text

        'Dim adapter As New SqlDataAdapter(command)
        'Dim table As New DataTable()

        'adapter.Fill(table)

        'If table.Rows.Count() <= 0 Then
        '    MessageBox.Show("Username or password is invalid")
        'Else
        '    Dim frm As New student_dashboard()
        '    Me.Hide()
        '    frm.Show()
        'End If
        If Susernametxt.Text = Nothing Or Spasswordtxt.Text = Nothing Then
            MsgBox("Enter valid credentials", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from Student where Username=? and Password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Susernametxt.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = Spasswordtxt.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If (count > 0) Then
                student_dashboard.Show()
            Else
                MsgBox("Account not found", MsgBoxStyle.Critical)
            End If

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