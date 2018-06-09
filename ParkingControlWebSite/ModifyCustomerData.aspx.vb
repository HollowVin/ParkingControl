Imports System.Data
Partial Class ModifyCostumerData
    Inherits System.Web.UI.Page
    Public datasetparkingspots As DataSet

    Private Sub ModifyCostumerData_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim idMCD = Request.QueryString.Item("par_id")
            Dim ps As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")
            'Dim coo As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")
            datasetparkingspots = ps.GetValues(idMCD)

            IDLbl.Text = idMCD
            NameLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_name")
            AddressLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_address")
            LatTextBox.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_latitude")
            LongTextBox.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_longitude")
        End If
    End Sub
    Protected Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim ps As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")
        Dim descripcionerror As String = ps.Modify(IDLbl.Text, LatTextBox.Text, LongTextBox.Text)

        If descripcionerror = "" Then
            'Response.Write("<script> alert('Cliente eliminado.'); </script>")
            MsgBox("Cliente Modificado Correctamente.")
        Else
            'Response.Write("<script> alert('" & descripcionerror & "'); </script>")
            MsgBox(descripcionerror)
        End If

        Response.Redirect("CustomerData.aspx")
    End Sub
    Protected Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Response.Redirect("CustomerData.aspx")
    End Sub
End Class
