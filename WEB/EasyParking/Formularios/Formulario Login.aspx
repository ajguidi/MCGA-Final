<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario Login.aspx.cs" Inherits="EasyParking.Formularios.Formulario_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Easy Parking</title>

<!--===============================================================================================-->
<meta name="viewport" content="width=device-width, initial-scale=1" />
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
</head>


<body  class="container bootstrap snippet"  >
    <form id="FormularioClientes" runat="server"  >
         <hr/>
         
            <div class="row">
        <asp:Label ID="lbltitulo" CssClass="col-sm-10" runat="server" Text="Bienvenido a Easy Parking" Font-Size="XX-Large"></asp:Label>
                <div class="col-sm-2"><a href="/users" class="pull-right">
                   <!--aca va el logo de nuestra empresa -->
                    <img title="profile image" class="img-circle img-responsive" src="http://www.gravatar.com/avatar/28fd20ccec6865e2d5f0e1f4446eb7bf?s=100" />
                     </a></div>
                </div>
            <div class="row">
               <%--<div class="col-sm-3">
                    <div class="panel panel-default">
                        <div class="panel-heading"> MENU </div>
                        <div class="panel-body">
                            <a href="Formulario Clientes.aspx">Clientes</a>  <hr/> 
                           <a href="Formulario Clientes.aspx">Empleados</a>  <hr/> 
                          <a href="Formulario Clientes.aspx">Estacionamientos</a> <hr/>  
                      </div>

                    </div>
                </div>
.--%>

                <div class="col-sm-9"  >
                    <ul class="nav nav-tabs">
                        <li class="active"><a data-toggle="tab" href="#ingresar">Ingresar</a></li>
                        
                    </ul>

                    <div class="tab-content">
                        <div class="tab-pane active " id="ingresar"  >
                             <hr />
                            
                                <div class="form-group">

                                    <div class="col-xs-6" >
                                             <asp:Label ID="lblDni" runat="server" Text="Dni" Font-Bold="true"  ></asp:Label>
                                            <asp:TextBox ID="txtDni" runat="server" CssClass="form-control"  placeholder="Ingrese D.N.I" type="number" ></asp:TextBox>                         
                            <br />
                                       <asp:Label ID="lblClave" runat="server" Text="Clave"  Font-Bold="true"  ></asp:Label>
                                        <asp:TextBox ID="txtClave" runat="server" TextMode="Password" CssClass="form-control"  placeholder="Ingrese su clave"   OnTextChanged="Limpiar_error"  AutoPostBack="true" ></asp:TextBox>
                                    </div>
                                     
                                </div>

                                <div class="form-group">
                                    <div class="col-xs-12">
                                        <br />
                             
                                        <asp:Linkbutton runat="server" CssClass="btn btn-lg btn-success" Type="submit"   OnClick="Ingresar_Click"  ><i class="glyphicon glyphicon-ok-sign"></i> Ingresar</asp:Linkbutton>
                                         <asp:Linkbutton runat="server" ID="btnreset" CssClass="btn btn-lg" Type="submit"   OnClick="Limpiar_Click"  ><i class="glyphicon glyphicon-repeat"></i> Limpiar</asp:Linkbutton>
                                        <asp:Label ID="Error_" runat="server" Text="El Dni o la Clave es incorrecta"  Font-Bold="true" Visible="false" ForeColor="Red" ></asp:Label>
                                     
                               
                                    </div>
                                </div>
                           
                         
                        </div><!--/tab-pane-->
                  

                    </div><!--/tab-content-->
                      
                   
                     
                  

                   
                </div><!--/tab-col-9-->
            </div><!--/row-->



        <hr />
        <br />

       
      
        <!--Dejo Comentado este para saber como es el email -->
         <!--<input type="email" class="form-control" name="email" id="email" placeholder="you@email.com" title="enter your email."/> 
          -->
                                     
     
        
     
     
      

    

    </form>
</body>
</html>
