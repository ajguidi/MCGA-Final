using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EasyParking.Objetos;
using EasyParking.Funciones;

namespace EasyParking.Formularios
{
    public partial class Formulario_Login : System.Web.UI.Page
    {
        Clientes Clin;
        List<Clientes> listita = new List<Clientes>();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            Clin = new Clientes { 
            
                Clave = txtClave.Text,        
                Dni = txtDni.Text,
              
            };
        }

        
 

        protected void Ingresar_Click(object sender, EventArgs e)
        {
            Error_.Visible = false;
            Usuarios usu = new Usuarios();
            usu = Fusuarios.ObtenerUsuario(txtDni.Text, txtClave.Text);

            if (usu.IdUsuario != 0)
            {
                Response.Redirect("Formulario Clientes.aspx");
            }
            else

            {
               
                Error_.Visible = true;
            }
        }


        protected void Limpiar_Click(object sender, EventArgs e)
        {


            txtClave.Text = "";       
            txtDni.Text = "";
        }

        protected void Limpiar_error(object sender, EventArgs e)
        {


            Error_.Visible = false;
        }













    }
}