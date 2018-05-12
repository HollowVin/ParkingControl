<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDnvKku6Dvwj2sUhLKuND6spgINwKDmr7c&callback=initMap" type="text/javascript"></script>
    <script src="mapa.js"></script>
    <div id="map_populate" style="width:100%; height:500px; border: 5px solid #5E5454;">  </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div id="parkingspots" Style="height:500px;">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="par_name" HeaderText="Parqueaderos Disponibles" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>