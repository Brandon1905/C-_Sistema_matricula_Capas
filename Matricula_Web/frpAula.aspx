<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frpAula.aspx.cs" Inherits="Matricula_Web.frpAula" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 201px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Descripcion</td>
                    <td>
                        <asp:TextBox ID="txtAula_descripcion" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlAula" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Capacidad</td>
                    <td>
                        <asp:TextBox ID="txtAula_capacidad" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnCargarDatos" runat="server" OnClick="btnCargarDatos_Click" Text="CARGAR DATO" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="INSERTAR" />
                    </td>
                    <td>
                        <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="MODIFICAR" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="gvAula" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
