<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="livro.aspx.cs" Inherits="CrudLivro.livro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>pw2016-12 - Mario Apra</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
</head>
<body>
    <form id="formLivro" runat="server">
    <div class="container">
    <h1>Livro</h1>

        <div class="form-group">
        <label>Código</label>
            <div class="input-group">            
                <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control"></asp:TextBox>
                <span class="input-group-btn">
                    <asp:Button ID="btnRead" runat="server" Text="Read" CssClass="btn btn-default" OnClick="Read" />
                </span>
            </div>
        </div>

        <div class="form-group">
            <label>Titulo</label>
            <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>


        <div class="form-group">
            <label>Autor</label>
            <asp:TextBox ID="txtAutor" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label>Quantitade</label>
            <asp:TextBox ID="txtQtde" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
        </div>

        <div class="form-group">
            <label>Valor</label>
            <asp:TextBox ID="txtValor" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label>Paginas</label>
            <asp:TextBox ID="txtPaginas" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
        </div>

        <div class="form-group">
            <label>Resumo</label>
            <asp:TextBox ID="txtResumo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <asp:Button ID="btnCreate" runat="server" Text="Create"  CssClass="btn btn-success" OnClick="Create" CausesValidation="False" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update"  CssClass="btn btn-info" OnClick="Update" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete"  CssClass="btn btn-danger" OnClick="Delete" />
        <asp:Button ID="btnLimpar" runat="server" Text="Limpar"  CssClass="btn btn-default" OnClick="clean" />
        <br />
        <asp:Label ID="lblMensagem" runat="server" Text="" CssClass="label label-warning"></asp:Label>

    </div>
    </form>
    <script>
        $("#<%=btnCreate.ClientID%>").click(function () {
            $("#<%=lblMensagem.ClientID%>").show();
            $("#<%=lblMensagem.ClientID%>").hide(10000);
        });
    </script>
</body>
</html>
