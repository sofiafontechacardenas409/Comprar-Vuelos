using Comprar_Vuelos.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprar_Vuelos.Negocios
{
    public class VueloNegocio
    {
        private VueloDatos datos = new VueloDatos();

        public List<Vuelo> Listar() => datos.Listar();
        public bool Agregar(Vuelo vuelo) => datos.Agregar(vuelo);
        public bool Editar(Vuelo vuelo) => datos.Editar(vuelo);
        public bool Eliminar(int idVuelo) => datos.Eliminar(idVuelo);
    }

}
