<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xml.aspx.cs" Inherits="CallTeleService.xml" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a href="data.xml">another format</a>
     <div runat="server" id="div1" ></div>

      <asp:Xml ID="Xml1" runat="server"></asp:Xml>

    </form>
</body>
</html>
