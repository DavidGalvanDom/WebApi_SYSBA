using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApi_SYSBA.Models
{
    public class Usuario
    {
        public int usuarioId { get; set; }

        public string nombre { get; set; }

        public string contrasena { get; set; }
    }
}