Imports System.Data

Partial Class Home
    Inherits System.Web.UI.Page
    Public DataSetParkingSpots As DataSet

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim PS As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\par_parkingspots.mdb")
            DataSetParkingSpots = PS.GetNames()
            GridViewPS.DataSource = DataSetParkingSpots.Tables(1)
            GridViewPS.DataBind()
        End If
    End Sub
End Class
