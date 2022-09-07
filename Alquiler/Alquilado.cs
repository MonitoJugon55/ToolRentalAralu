using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler
{
    public class Alquilado
    {
        public string nroContrato { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public Herramienta herramienta { get; set; }
        public DateTime fechaAlquiler { get; set; }
        public int diasAlquilado { get; set; }

        public Alquilado(string nroContrato, string nombre, string apellido, string cedula, Herramienta herramienta, DateTime fechaAlquiler, int diasAlquilado) 
        {
            this.nroContrato = nroContrato;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.herramienta = herramienta;
            this.fechaAlquiler = fechaAlquiler;
            this.diasAlquilado = diasAlquilado;
        }
    }
}
