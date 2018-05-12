Imports System.Data

Public Class ParkingSpotsDBConnection
    Private connection As System.Data.OleDb.OleDbConnection

    Public Sub New(ByVal sentence As String)
        connection = New Data.OleDb.OleDbConnection(sentence)
        connection.Open()
    End Sub

    Public Function GetNames() As DataSet
        Dim sentence As String = "Select par_name From par_parkingspots Order by par_id"
        Dim command As New Data.OleDb.OleDbCommand(sentence, connection)
        Dim adapter As New Data.OleDb.OleDbDataAdapter(command)
        Dim Data As New DataSet

        Try
            adapter.Fill(Data, "par_parkingspots")
        Catch ex As Exception
            Return Nothing
        End Try

        Return Data
    End Function

End Class
