<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebUI.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Código:<asp:TextBox ID="txbCodigo" runat="server"></asp:TextBox>
            <br />
            Marca:<asp:TextBox ID="txbMarca" runat="server"></asp:TextBox>
            <br />
            Modelo:<asp:TextBox ID="txbModelo" runat="server"></asp:TextBox>
            <br />
            Cor:<asp:TextBox ID="txbCor" runat="server"></asp:TextBox>
            <br />
            Ano de Fabricação:<asp:TextBox ID="txbAnoFabricacao" runat="server"></asp:TextBox>
            <br />
            Placa:<asp:TextBox ID="txbPlaca" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" style="height: 26px" Text="Inserir" />
        </div>
    </form>
</body>
</html>
