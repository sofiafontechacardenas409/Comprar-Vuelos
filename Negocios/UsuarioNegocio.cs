using Comprar_Vuelos.Datos;
using Comprar_Vuelos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprar_Vuelos.Negocios
{
    public class UsuarioNegocio
    {
        UsuarioDatos datos = new UsuarioDatos();

        public bool Login(string correo, string password)
        {
            return datos.ValidarUsuario(correo, password);
        }

        public bool Registrar(Usuario usuario)
        {
            return datos.RegistrarUsuario(usuario);
        }
    }
}

