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



      

    }
}