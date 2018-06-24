Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Web.Configuration
Imports ParkingControlClasses
Imports System.Data

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class ParkingSpotsService
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function

    <WebMethod()>
    Public Function GetCoordinates(id As String) As DataSet
        Dim ps As New ParkingSpotsDBConnection(WebConfigurationManager.ConnectionStrings.Item("DBConnectionString").ToString)
        Return ps.GetCoordinates(id)
    End Function

    <WebMethod()>
    Public Function GetValues(id As String) As DataSet
        Dim ps As New ParkingSpotsDBConnection(WebConfigurationManager.ConnectionStrings.Item("DBConnectionString").ToString)
        Return ps.GetValues(id)
    End Function

    <WebMethod()>
    Public Function GetValuesAsArray() As DataSet
        Dim ps As New ParkingSpotsDBConnection(WebConfigurationManager.ConnectionStrings.Item("DBConnectionString").ToString)
        Dim Data As DataSet = ps.GetAllValues()
    End Function

    <WebMethod()>
    Public Function GetFrontValues() As DataSet
        Dim ps As New ParkingSpotsDBConnection(WebConfigurationManager.ConnectionStrings.Item("DBConnectionString").ToString)
        Return ps.GetFrontValues()
    End Function

    <WebMethod()>
    Public Function GetNames() As DataSet
        Dim ps As New ParkingSpotsDBConnection(WebConfigurationManager.ConnectionStrings.Item("DBConnectionString").ToString)
        Return ps.GetNames()
    End Function

    <WebMethod()>
    Public Function Modify(ByVal id As String, ByVal latitud As String, ByVal longitud As String) As String
        Dim ps As New ParkingSpotsDBConnection(WebConfigurationManager.ConnectionStrings.Item("DBConnectionString").ToString)
        Return ps.Modify(id, latitud, longitud)
    End Function
End Class