using System;
using System.Collections.Generic;
using System.Linq;
 
using System.Data.SqlClient;
using System.Data;
 

namespace WebApi.controles
{
    public class Sqlcliente
    {

       


        public static SqlConnection ConexionSQL()
        {
            SqlConnection  coneccion = new SqlConnection(@"Data Source=(local);Initial Catalog=MCGA; user id=octilc; password=1214lcm");

            return coneccion;


        }


        public  static DataTable Mostrar(SqlCommand cmd)
        {
            DataTable consulta = new DataTable();
            SqlConnection con = new SqlConnection();
            con = ConexionSQL();
            cmd.Connection = con;

            try
                {
                    if (con.State == ConnectionState.Open )
                    {
                        con.Close();
                    }
                    else
                       {
                        con.Open();
                        }
                    consulta.Load(cmd.ExecuteReader());
                }
                catch (Exception ex)
                {
                    throw ex;

                }
                finally
                {
                    con.Close();
                }
            
            return consulta;

        }


   


        public int Enviar(SqlCommand cmd)
        {

            SqlConnection con = new SqlConnection();
            con = ConexionSQL();
            cmd.Connection = con;

            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                else
                {
                    con.Open();
                }
                int resp = cmd.ExecuteNonQuery();

                if (resp > 0)
                {
                    return resp;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
