Public Class ParkingSpot
    Public Property Code As Integer
    Public Property Name As String
    Public Property Address As String
    Public Property Capacity As Integer
    Public Property QuarterHourRate As Decimal
    Public Property HalfHourRate As Decimal
    Public Property HourRate As Decimal
    Public Property WorkDaysOpenTimes As OpenTime
    Public Property WeekendsOpenTimes As OpenTime
    Public Property CarsEntered As List(Of Car)
    Public Property FacturasEntered As List(Of Factura)
    Public Property NumberOfCars As Integer

    Public Sub New(Code As Integer, Name As String, Address As String, Capacity As Integer, QuarterHourRate As Decimal,
            HalfHourRate As Decimal, HourRate As Decimal, WorkDaysOpenTimes As OpenTime)
        Me.Code = Code
        Me.Name = Name
        Me.Address = Address
        Me.Capacity = Capacity
        Me.QuarterHourRate = QuarterHourRate
        Me.HalfHourRate = HalfHourRate
        Me.HourRate = HourRate
        Me.WorkDaysOpenTimes = WorkDaysOpenTimes
        'Me.WeekendsOpenTimes = WeekendsOpenTimes
        CarsEntered = New List(Of Car)
        FacturasEntered = New List(Of Factura)
        NumberOfCars = 0
    End Sub

    Public Function CarEnters(PlateNumber As String) As Boolean
        If Not GetCarByPlateNumber(PlateNumber) Is Nothing Then
            Return False
        Else
            NumberOfCars = NumberOfCars + 1
            Dim NewCar As Car = New Car(NumberOfCars, PlateNumber)
            CarsEntered.Add(NewCar)
            Return True
        End If
    End Function

    Public Function GetCarByPlateNumber(PlateNumber As String) As Car
        If CarsEntered.Exists(Function(x) x.PlateNumber = PlateNumber) Then
            Return CarsEntered.Find(Function(x) x.PlateNumber = PlateNumber)
        End If
        Return Nothing
    End Function

    Public Function ConsultPrice(PlateNumber As String) As Decimal
        Dim CarInside As Car = GetCarByPlateNumber(PlateNumber)

        If Not CarInside Is Nothing Then
            Dim ExitTime As DateTime = DateTime.Now
            Dim TimeDifference As TimeSpan = ExitTime - CarInside.EnterTime

            Dim Hours As Integer = TimeDifference.Hours
            Dim Minutes As Integer = TimeDifference.Minutes

            Dim ChargeAmount As Decimal
            ChargeAmount = Hours * HourRate

            If Minutes <= 15 Then
                ChargeAmount = ChargeAmount + QuarterHourRate
            ElseIf Minutes <= 30 Then
                ChargeAmount = ChargeAmount + HalfHourRate
            Else
                ChargeAmount = ChargeAmount + HourRate
            End If

            Return ChargeAmount
        Else
            Return 0
        End If
    End Function

    Public Function CarExits(PlateNumber As String) As Decimal
        Dim CarInside As Car = GetCarByPlateNumber(PlateNumber)

        If Not CarInside Is Nothing Then
            Dim ExitTime As DateTime = DateTime.Now
            Dim TimeDifference As TimeSpan = ExitTime - CarInside.EnterTime

            Dim Hours As Integer = TimeDifference.Hours
            Dim Minutes As Integer = TimeDifference.Minutes

            Dim ChargeAmount As Decimal
            ChargeAmount = Hours * HourRate

            If Minutes <= 15 Then
                ChargeAmount = ChargeAmount + QuarterHourRate
            ElseIf Minutes <= 30 Then
                ChargeAmount = ChargeAmount + HalfHourRate
            Else
                ChargeAmount = ChargeAmount + HourRate
            End If

            CarsEntered.Remove(CarInside)
            Return ChargeAmount
        Else
            Return 0
        End If
    End Function

    Public Sub AddFactura(Factura As Factura)
        FacturasEntered.Add(Factura)
    End Sub
End Class
