using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_SYSBA.Controllers
{
    /// <summary>
    /// Controlador del web api para el catalogo de Usuarios
    /// </summary>    
    [RoutePrefix("api/v{version}")]
    public class UsuarioController : ApiController
    {
        /// <summary>
        /// Lista de todos los usuarios
        /// </summary>
        /// <returns></returns>
        // GET: api/v1/Usuario
        [HttpGet]
        [Route ("Usuario")]
        public IHttpActionResult Lista(string version)
        {
            try
            {
                switch (version)
                {
                    case "1":
                        return Ok(new string[] { version + "-value1", version + "-value2" });
                    default:
                        return BadRequest();
                }

            }
            catch(Exception exp)
            {
                Utileria.RegistraLog(exp, "Detalle");
                return InternalServerError();
            }
                       
        }

        /// <summary>
        /// Solo el detalle del usuario con el id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Usuario/5
        [Route("Usuario/{id}")]
        [HttpGet]
        public IHttpActionResult Detalle(int id)
        {
            try
            {
                return Ok("Value");
            }
            catch(Exception exp)
            {
                Utileria.RegistraLog(exp, "Detalle");
                return InternalServerError();
            }
            
        }

        /// <summary>
        /// Nuevo Usuario
        /// </summary>
        /// <param name="value"></param>
        // POST: api/Usuario
        [HttpPost]
        public IHttpActionResult Crear([FromBody]Models.Usuario value)
        {
            if(ModelState.IsValid)
            {

                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }


        /// <summary>
        /// Modificar los datos de un usuario existente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT: api/Usuario/5
        [HttpPut]
        public IHttpActionResult Actualizar(int id, [FromBody]Models.Usuario value)
        {
            if (ModelState.IsValid)
            {
                return Ok();

            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        // DELETE: api/Usuario/5
        [HttpDelete]
        public void Borrar(int id)
        {

        }
    }
}
