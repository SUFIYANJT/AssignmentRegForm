<%@ Page Language="C#" AutoEventWireup="true" CodeBehind=".aspx.cs" Inherits="AssignmentRegForm.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" 
    AutoGenerateColumns="False" 
    DataKeyNames="Id"
    OnRowDeleting="GridView1_RowDeleting">
</asp:GridView>


        </div>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
