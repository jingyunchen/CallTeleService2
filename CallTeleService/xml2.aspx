<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xml2.aspx.cs" Inherits="CallTeleService.xml2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" TransformFile="~/Contact.xslt"></asp:XmlDataSource>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>
