using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AccesoDatosTexto1
{
    public class ArchivoTexto
    {
        public string Carpeta { get; set; } = AccesoDatosTexto1.Properties.Resources.CarpetaArchivos;

        public void GuardarContenido (string archivo, string contenido)
        {
            string fileName = Path.Combine(Carpeta, archivo);
            if (!File.Exists(fileName))
            {
                var fi = new FileInfo(fileName).Create();
                fi.Close();
            }

            File.WriteAllText(fileName, contenido);
        }

        public string leerContenido(string archivo)
        {
            string FileName = Path.Combine(Carpeta, archivo);
            if (!File.Exists(FileName)) return "";
            return File.ReadAllText(FileName);
        }


    }

    public class ArchivoTextoLog: ArchivoTexto
    {
        public string NombreArchivo { get; set; } = "Log.txt";

        public void GuardarLog(string mensaje)
        {
            string contenido = leerContenido(NombreArchivo);
            contenido += $"{ DateTime.Now} - { mensaje}\r\n";
            GuardarContenido(NombreArchivo, contenido);
        }
    }
}
