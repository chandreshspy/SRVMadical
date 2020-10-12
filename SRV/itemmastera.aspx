<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="itemmastera.aspx.cs" Inherits="SRV.itemmastera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
            color: #800000;
            background-color: #CCCCCC;
        }
        .auto-style2 {
            margin-left: 19px;
        }
        .auto-style3 {
            color: #CCCCCC;
        }
        .auto-style4 {
            color: #000000;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style3">
       <%-- @*Chandresh Welcome Test Code*@--%>
      
        <div class="auto-style1">
            <strong>-: ITEM MASTER :-</strong></div>
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style2" Height="126px" Width="1213px">
            <strong>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Text="Name:"></asp:Label>
            &nbsp;</strong><asp:TextBox ID="TextBox1" runat="server" Width="284px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
            <asp:Label ID="Label2" runat="server" CssClass="auto-style4" Text="Name:"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox2" runat="server" Width="284px"></asp:TextBox>
            </strong>
        </asp:Panel>
    
      
    </form>
    <p>
    </p>
</body>
</html>
