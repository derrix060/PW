<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="final.aspx.cs" Inherits="pw10_exemplo.final" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Button1 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        Codigo: <br />
    </p>
    <p>
        <input id="codigo" type="text" />&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Read" />
    </p>
    <p> 
        Nome: <br />   
    </p>
    <p>
        <input id="nome" type="text" /></p>
    <p>
        Email:</p>
    <p>
        <input id="email" type="text" /></p>
    <p>
        Telefone:</p>
    <p>
        <input id="telefone" type="text" /></p>
    <p>
        Senha:</p>
    <p>
        <input id="senha" type="password" /></p>
    <p>
        <input id="create" type="button" value="Create" onclick="Gravar()" /></p>
        
    </form>
</body>
</html>
