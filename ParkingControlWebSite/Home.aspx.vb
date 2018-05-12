Imports System.Data

Partial Class Home
    Inherits System.Web.UI.Page
    Public DataSetParkingSpots As DataSet

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim PS As New ParkingSpotsDBConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\corra\source\repos\ParkingControl\ParkingControlWebSite\db_parkingspots.accdb")
            DataSetParkingSpots = PS.GetNames()
            GridViewPS.DataSource = DataSetParkingSpots.Tables(0)
            GridViewPS.DataBind()
        End If
    End Sub
End Class
