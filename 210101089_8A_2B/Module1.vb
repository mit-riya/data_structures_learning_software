Imports System.Data.Odbc
Module Module1
    Public query As String
    Public dml As OdbcCommand
    Public dr As OdbcDataReader
    Public connector As OdbcConnection
    Public secid As Integer
    Public userid As Integer
    Public username As String

    Public Sub odbc_connection()
        connector = New OdbcConnection("DSN=ds_CS345;")
        If connector.State = ConnectionState.Closed Then
            connector.Open()
        End If
    End Sub
End Module
