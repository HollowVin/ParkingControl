Imports System.Data
Partial Class Home
    Inherits System.Web.UI.Page
    Dim datasetparkingspots As DataSet

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim id = Request.QueryString.Item("par_id")
            If Not id = 0 Then
                Dim ps As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")
                datasetparkingspots = ps.GetCoordinates(id)

                'HiddenLat.Value = datasetparkingspots.Tables(0).Rows(0).Item("par_latitude")
                'HiddenLong.Value = datasetparkingspots.Tables(0).Rows(0).Item("par_longitude")
            End If
        End If
    End Sub
End Class