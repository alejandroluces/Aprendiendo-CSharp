using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprendiendo_CSharp
{
    public class AvisosTrafico : IAvisos
    {
        //CONSTRUCTORES

        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje = "MULTA DE 100€ POR EXCESO DE VELOCIDAD";
            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
        public string getFecha()
        {
            return fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine("Mensaje: {0} \nRemitente: {1} \nFecha: {2}", mensaje, remitente, fecha);
        }

        //AVISOS// CAMPOS DE LA CLASE
        private string remitente;
        private string mensaje;
        private string fecha;

    }
}