using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_SYSBA.Controllers
{
    public class UsuarioController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: api/Usuario
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Usuario/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok("Value");
            }
            catch(Exception exp)
            {
                return InternalServerError();
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        // POST: api/Usuario
        [HttpPost]
        public void Post([FromBody]Models.Usuario value)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT: api/Usuario/5
        [HttpPut]
        public void Put(int id, [FromBody]Models.Usuario value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        // DELETE: api/Usuario/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
