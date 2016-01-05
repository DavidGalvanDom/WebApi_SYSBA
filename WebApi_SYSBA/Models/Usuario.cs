using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApi_SYSBA.Models
{
    /// <summary>
    /// Usuario
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Identificador del usuario
        /// </summary>
        [Required]
        public int UsuarioId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Nombre { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Contrasena { get; set; }
    }
}