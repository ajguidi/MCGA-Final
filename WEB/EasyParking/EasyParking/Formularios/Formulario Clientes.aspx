<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario Clientes.aspx.cs" Inherits="EasyParking.Formularios.Formulario_Clientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Easy Parking</title>

    <!--===============================================================================================-->
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <!--===============================================================================================-->
</head>


<body class="container bootstrap snippet">
    <form id="FormularioClientes" runat="server">
        <hr />

        <div class="row">
            <asp:Label ID="lbltitulo" CssClass="col-sm-10" runat="server" Text="Administracion de Clientes" Font-Size="XX-Large"></asp:Label>
            <div class="col-sm-2">
                <a href="/users" class="pull-right">
                    <!--aca va el logo de nuestra empresa -->
                    <img title="profile image" class="img-circle img-responsive" src="http://www.gravatar.com/avatar/28fd20ccec6865e2d5f0e1f4446eb7bf?s=100" />
                </a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                <div class="panel panel-default">
                    <div class="panel-heading">MENU </div>
                    <div class="panel-body">
                        <a href="Formulario Clientes.aspx">Clientes</a>
                        <hr />
                        <a href="Formulario Clientes.aspx">Empleados</a>
                        <hr />
                        <a href="Formulario Clientes.aspx">Estacionamientos</a>
                        <hr />
                    </div>

                </div>
            </div>
            .

                <div class="col-sm-9">
                    <ul class="nav nav-tabs">
                        <li class="active"><a data-toggle="tab" href="#registrar">Registrar</a></li>
                        <li><a data-toggle="tab" href="#modificar">Modificar</a></li>
                    </ul>

                    <div class="tab-content">
                        <div class="tab-pane active" id="registrar">
                            <hr />

                            <div class="form-group">
                                <asp:TextBox ID="txtIdUsuario" runat="server" Visible="false" Text="0"></asp:TextBox>
                                <div class="col-xs-6">


                                    <asp:Label ID="lblNombre" runat="server" Text="Nombre" Font-Bold="true"></asp:Label>
                                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Ingrese Nombre"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">

                                <div class="col-xs-6">
                                    <asp:Label ID="lblApellido" runat="server" Text="Apellido" Font-Bold="true"></asp:Label>
                                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="Ingrese Apellido"></asp:TextBox>

                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-xs-6">
                                    <asp:Label ID="lblTelefono" runat="server" Text="Telefono" Font-Bold="true"></asp:Label>
                                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" placeholder="Ingrese Nro Telefono"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">

                                <div class="col-xs-6">
                                    <asp:Label ID="lblDni" runat="server" Text="Dni" Font-Bold="true"></asp:Label>
                                    <asp:TextBox ID="txtDni" runat="server" CssClass="form-control" type="number" placeholder="Ingrese D.N.I"></asp:TextBox>
                                </div>
                            </div>


                            <div class="form-group">

                                <div class="col-xs-6">
                                    <asp:Label ID="lblCuit" runat="server" Text="Cuit" Font-Bold="true"></asp:Label>
                                    <asp:TextBox ID="txtCuit" runat="server" CssClass="form-control" placeholder="Ingrese C.U.I.T"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">

                                <div class="col-xs-6">
                                    <asp:Label ID="lblDireccion" runat="server" Text="Direccion" Font-Bold="true"></asp:Label>
                                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" placeholder="Ingrese Direccion Legal"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">

                                <div class="col-xs-6">

                                    <asp:Label ID="lblClave" runat="server" Text="Clave" Font-Bold="true"></asp:Label>
                                    <asp:TextBox ID="txtClave" runat="server" TextMode="Password" CssClass="form-control" placeholder="Ingrese su clave"   ></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">

                                <div class="col-xs-6">
                                    <asp:Label ID="lblverificar" runat="server" Text="Verificar Clave" Font-Bold="true"></asp:Label>
                                    <asp:TextBox ID="txtClave2" runat="server" TextMode="Password" CssClass="form-control" placeholder="Repita su clave"  ></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-xs-12">
                                    <br />

                                    <asp:LinkButton runat="server" CssClass="btn btn-lg btn-success" Type="submit" OnClick="Guardar_Click"><i class="glyphicon glyphicon-ok-sign"></i> Guardar</asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="btnreset" CssClass="btn btn-lg" Type="submit" OnClick="Limpiar_Click"><i class="glyphicon glyphicon-repeat"></i> Reiniciar</asp:LinkButton>
                                     <asp:Label ID="lblerror_clave" runat="server" Text="Error las Claves no Coinciden" Font-Bold="true" Visible="false" ForeColor="Red" ></asp:Label> 
                                    <asp:Label ID="lblerror_" runat="server"   Text="Error la acción no se pudo realizar" Font-Bold="true" Visible="false" ForeColor="Red"></asp:Label>
                                  

                                </div>
                            </div>

                            <hr />

                        </div>
                        <!--/tab-pane-->
                        <div class="tab-pane" id="modificar">
                            <hr />

                            <div class="form-group">

                                <asp:ListView ID="ListClientes" runat="server" OnItemCommand="cambiar_usuario">

                                    <ItemTemplate>
                                        <tr>
                                            <asp:Label runat="server" ID="lblIdUsuario" Text='<%# Eval("Idusuario") %>' Visible="false"></asp:Label>
                                            <td>
                                                <asp:Label runat="server" ID="lblapellido" Text='<%# Eval("Apellido") %>'></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label runat="server" ID="lblName" Text=' <%#Eval("Nombre") %>'></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label runat="server" ID="lblDni" Text='<%# Eval("Dni") %>'></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label runat="server" ID="Lbltel" Text=' <%#Eval("Telefono") %>'></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label runat="server" ID="lblCui" Text='<%# Eval("Cuit") %>'></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label runat="server" ID="lblDir" Text=' <%#Eval("Direccion") %>'></asp:Label>
                                            </td>
                                            <td>
                                                <asp:LinkButton runat="server" CssClass="btn btn-sm btn-success" Type="submit" CommandName="Editar" CommandArgument='<%#Eval("Idusuario")%>'><i class="glyphicon glyphicon-edit"></i></asp:LinkButton></td>
                                            <td>
                                                <asp:LinkButton runat="server"  CssClass="btn btn-sm btn-warning"  Type="submit"    CommandName="Eliminar" CommandArgument='<%#Eval("Idusuario")%>'    ><i class="glyphicon glyphicon-remove"></i></asp:LinkButton></td>
                                         
                                        </tr>



                                    </ItemTemplate>




                                    <LayoutTemplate>

                                        <table class="table-hover table-bordered table-condensed col-sm-12" border="1">

                                            <tr style="background-color: lightgray">

                                                <td>
                                                    <asp:Label runat="server" ID="Label1" Text="Apellido"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="Label2" Text="Nombre"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="Label3" Text="Dni"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="Label4" Text="Telefono"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="Label5" Text="Cuit"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="Label6" Text="Direccion"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="Label7" Text="Editar"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="Label8" Text="Eliminar"></asp:Label>
                                                </td>

                                            </tr>


                                            <tr>
                                                <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                                            </tr>
                                        </table>


                                    </LayoutTemplate>

                                </asp:ListView>
                            </div>



                            <hr />

                        </div>
                        <!--/tab-pane-->


                    </div>
                    <!--/tab-content-->






                </div>
            <!--/tab-col-9-->
        </div>
        <!--/row-->



        <hr />
        <br />



        <!--Dejo Comentado este para saber como es el email -->
        <!--<input type="email" class="form-control" name="email" id="email" placeholder="you@email.com" title="enter your email."/> 
          -->









    </form>
</body>
</html>
