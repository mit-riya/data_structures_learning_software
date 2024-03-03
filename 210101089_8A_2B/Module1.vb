Imports System.Data.Odbc

Module Module1
    ' Global variables to store database query, command, data reader, connection, section ID, user ID, and username
    Public query As String
    Public dml As OdbcCommand
    Public dr As OdbcDataReader
    Public connector As OdbcConnection
    Public secid As Integer
    Public userid As Integer
    Public username As String

    ' Subroutine to establish an ODBC connection to the database
    Public Sub odbc_connection()
        ' Initialize the ODBC connection with the specified DSN (Data Source Name)
        connector = New OdbcConnection("DSN=ds_CS345;")

        ' Check if the connection is closed and open it if needed
        If connector.State = ConnectionState.Closed Then
            connector.Open()
        End If
    End Sub
End Module
