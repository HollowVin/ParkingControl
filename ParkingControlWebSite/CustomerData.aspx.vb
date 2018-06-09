Imports System.Data
Partial Class CostumerData
    Inherits System.Web.UI.Page
    Public datasetparkingspots As DataSet

    Private Sub CostumerData_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim ps As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")
            datasetparkingspots = ps.GetNames()
            GridView1.DataSource = datasetparkingspots.Tables(0)
            GridView1.DataBind()
        End If
    End Sub

    Protected Sub ModifyBtn_Click(sender As Object, e As EventArgs) Handles ModifyBtn.Click
        Response.Redirect("ModifyCustomerData.aspx?par_id=" & GridView1.Rows.Item(GridView1.SelectedIndex).Cells(1).Text)
    End Sub
End Class
