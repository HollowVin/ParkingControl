Public Class ParkingSpot
    Public Property Code As Integer
    Public Property Name As String
    Public Property Address As String
    Public Property Capacity As Integer
    Public Property QuarterHourRate As Decimal
    Public Property HalfHourRate As Decimal
    Public Property HourRate As Decimal
    'Public Property WorkDaysOpenTimes As OpenTimes
    'Public Property WeekendsOpenTimes As OpenTimes
    'Public Property CarsEntered As List(Of Car)

    Public Sub New(Code As Integer, Name As String, Address As String, Capacity As Integer, QuarterHourRate As Decimal,
            HalfHourRate As Decimal, HourRate As Decimal)
        Me.Code = Code
        Me.Name = Name
        Me.Address = Address
        Me.Capacity = Capacity
        Me.QuarterHourRate = QuarterHourRate
        Me.HalfHourRate = HalfHourRate
        Me.HourRate = HourRate
        'Me.WorkDaysOpenTimes = WorkDaysOpenTimes
        'Me.WeekendsOpenTimes = WeekendsOpenTimes
        'CarsEntered = New List(Of Car)
    End Sub
End Class
