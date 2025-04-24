using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDesarrolladorNet.Model
{
    internal class Product
    {
        public int id { get; set; }

        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion {  get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

    }
}
