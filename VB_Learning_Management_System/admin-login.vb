Imports System.Data.SqlClient

Public Class admin_login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles usernametxt.TextChanged

    End Sub

    Private Sub admin_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usernametxt.Select()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles passwordtxt.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        selection.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        With showpass

            If .Checked Then
                passwordtxt.UseSystemPasswordChar = False
            Else
                passwordtxt.UseSystemPasswordChar = True
            End If

        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles adminloginbtn.Click

        Dim connection As New SqlConnection("Server=tcp:uhd-lms.database.windows.net,1433;Database=uhd-lms;
                                            User ID=uhdadmin@uhd-lms;Password=Password1;Trusted_Connection=False;Encrypt=True; ")
        'Dim connection As New SqlConnection("Server= uhd-lms.database.windows.net; Database= uhd-lms; Integrated Security = true ")

        Dim command As New SqlCommand("select * from Users where Username = @Username and Password = @Password", connection)

        command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = usernametxt.Text
        command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = passwordtxt.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or password is invalid")
        Else
            Dim frm As New admin_home()
            Me.Hide()
            frm.Show()
        End If

        'If Not String.IsNullOrEmpty(usernametxt.Text) And
        '        Not String.IsNullOrEmpty(passwordtxt.Text) Then

        '    Dim SQL As String = String.Empty
        '    SQL &= "SELECT * FROM Users"
        '    SQL &= "WHERE Username = '" & usernametxt.Text & "' "
        '    SQL &= "AND Password = '" & passwordtxt.Text & "'"

        '    Dim UserData As DataTable = ExecuteSQL(SQL)

        '    If UserData.Rows.Count > 0 Then

        '        usernametxt.Clear()
        '        passwordtxt.Clear()
        '        showpass.Checked = False

        '        Me.Hide()

        '        Dim formMain As New MainForm()
        '        formMain.ShowDialog()
        '        formMain = Nothing
        '        Me.Show()
        '        Me.usernametxt.Select()


        '    Else
        '        MsgBox("The username or password is incorrect", MsgBoxStyle.Critical)
        '        usernametxt.Focus()
        '        usernametxt.SelectAll()
        '    End If

        'Else
        '    MsgBox("Please enter Username and Password", MsgBoxStyle.Critical)
        '    usernametxt.Select()
        'End If

    End Sub
End Class