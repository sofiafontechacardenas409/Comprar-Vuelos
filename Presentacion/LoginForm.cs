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
    public partial class LoginForm : Form
    {
        UsuarioNegocio negocio = new UsuarioNegocio();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string password = txtPassword.Text.Trim();

            bool loginExitoso = negocio.Login(correo, password);

            if (loginExitoso)
            {
                MessageBox.Show("Bienvenido al sistema!");
                PrincipalForm principal = new PrincipalForm();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistroForm registro = new RegistroForm();
            registro.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            
                string correo = txtCorreo.Text.Trim();
                string password = txtPassword.Text.Trim();

                UsuarioNegocio negocio = new UsuarioNegocio();
                bool loginExitoso = negocio.Login(correo, password);

                if (loginExitoso)
                {
                    MessageBox.Show("¡Bienvenido!");
                    PrincipalForm principal = new PrincipalForm();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos");
                }
            

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
           
                RegistroForm registro = new RegistroForm();
                registro.ShowDialog(); // Para que se abra como ventana modal
            

        }
    }
}
