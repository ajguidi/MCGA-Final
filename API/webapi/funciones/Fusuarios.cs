using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.modelos;
using System.Data;
using WebApi.controles;
using System.Data.SqlClient;

namespace WebApi.funciones
{
    public class Fusuarios
    {


        public static Usuario Buscar(string dni, string contra)
        {
            Usuario InformacionUsuario = new Usuario();
            DataTable _consulta = new DataTable();
            try
            {

            

                string Query = $"select * from usuario where dni = '{dni}' and clave = '{contra}' ";


                SqlCommand cmd = new SqlCommand(Query);

             

                _consulta = Sqlcliente.Mostrar(cmd);




                if (_consulta.Rows.Count > 0)
                {

                    var primero_enla_fila = _consulta.Select().FirstOrDefault();

                    InformacionUsuario.Idusuario = Convert.ToInt32(primero_enla_fila.ItemArray[0]);
                    InformacionUsuario.Nombre = primero_enla_fila.ItemArray[1].ToString();
                    InformacionUsuario.Apellido = primero_enla_fila.ItemArray[2].ToString();
                    InformacionUsuario.Dni = primero_enla_fila.ItemArray[3].ToString();
                    InformacionUsuario.Cuit = primero_enla_fila.ItemArray[4].ToString();
                    InformacionUsuario.Direccion = primero_enla_fila.ItemArray[5].ToString();
                    InformacionUsuario.Telefono = primero_enla_fila.ItemArray[6].ToString();
                    InformacionUsuario.Clave = primero_enla_fila.ItemArray[7].ToString();


                }
                else
                {
                    InformacionUsuario.Idusuario = 0;
                    InformacionUsuario.Nombre = "no encontro a nadie";

                }
            }
            catch (Exception ex)
            {
                InformacionUsuario.Idusuario = 0;
                InformacionUsuario.Nombre = ex.Message;

            }
            return InformacionUsuario;
        }





  



    }

}
