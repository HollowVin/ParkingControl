<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CustomerData.aspx.vb" Inherits="CostumerData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="par_id" HeaderText="ID" />
                    <asp:BoundField DataField="par_name" HeaderText="Name" />
                    <asp:BoundField DataField="par_name" HeaderText="Address" />
                    <asp:BoundField DataField="par_latitude" HeaderText="Latitude" />
                    <asp:BoundField DataField="par_longitude" HeaderText="Longitude" />
                </Columns>
            </asp:GridView>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ModifyBtn" runat="server" Text="Modify" />
        </div>
    </form>
</body>
</html>
