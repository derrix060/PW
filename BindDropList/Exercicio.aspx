<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exercicio.aspx.cs" Inherits="BindDropList.Exercicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gridCliente" runat="server">
        </asp:GridView>
        <br />
        <asp:DropDownList ID="dropLivro" runat="server">
        </asp:DropDownList>
        <br />
    
    </div>
    </form>
</body>
</html>
