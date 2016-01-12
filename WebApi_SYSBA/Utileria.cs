using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace WebApi_SYSBA
{
    /// <summary>
    /// Clase para utilizar funciones generales
    /// </summary>
    public static class Utileria
    {

        /// <summary>
        /// Se registra en un archivo de text los errores
        /// </summary>
        /// <param name="exp"></param>
        /// <param name="funcion"></param>
        public static void RegistraLog(Exception exp, string funcion)
        {
            string rutaLog = "";
            try
            {
                string mensaje = exp.Message;
                mensaje = exp.InnerException != null ? exp.InnerException.Message + mensaje : mensaje;

                rutaLog = ConfigurationManager.AppSettings["archivosLog"].ToString();

                System.IO.File.AppendAllLines(rutaLog, 
                        new[] { string.Format(" {0} : {1} : {2} \n ", 
                                            DateTime.Now.ToString(), 
                                            funcion, 
                                            exp.Message) });
            }
            catch (Exception) { }
        }
    }
}