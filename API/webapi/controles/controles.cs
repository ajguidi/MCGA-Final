using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApi.modelos;
using WebApi.funciones;
using System.Net.Http;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.controles
{
    [Route("api/[controller]")]
    public class controles : Controller
    {




        // GET api/<controller>/5

        [HttpGet("usuario/{dni},{contra}")]
        public string Get(string dni, string contra)
        {
            Usuario InformacionUsuario = new Usuario();
            try
            {
                InformacionUsuario = Fusuarios.Buscar(dni, contra);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            var jsonconver = JsonConvert.SerializeObject(InformacionUsuario);
            return jsonconver.ToString();

        }

       



    }// Fin de la clase.

}

   
 
