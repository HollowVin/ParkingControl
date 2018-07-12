<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:CheckBox runat="server" id="check"/>
        <asp:CheckBox runat="server" id="check2"/>
        <div style="height:75px; width:100%; background-color: #A4C131; text-align: center;">
            <span class="auto-style5">Parking Find</span><br />
            <!--span class="auto-style6"><em>Encuentra parqueaderos cercanos a ti</em></span-->
        </div>
        <div id="menuh">
            <ul id="button">
                <li><label for="check">Parqueaderos</label></li>
                <li><a href="PreguntasFrecuentes.html">Preguntas Frecuentes</a></li>
            </ul>
        </div>
        <div class="menu">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderStyle="None" GridLines="None" CellPadding="60" CellSpacing="30">
                <Columns>
                    <asp:BoundField DataField="par_id" HeaderText="ID" />
                    <asp:BoundField DataField="par_name" HeaderText="Nombre" />
                    <asp:BoundField DataField="par_address" ReadOnly="True" HeaderText="Dirección" />
                    <asp:BoundField DataField="par_spaces" HeaderText="Espacios Libres" />
                    <asp:ButtonField ButtonType="Image" HeaderText="Ruta" ImageUrl="~/Resources/right-arrow.png" />
                </Columns>
                <RowStyle HorizontalAlign="Left" VerticalAlign="Middle" BorderWidth="30px" BorderColor="#05172F"/>
            </asp:GridView>
        </div>
        <div class="menu2">
            <p>
                Nombre:
                <asp:Label ID="NameLbl" runat="server" Text="Label" />
            </p>
            <br />
            <br />
            <p>
                Capacidad:&nbsp;
                <asp:Label ID="CapacityLbl" runat="server" Text="Label"/>
            </p>
            <br />
            <br />
            <p>
                Atencion:</p>
            <p>
                De:&nbsp;&nbsp;&nbsp;
                <asp:Label ID="FromLbl" runat="server" Text="Label"/>
                &nbsp;&nbsp;&nbsp; a&nbsp;&nbsp;&nbsp;
                <asp:Label ID="ToLbl" runat="server" Text="Label"/>
                &nbsp;&nbsp;&nbsp;&nbsp;
            </p>
            <br />
            <br />
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hora de Apertura:&nbsp;&nbsp;&nbsp;
                <asp:Label ID="OpenLbl" runat="server" Text="Label"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hora de Cierre:&nbsp;&nbsp;&nbsp;
                <asp:Label ID="CloseLbl" runat="server" Text="Label"/>
            </p>
            <br />
            <br />
            <p>
                Tarifas:</p>
            <p>
                15 min:&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Label ID="QuarterLbl" runat="server" Text="Label" />
            </p>
            <br />
            <br />
            <p>
                30 min:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="HalfLbl" runat="server" Text="Label" />
            </p>
            <br />
            <br />
            <p>
                1 hora:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="HourLbl" runat="server" Text="Label"/>
            </p>
            <br />
            <br />
            <p>
                <asp:Button ID="Button1" runat="server" Text="Llévame allá" Width="100px"/>
            </p>
        </div>
        <br />
        <table class="auto-style4">
            <tr>
                <td class="auto-style3">
                    <div id="map_populate" style="height:495px; border: 5px solid #5E5454;"></div>
                    <div id="legend"><h3>Marcadores</h3></div>
                    <script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDnvKku6Dvwj2sUhLKuND6spgINwKDmr7c&callback=initMap"></script>
                    <script src="Map.js"></script>
                </td>
            </tr>
        </table>
        <br />
        <div id="footerBar" >
            <p style="float:left; padding-left: 15px; text-align:left">
                Av.24 de Mayo y Hernán Malo.
                <br />
                <br />
                Telefono: (593) 7 4076281
                <br />
                <br />
                Cuenca- Ecuador
            </p>
            <br />
            <br />
            <br />
            Copyright: ACOOCH
        </div>
    </form>
</body>
</html>


