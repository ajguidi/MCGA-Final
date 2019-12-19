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
    public partial class Formulario_Clientes : System.Web.UI.Page
    {
        Clientes Clin;
        List<Clientes> listita = new List<Clientes>();

        protected void Page_Load(object sender, EventArgs e)
        {
             
            traer_listado_Clientes();

            Clin = new Clientes { 
            Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Clave = txtClave.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Cuit = txtCuit.Text,
                Dni = txtDni.Text,
                IdUsuario = Convert.ToInt32(txtIdUsuario.Text)
            };
        }

        private void cargar_datos(Clientes cli)
        {
            txtIdUsuario.Text = Convert.ToString(cli.IdUsuario);
            txtNombre.Text = cli.Nombre;
            txtApellido.Text = cli.Apellido;
            txtClave.Text = cli.Clave;
            txtClave2.Text = cli.Clave;
            txtTelefono.Text = cli.Telefono;
            txtDireccion.Text = cli.Direccion;
            txtCuit.Text = cli.Cuit;
            txtDni.Text = cli.Dni;
        }

      

        protected void Guardar_Click(object sender, EventArgs e)
        {
            //funcion para guardar
        }


        protected void Limpiar_Click(object sender, EventArgs e)
        {
            lblerror_clave.Visible = false;
            lblerror_.Visible = false;
            Clientes cli = new Clientes() { IdUsuario = 0};
            cargar_datos(cli);
        }

        


      



      

        private void traer_listado_Clientes()
        {
   
  
            listita = Fclientes.Mostrar();

            ListClientes.DataSource = listita.ToList();
            ListClientes.DataBind();
        }

       
    }
}