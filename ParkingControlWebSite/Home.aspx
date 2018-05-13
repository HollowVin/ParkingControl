<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .auto-style5 {
            height: 500px;
        }
    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDnvKku6Dvwj2sUhLKuND6spgINwKDmr7c&callback=initMap"></script>
    <script src="Map.js"></script>
    <div id="map_populate" style="width:100%; height:500px; border: 5px solid #5E5454;">  </div>
</asp:Content>