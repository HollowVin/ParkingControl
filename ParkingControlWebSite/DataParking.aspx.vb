Imports System.Data
Partial Class DataParking
    Inherits System.Web.UI.Page
    Public datasetparkingspots As DataSet
    Public Shared latitud, longitud As String

    Private Sub DataParking_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            IDLbl.Text = Request.QueryString.Item("par_id")
            Dim ps As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")
            'Dim coo As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")
            datasetparkingspots = ps.GetID(IDLbl.Text)
            'datasetparkingspots = coo.GetCoordinates(IDLbl.Text)

            NameLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_name")
            CapacityLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_capacity")
            FromLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_open_from_day")
            ToLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_open_to_day")
            OpenLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_open_from_hour")
            CloseLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_open_to_hour")
            QuarterLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_quarter_hour_rate")
            HalfLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_half_hour_rate")
            HourLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_hour_rate")
            latitud = datasetparkingspots.Tables(0).Rows(0).Item("par_latitude")
            longitud = datasetparkingspots.Tables(0).Rows(0).Item("par_longitude")
        End If
    End Sub
    Protected Sub CoordinatesBtn_Click(sender As Object, e As EventArgs) Handles CoordinatesBtn.Click
        Response.Redirect("Home.aspx?par_id=" & IDLbl.Text + "&par_lat=" & latitud + "&par_long=" & longitud)
    End Sub
End Class
