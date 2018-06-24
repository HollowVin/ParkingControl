<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    </head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager> 
        <div style="background-color: #17A086; text-align: center;">
            <span class="auto-style5">Parking Find</span><br />
            <span class="auto-style6"><em>Encuentra parqueaderos disponibles cercanos a ti</em></span>
        </div>
        <asp:CheckBox runat="server" id="check2"/>
        <asp:CheckBox runat="server" id="check"/>
        <label for="check" class="icon-menu">&nbsp;&nbsp;&nbsp;Ver Parqueaderos</label>
        <br />
        <nav class="menu">
        <ul>
            <li>
                <a>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderStyle="None" GridLines="None">
                        <Columns>
                            <asp:BoundField DataField="par_id" HeaderText="ID" />
                            <asp:BoundField DataField="par_name" HeaderText="Nombre" />
                            <asp:BoundField DataField="par_address" ReadOnly="True" HeaderText="Dirección" />
                            <asp:BoundField DataField="par_spaces" HeaderText="Espacios Libres" />
                            <asp:ButtonField ButtonType="Image" HeaderText="Ruta" ImageUrl="~/Resources/right-arrow.png" Text="Detalles" />
                        </Columns>
                        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" BorderWidth="20px" BorderColor="#2D3E50"/>
                    </asp:GridView>
                </a>
                <ul>
                    <li>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server"> 
                        <ContentTemplate>
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
                         </ContentTemplate>
                        </asp:UpdatePanel>
                    </li>
                </ul>
            </li>
        </ul>
        </nav>
        <br />
        <hr />
        <table class="auto-style4">
            <tr>
                <td class="auto-style3">
                    <script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDnvKku6Dvwj2sUhLKuND6spgINwKDmr7c&callback=initMap"></script>
                    <script src="Map.js"></script>
                    <div id="map_populate" style="height:500px; border: 5px solid #5E5454;">
                    </div>
                </td>
            </tr>
        </table>
        <br />
        <div id="footerBar" style="height: 89px; text-align: right; color: #C0C0C0; font-size: x-small; font-family: Arial, Helvetica, sans-serif; background-color: #2D3E50">
            <br />
            <br />
            <br />
            Copyright: Sergio Ochoa, Juan Corral
        </div>
    </form>
</body>
</html>


