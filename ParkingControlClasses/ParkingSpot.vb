Public Class ParkingSpot
    Public Property Code As Integer
    Public Property Name As String
    Public Property Address As String
    Public Property Capacity As Integer
    Public Property QuarterHourRate As Decimal
    Public Property HalfHourRate As Decimal
    Public Property HourRate As Decimal
    Public Property WorkDaysOpenTimes As OpenTimes
    Public Property WeekendsOpenTimes As OpenTimes
    Public Property CarsEntered As List(Of Car)
    Public Property FacturasEntered As List(Of Factura)

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
        CarsEntered = New List(Of Car)
    End Sub

    Public Function CarEnters(Car As Car) As Boolean
        If CarsEntered.Contains(Car) Then
            Return False
        Else
            Car.EnterTime = DateTime.Now
            CarsEntered.Add(Car)
            Return True
        End If
    End Function

    Public Function GetCarByPlateNumber(PlateNumber As String) As Car
        If CarsEntered.Exists(Function(x) x.PlateNumber = PlateNumber) Then
            Return CarsEntered.Find(Function(x) x.PlateNumber = PlateNumber)
        End If
        Return Nothing
    End Function

    Public Function CarExits(Car As Car) As Decimal
        If CarsEntered.Contains(Car) Then
            Dim ExitTime As DateTime = DateTime.Now
            Dim TimeDifference As TimeSpan = ExitTime - Car.EnterTime

            Dim Hours As Integer = TimeDifference.Hours
            Dim Minutes As Integer = TimeDifference.Minutes
            Dim QuarterMinutes = Minutes Mod 15

            Dim ChargeAmount As Decimal
            ChargeAmount = Hours * HourRate

            If QuarterMinutes = 1 Then
                ChargeAmount = ChargeAmount + QuarterHourRate
            ElseIf QuarterMinutes = 2 Then
                ChargeAmount = ChargeAmount + HalfHourRate
            Else
                ChargeAmount = ChargeAmount + HourRate
            End If

            Return ChargeAmount
        Else
            Return 0
        End If
    End Function

    Public Sub AddFactura(Factura As Factura)
        FacturasEntered.Add(Factura)
    End Sub
End Class
