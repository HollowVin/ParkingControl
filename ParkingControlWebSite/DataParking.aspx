<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="DataParking.aspx.vb" Inherits="DataParking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            margin-left: 40px;
        }
        .auto-style6 {
            margin-left: 80px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="ParkingData" style="height:350px;" class="auto-style6">
    <p>
            Nombre:
            <asp:Label ID="NameLbl" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
            Capacidad:&nbsp;
            <asp:Label ID="CapacityLbl" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
            Atencion:</p>
    <p>
            De:&nbsp;&nbsp;&nbsp;
            <asp:Label ID="FromLbl" runat="server" Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp; a&nbsp;&nbsp;&nbsp;
            <asp:Label ID="ToLbl" runat="server" Text="Label"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hora de Apertura:&nbsp;&nbsp;&nbsp;
                <asp:Label ID="OpenLbl" runat="server" Text="Label"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hora de Cierre:&nbsp;&nbsp;&nbsp;
                <asp:Label ID="CloseLbl" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
            Tarifas:</p>
    <p>
            15 min:&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Label ID="QuarterLbl" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
            30 min:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="HalfLbl" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
            1 hora:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="HourLbl" runat="server" Text="Label"></asp:Label>
    </p>
</div>
<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="CoordinatesBtn" runat="server" Text="Llévame allá"/>
&nbsp;
</asp:Content>

