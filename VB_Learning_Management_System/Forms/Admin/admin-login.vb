Imports System.Data.OleDb
Imports System.Data

Public Class admin_login
    Dim connection As New OleDbConnection(My.Settings.uhd_databaseConnectionString)
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

        If usernametxt.Text = Nothing Or passwordtxt.Text = Nothing Then
            MsgBox("Enter valid credentials", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from Admin where Username=? and Password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = usernametxt.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = passwordtxt.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                admin_home.Show()
            Else
                MsgBox("Account not found", MsgBoxStyle.Critical)
            End If

        End If

    End Sub
End Class