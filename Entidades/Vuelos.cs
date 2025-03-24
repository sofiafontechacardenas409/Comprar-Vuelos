using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprar_Vuelos
{
    public class Vuelo
    {
        public int IdVuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public decimal Precio { get; set; }
        public DateTime Fecha { get; set; }
        public int AsientosDisponibles { get; set; }
    }

}
