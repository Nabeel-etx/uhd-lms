Imports System.Data.SqlClient
Module SQlLServerConnection

    Public StringConnection As String = "Server=tcp:uhd-lms.database.windows.net,1433;Database=uhd-lms;
                                         User ID=uhdadmin@uhd-lms;Password=Password1;Trusted_Connection=False;Encrypt=True; "

    Function ExecuteSQL(sql As String) As DataTable
        Try
            Dim connection As New SqlConnection
            Dim adapter As SqlDataAdapter
            Dim dt As New DataTable

            connection.ConnectionString = StringConnection
            connection.Open()

            adapter = New SqlDataAdapter(sql, connection)
            adapter.Fill(dt)

            connection.Close()
            connection = Nothing

            Return dt

        Catch ex As Exception

        End Try
    End Function
End Module
