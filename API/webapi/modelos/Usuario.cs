using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.modelos
{
    public class Usuario
    {

        public int Idusuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Cuit { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Clave { get; set; }


    }
}
