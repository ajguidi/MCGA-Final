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


        public static List<Usuario> Mostrar()
        {
            List<Usuario> Lista_usuarios = new List<Usuario>();
            DataTable _consulta = new DataTable();
            try
            {



                string Query = $"select * from usuario  ";


                SqlCommand cmd = new SqlCommand(Query);



                _consulta = Sqlcliente.Mostrar(cmd);




                if (_consulta.Rows.Count > 0)
                {

                    foreach (DataRow ro in _consulta.Rows)
                    {
                        Usuario InformacionUsuario = new Usuario();
                        InformacionUsuario.Idusuario = Convert.ToInt32(ro.ItemArray[0]);
                        InformacionUsuario.Nombre = ro.ItemArray[1].ToString();
                        InformacionUsuario.Apellido = ro.ItemArray[2].ToString();
                        InformacionUsuario.Dni = ro.ItemArray[3].ToString();
                        InformacionUsuario.Cuit = ro.ItemArray[4].ToString();
                        InformacionUsuario.Direccion = ro.ItemArray[5].ToString();
                        InformacionUsuario.Telefono = ro.ItemArray[6].ToString();
                        InformacionUsuario.Clave = ro.ItemArray[7].ToString();

                        Lista_usuarios.Add(InformacionUsuario);

                    }

                 


                }
                return Lista_usuarios;
            }
            catch  
            {
                return Lista_usuarios;

            }
           
        }



        public int Crear(Usuario usu)
        {

            int _consulta = 0;
            try
            {
                Sqlcliente Sql = new Sqlcliente();

                string Query = $"insert into usuario ( nombre, apellido, dni, cuit, direccion, telefono, clave )" +
                                $" values " +
                                $" ( @Nombre, @Apellido, @Dni, @Cuit, @Direccion, @Telefono, @Clave  ) ";


                SqlCommand cmd = new SqlCommand(Query);

       
                cmd.Parameters.AddWithValue("@Nombre", usu.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usu.Apellido);
                cmd.Parameters.AddWithValue("@Dni", usu.Dni);
                cmd.Parameters.AddWithValue("@Cuit", usu.Cuit);
                cmd.Parameters.AddWithValue("@Direccion", usu.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", usu.Telefono);
                cmd.Parameters.AddWithValue("@Clave", usu.Clave);


                _consulta = Sql.Enviar(cmd);

                return _consulta;
            }
            catch (Exception)
            {
                return 0;

            }

        }



        public int Modificar(Usuario usu)
        {

            int _consulta = 0;
            try
            {


                Sqlcliente Sql = new Sqlcliente();

                string Query =  $"update usuario set Nombre =  @Nombre, Apellido = @Apellido, Dni= @Dni,Cuit= @Cuit, " +
                                " Direccion= @Direccion, Telefono= @Telefono, Clave= @Clave  where idusuario = @Idusuario ";

                SqlCommand cmd = new SqlCommand(Query);

                cmd.Parameters.AddWithValue("@Idusuario", usu.Idusuario);
                cmd.Parameters.AddWithValue("@Nombre", usu.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usu.Apellido);
                cmd.Parameters.AddWithValue("@Dni", usu.Dni);
                cmd.Parameters.AddWithValue("@Cuit", usu.Cuit);
                cmd.Parameters.AddWithValue("@Direccion", usu.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", usu.Telefono);
                cmd.Parameters.AddWithValue("@Clave", usu.Clave);

                _consulta = Sql.Enviar(cmd);



                return _consulta;
            }
            catch (Exception)
            {
                return 0;

            }

        }





        public int Borrar(int Idusuario)
        {

            int _consulta = 0;
            try
            {
                Sqlcliente Sql = new Sqlcliente();


                string Query = $" delete from  usuario where Idusuario = @Idusuario   ";



                SqlCommand cmd = new SqlCommand(Query);

                cmd.Parameters.AddWithValue("@Idusuario", Idusuario);



                _consulta = Sql.Enviar(cmd);


                return _consulta;
            }
            catch (Exception)
            {
                return 0;

            }

        }



    }

}
