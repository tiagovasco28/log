using System;
using System.Threading;

namespace AccesoDatosTexto1
{
    class Program
    {
        static void Main(string[] args)
        {

            //instancia de la clase archivotextolog
            ArchivoTextoLog textolog = new ArchivoTextoLog();


            // llamar la función guardar log de inicio
            textolog.GuardarLog("Iniciando sesión");

            //espera  5ms
            Thread.Sleep(5);

            // llamar la función guardar log de cierre de session
            textolog.GuardarLog("Cerrando sesión");
            
        }
    }
}
