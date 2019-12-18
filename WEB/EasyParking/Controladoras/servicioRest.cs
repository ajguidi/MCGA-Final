using System;
using System.Collections.Generic;
using System.Text;

namespace EasyParking.Funciones
{
    class servicioRest
    {

        public static string Inicio = "http://lisandroservidor.gt-sistemas.com/";
        public static string MetodoPrincipal = "api/controles/";
        public static string ContentType = "application/json";

        public static class HTTPMethods
        {
            public static string Get = "GET";
            public static string Post = "POST";
            public static string Put_Modify = "PUT";
            public static string Patch_Modify = "PATCH";
            public static string Delete = "DELETE";
        }
        public static class Methods
        {
            public static string UsarioMethod = "usuario/";
         
        }

    }
}
