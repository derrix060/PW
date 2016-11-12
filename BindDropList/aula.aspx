<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aula.aspx.cs" Inherits="BindDropList.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>pw2016-13 - Mario Apra</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
</head>
<body>
    <form id="formCliente" runat="server">
    <div class ="container">
        <h1>Cliente</h1>


    </div>
        <asp:GridView ID="GridView1" runat="server" Height="128px" Width="259px">
        </asp:GridView>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:ListView ID="ListView1" runat="server">
            <ItemTemplate>
                <table>
                    <tr><td><%# Eval("nome") %></td></tr>
                    <tr><td><%# Eval("codigo") %></td></tr>
                    <tr><td><%# Eval("valor") %></td></tr>
                </table>
            </ItemTemplate>
        </asp:ListView>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Carregar" Text="Button" />
    </form>
</body>
</html>
