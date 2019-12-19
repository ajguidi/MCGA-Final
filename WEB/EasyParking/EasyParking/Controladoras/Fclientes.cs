using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using EasyParking.Objetos;
using Newtonsoft.Json;

namespace EasyParking.Funciones
{
    public static class Fclientes
    {
      

       
        public static List<Clientes> Mostrar()
        {
            List<Clientes> listaCliente = new List<Clientes>();

            try
            {


                HttpWebRequest request = WebRequest.Create(servicioRest.Inicio + servicioRest.MetodoPrincipal + servicioRest.Methods.UsarioMethod) as HttpWebRequest;
                request.Method = servicioRest.HTTPMethods.Get;
                request.ContentType = servicioRest.ContentType;

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {


                    string resp = reader.ReadToEnd();

                    //la funcion de convetir el objeto en string no funciona a la hora de probarlo en xamarin live por ende lo pruebo de esta forma
                    //este es el oficial

                    listaCliente = JsonConvert.DeserializeObject<List<Clientes>>(resp);


                    
                    return listaCliente;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }



        public static string Crear_Modificar(Clientes cli)
        {

            try
            {

                string str = JsonConvert.SerializeObject(cli);


                System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                byte[] arr = encoding.GetBytes(str);

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(servicioRest.Inicio + servicioRest.MetodoPrincipal + servicioRest.Methods.UsarioMethod);
                if (cli.IdUsuario == 0)
                {
                    request.Method = servicioRest.HTTPMethods.Post;
                }
                else
                {
                    request.Method = servicioRest.HTTPMethods.Put_Modify;
                };
                request.ContentType = servicioRest.ContentType;
                request.ContentLength = arr.Length;
                request.KeepAlive = true;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(arr, 0, arr.Length);
                dataStream.Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string returnString = response.StatusCode.ToString();
                return returnString;

            }
            catch (Exception ex)
            {
                return ex.Message;

            }

        }


        public static string Eliminar(int id)
        {

            try
            {

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(servicioRest.Inicio + servicioRest.MetodoPrincipal + servicioRest.Methods.UsarioMethod + id);
                request.Method = servicioRest.HTTPMethods.Delete;
                request.ContentType = servicioRest.ContentType;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string returnString = response.StatusCode.ToString();
                return returnString;

            }
            catch (Exception ex)
            {
                return ex.Message;

            }

        }


    }
}