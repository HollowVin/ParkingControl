Imports System.Data

Public Class ParkingSpotsDBConnection
    Private connection As System.Data.OleDb.OleDbConnection

    Public Sub New(ByVal sentence As String)
        connection = New Data.OleDb.OleDbConnection(sentence)
        connection.Open()
    End Sub

    Public Function GetNames() As DataSet
        Dim sentence As String = "Select par_id, par_name, par_address, par_latitude, par_longitude From par_parkingspots"
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

    Public Function GetID(ByVal name As String) As DataSet
        Dim sentence As String = "Select par_id From par_parkingspots where par_name  = ?"
        Dim command As New Data.OleDb.OleDbCommand(sentence, connection)
        Dim adapter As New Data.OleDb.OleDbDataAdapter(command)
        Dim Data As New DataSet

        command.Parameters.AddWithValue("par_name", name)

        Try
            adapter.Fill(Data, "par_parkingspots")
        Catch ex As Exception
            Return Nothing
        End Try

        Return Data
    End Function

    Public Function GetValues(ByVal id As Integer) As DataSet

        Dim sentence As String = "Select par_name, par_capacity, par_address, par_quarter_hour_rate, par_half_hour_rate, par_hour_rate, par_open_from_day, par_open_to_day, par_open_from_hour, par_open_to_hour, par_latitude, par_longitude From par_parkingspots where par_id  = ?"
        Dim command As New Data.OleDb.OleDbCommand(sentence, connection)
        Dim adapter As New Data.OleDb.OleDbDataAdapter(command)
        Dim Data As New DataSet

        command.Parameters.AddWithValue("par_id", id)

        Try
            adapter.Fill(Data, "par_parkingspots")
        Catch ex As Exception
            Return Nothing
        End Try

        Return Data

    End Function

    Public Function GetCoordinates(ByVal id As Integer) As DataSet
        Dim sentence As String = "Select par_latitude, par_longitude From par_parkingspots where par_id = ?"
        Dim command As New Data.OleDb.OleDbCommand(sentence, connection)
        Dim adapter As New Data.OleDb.OleDbDataAdapter(command)
        Dim Data As New DataSet

        command.Parameters.AddWithValue("par_id", id)

        Try
            adapter.Fill(Data, "par_parkingspots")
        Catch ex As Exception
            Return Nothing
        End Try

        Return Data

    End Function

    Public Function Modify(ByVal id As String, ByVal latitud As String, ByVal longitud As String) As String
        Dim Sentence As String = "Update par_parkingspots set par_latitude=?, par_longitude=? where par_id=?"
        Dim Comando As New Data.OleDb.OleDbCommand(Sentence, connection)

        Comando.Parameters.AddWithValue("par_latitude", latitud)
        Comando.Parameters.AddWithValue("par_longitude", longitud)
        Comando.Parameters.AddWithValue("par_id", id)

        Try
            Comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try

        Return Nothing
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class
