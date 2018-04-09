Public Class Factura
    Public Property Number As String
    Public Property CI As String
    Public Property Name As String
    Public Property EmissionDate As Date
    Public Property Address As String
    Public Property PhoneNumber As String
    Public Property Total As Decimal

    Public Sub New(Number As String, CI As String, Name As String, Address As String, PhoneNumber As String, Total As Decimal)
        Me.Number = Number
        Me.CI = CI
        Me.Name = Name
        EmissionDate = Date.Now
        Me.Address = Address
        Me.PhoneNumber = PhoneNumber
        Me.Total = Total
    End Sub
End Class
