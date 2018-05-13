Imports System.Data
Partial Class Home
    Inherits System.Web.UI.Page
    Dim datasetparkingspots As DataSet
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim address As String
            Dim ID As Integer = Request.QueryString.Item("par_id")
            Dim ps As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")

            If Not ID.Equals(0) Then
                datasetparkingspots = ps.GetAddress(ID)
                address = datasetparkingspots.Tables(0).Rows(0).Item("par_address")
            End If
            ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "getmap(" + address + ");", True)
        End If
    End Sub
End Class