﻿Imports System.Data

Public Class ParkingSpotsDBConnection
    Private connection As System.Data.OleDb.OleDbConnection

    Public Sub New(ByVal sentence As String)
        connection = New Data.OleDb.OleDbConnection(sentence)
        connection.Open()
    End Sub

    Public Function GetNames() As DataSet
        Dim sentence As String = "Select par_id, par_name From par_parkingspots"
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

    Public Function InsertParkingSpot(P As ParkingControlClasses.ParkingSpot) As String
        Dim InsertSentence As String = "INSERT INTO par_parkingspots (par_name, par_address, par_capacity, par_quarter_hour_rate, par_half_hour_rate, par_hour_rate, par_open_from_day, par_open_to_day, par_open_from_hour, par_open_to_hour, par_latitude, par_longitude) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Dim Command As New Data.OleDb.OleDbCommand(InsertSentence, connection)

        Command.Parameters.AddWithValue("Name", P.Name)
        Command.Parameters.AddWithValue("Address", P.Address)
        Command.Parameters.AddWithValue("Capacity", P.Capacity)
        Command.Parameters.AddWithValue("QuarterHourRate", P.QuarterHourRate)
        Command.Parameters.AddWithValue("HalfHourRate", P.HalfHourRate)
        Command.Parameters.AddWithValue("HourRate", P.HourRate)
        Command.Parameters.AddWithValue("OpenFromDay", P.WorkDaysOpenTimes.FromDay.ToString)
        Command.Parameters.AddWithValue("OpenToDay", P.WorkDaysOpenTimes.ToDay.ToString)
        Command.Parameters.AddWithValue("OpenFromHour", P.WorkDaysOpenTimes.OpeningHour)
        Command.Parameters.AddWithValue("OpenToHour", P.WorkDaysOpenTimes.ClosingHour)
        Command.Parameters.AddWithValue("Latitude", P.Coordinates.Latitude)
        Command.Parameters.AddWithValue("Longitude", P.Coordinates.Longitude)

        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try

        Return Nothing

    End Function

    Public Function GetID(ByVal id As Integer) As DataSet

        Dim sentence As String = "Select par_name, par_capacity, par_quarter_hour_rate, par_half_hour_rate, par_hour_rate, par_open_from_day, par_open_to_day, par_open_from_hour, par_open_to_hour From par_parkingspots where par_id  = ?"
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

    Public Function GetAddress(ByVal id As Integer) As DataSet
        Dim sentence As String = "Select par_address From par_parkingspots where par_id = ?"
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

    Protected Overrides Sub Finalize()
        connection.Close()
        MyBase.Finalize()
    End Sub

End Class
