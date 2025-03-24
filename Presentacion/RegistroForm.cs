using Comprar_Vuelos.Entidades;
using Comprar_Vuelos.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprar_Vuelos.Presentacion
{
    public partial class RegistroForm : Form
    {
        UsuarioNegocio negocio = new UsuarioNegocio();

        public RegistroForm()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                Nombre = txtNombre.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            bool registrado = negocio.Registrar(usuario);

            if (registrado)
            {
                MessageBox.Show("Usuario registrado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar usuario");
            }
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" || txtCorreo.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            Usuario usuario = new Usuario
            {
                Nombre = txtNombre.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            UsuarioNegocio negocio = new UsuarioNegocio();

            bool registrado = negocio.Registrar(usuario);

            if (registrado)
            {
                MessageBox.Show("Usuario registrado correctamente.");
                this.Close(); // O limpia los campos si no quieres cerrar
            }
            else
            {
                MessageBox.Show("Error al registrar usuario. El correo podría ya estar en uso.");
            }
        }

        
    }
}
