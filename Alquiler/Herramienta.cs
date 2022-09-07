using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler
{
    public class Herramienta
    {
        public string marca { get; set; }
        public string nroStock { get; set; }
        public bool estado { get; set; } //True sera "alquilado", false sera "devuelto"
        public string tipoHerramienta { get; set; }

        public Herramienta(string marca, string nroStock, bool estado, string tipoHerramienta) {
            this.marca = marca;
            this.nroStock = nroStock;
            this.estado = estado;
            this.tipoHerramienta = tipoHerramienta;
        }
    }
}
