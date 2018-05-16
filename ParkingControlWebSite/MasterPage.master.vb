Imports System.Data
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage
    Public datasetparkingspots As DataSet

    Private Sub MasterPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim ps As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")
            datasetparkingspots = ps.GetNames()
            GridView1.DataSource = datasetparkingspots.Tables(0)
            GridView1.DataBind()
        End If
    End Sub

    Public Class parkspotscls
        Private connection As System.Data.OleDb.OleDbConnection

        Public Sub New(ByVal sentence As String)
            connection = New Data.OleDb.OleDbConnection(sentence)
            connection.Open()
        End Sub
    End Class
    Protected Sub getAddress_Click(sender As Object, e As EventArgs) Handles getAddress.Click
        Dim ps As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")
        Dim idhome As Integer
        datasetparkingspots = ps.GetID(GridView1.Rows.Item(GridView1.SelectedIndex).Cells(1).Text)
        idhome = datasetparkingspots.Tables(0).Rows(0).Item("par_id")
        Response.Redirect("DataParking.aspx?par_id=" & idhome)
    End Sub
End Class