Imports System.Data
Partial Class _Default
    Inherits System.Web.UI.Page
    Public datasetparkingspots As DataSet
    Public Shared latitud, longitud As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Session("UserID") = 1
            showInfo()
        Else

        End If
    End Sub

    Private Sub showInfo()
        SessionState()
        Dim ps As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")
        datasetparkingspots = ps.GetFrontValues()
        GridView1.DataSource = datasetparkingspots.Tables(0)
        GridView1.DataBind()
    End Sub

    Public Class parkspotscls
        Private connection As System.Data.OleDb.OleDbConnection

        Public Sub New(ByVal sentence As String)
            connection = New Data.OleDb.OleDbConnection(sentence)
            connection.Open()
        End Sub
    End Class

    Protected Sub GridView1_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView1.RowCommand
        If SessionState() Then
            Response.Write("Su sesion ha expirado.")
            Response.Redirect("Default.aspx")
        Else
            Dim index As Integer = Convert.ToInt32(e.CommandArgument)
            Dim ID = GridView1.Rows(index).Cells(0).Text

            Dim ps As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")
            datasetparkingspots = ps.GetValues(ID)

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
            check2.Checked = True
        End If
    End Sub

    Private Function SessionState() As Boolean
        Dim Value As Boolean = False
        If (Session("UserID")) Is Nothing Then
            Value = True
        End If
        Return Value
    End Function


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SessionState() Then
            Response.Write("Su sesion ha expirado.")
            Response.Redirect("Default.aspx")
        Else
            Response.Redirect("Default.aspx?par_id=" & ID + "&par_lat=" & latitud + "&par_long=" & longitud)
        End If
    End Sub
End Class