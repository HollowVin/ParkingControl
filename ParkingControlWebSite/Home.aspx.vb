Imports System.Data

Partial Class Home
    Inherits System.Web.UI.Page
    Public datasetparkingspots As DataSet

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim ps As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\par_parkingspots.mdb")
            datasetparkingspots = ps.GetNames()
            GridView1.DataSource = datasetparkingspots.Tables(1)
            GridView1.DataBind()
        End If
    End Sub
End Class
