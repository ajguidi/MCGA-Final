using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyParking.Objetos
{
    public class Clientes : Empleados
    {
        public string Telefono { get; set; }
        public string Cuit { get; set; }
        public string Direccion { get; set; }

    }
}