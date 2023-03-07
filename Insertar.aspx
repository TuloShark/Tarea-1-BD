<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insertar.aspx.cs" Inherits="prueba_de_ASP.NET.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2" style="font-size: x-large; font-weight: bold; font-family: Arial, Helvetica, sans-serif">Insertar Articulos</td>
                    
                    
                </tr>
                <tr>
                    <td class="modal-sm" style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; width: 384px;">&nbsp;Nombre</td>
                    <td>
                        <br />
                            <asp:TextBox ID="tbNombre" runat="server" Width="398px" Height="27px"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="modal-sm" style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; width: 384px;">&nbsp;Precio</td>
                <td>
                    <br />
                        <asp:TextBox ID="tbPrecio" runat="server" Width="400px" Height="26px"></asp:TextBox>
                    <br />
                    <br />
                </td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 384px">&nbsp;</td>
                    <td>
                    &nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Height="39px" Text="Cancelar" Width="76px" OnClick="btnCancelar_Click" style="margin-left: 29" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnAgregar" runat="server" Height="39px" Text="Agregar" Width="76px" OnClick="btnAgregar_Click" style="margin-left: 14"/>
                </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
