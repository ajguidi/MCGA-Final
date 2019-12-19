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

       

        [HttpGet("usuario/")]
        public string Get3()
        {
            List<Usuario> InformacionUsuario = new List<Usuario>();
            try
            {
                InformacionUsuario = Fusuarios.Mostrar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            var jsonconver = JsonConvert.SerializeObject(InformacionUsuario);
            return jsonconver.ToString();

        }



        // POST api/<controller>
        [HttpPost("usuario/")]
        public int Post2([FromBody]Usuario usu)
        {


            Fusuarios insertar = new Fusuarios();
            int resultado = insertar.Crear(usu);

            return resultado;

        }







        [HttpPut("usuario/")]
        public decimal Put2([FromBody] Usuario usu)
        {

            Fusuarios mod = new Fusuarios();
            decimal resultado = mod.Modificar(usu);

            return resultado; // Se agrega la base de datos.

        }// Fin del método.




        // DELETE api/<controller>/5
        [HttpDelete("usuario/{Idusuario}")]
        public int Delete2(int Idusuario)
        {
            Fusuarios Eliminar = new Fusuarios();
            int resultado = Eliminar.Borrar(Idusuario);

            return resultado;

        }




    }// Fin de la clase.

}

   
 
