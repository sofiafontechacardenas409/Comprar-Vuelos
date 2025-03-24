using Comprar_Vuelos.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprar_Vuelos
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
            Viajes();
        }

        private void Viajes()
        {
            List<string> list = new List<string> { "Europa", "Cartagena", "San Andres", "Grecia", "Barranquilla", "California", "Barcelona" };

            foreach (string viaje in list)
            {
                cboPuntoPartida.Items.Add(viaje);
            }

            foreach (string viaje in list)
            {
                cboDestino.Items.Add(viaje);
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            string PuntoPartida = cboPuntoPartida.SelectedItem.ToString();
            string Destino = cboDestino.SelectedItem.ToString();
            DateTime FechaVuelos = DateTime.Now;
            var NumericUpDownAsientos = new NumericUpDown();

            int AsientosDisponibles = Convert.ToInt32(NumericUpDownAsientos.Value);



            MostrarReserva(PuntoPartida, Destino, FechaVuelos, AsientosDisponibles);
        }

        private void MostrarReserva(string PuntoPartida, string Destino, DateTime FechaVuelos, int AsientosDisponibles)
        {
            MessageBox.Show($"Se ha reservado su vuelo\n" +
                 $"El punto de partida es: {PuntoPartida}\n" +
                 $"El destino es: {Destino}\n" +
                 $"La fecha es: {FechaVuelos}\n" +
                 $"Asientos disponibles: {AsientosDisponibles:N0}");

        }

        private void btnCRUDVuelos_Click(object sender, EventArgs e)
        {
            CRUDVuelosForm crudVuelos = new CRUDVuelosForm();
            crudVuelos.ShowDialog();
        }
    }
    
}

