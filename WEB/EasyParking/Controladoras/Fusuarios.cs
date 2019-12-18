using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using EasyParking.Objetos;
using Newtonsoft.Json;

namespace EasyParking.Funciones
{
    public static class Fusuarios
    {
      

        public static Usuarios ObtenerUsuario(string dni, string contra)
        {
            try
            {


                HttpWebRequest request = WebRequest.Create(servicioRest.Inicio + servicioRest.MetodoPrincipal +  servicioRest.Methods.UsarioMethod + dni + "," + contra ) as HttpWebRequest;
                request.Method = servicioRest.HTTPMethods.Get;
                request.ContentType = servicioRest.ContentType;

                HttpWebResponse response =   request.GetResponse() as HttpWebResponse;
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {


                    string resp = reader.ReadToEnd();

                    //la funcion de convetir el objeto en string no funciona a la hora de probarlo en xamarin live por ende lo pruebo de esta forma
                    //este es el oficial
                    Usuarios usu = new Usuarios();
                    usu = JsonConvert.DeserializeObject<Usuarios>(resp);


                     
                    return usu;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }



        


    }
}