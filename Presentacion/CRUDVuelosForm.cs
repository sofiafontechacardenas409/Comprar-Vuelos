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
    public partial class CRUDVuelosForm : Form
    {
        // Instancia de la capa negocio (asegúrate que el using esté al inicio)
        private VueloNegocio negocio = new VueloNegocio();

        // Al cargar el formulario, muestra los vuelos existentes
        private void CRUDVuelosForm_Load(object sender, EventArgs e)
        {
            CargarVuelos();
        }

        // Botón Cargar Vuelos
        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarVuelos();
        }

        // Método para cargar vuelos en el DataGridView
        private void CargarVuelos()
        {
            dataGridView3.DataSource = null;                   // Aquí va el nuevo nombre
            dataGridView3.DataSource = negocio.Listar();       // Trae la lista de vuelos desde la base de datos
        }

        // Botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vuelo vuelo = new Vuelo
            {
                Origen = txtOrigen.Text,
                Destino = txtDestino.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Fecha = Fecha1.Value,                          // Aquí va el nuevo nombre del DateTimePicker
                AsientosDisponibles = int.Parse(txtAsientos.Text)
            };

            if (negocio.Agregar(vuelo))
            {
                MessageBox.Show("Vuelo agregado correctamente");
                CargarVuelos();
            }
            else
            {
                MessageBox.Show("Error al agregar vuelo");
            }
        }

        // Botón Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int idVuelo = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["IdVuelo"].Value);

                Vuelo vuelo = new Vuelo
                {
                    IdVuelo = idVuelo,
                    Origen = txtOrigen.Text,
                    Destino = txtDestino.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Fecha = Fecha1.Value,                      // Aquí va el nuevo nombre del DateTimePicker
                    AsientosDisponibles = int.Parse(txtAsientos.Text)
                };

                if (negocio.Editar(vuelo))
                {
                    MessageBox.Show("Vuelo editado correctamente");
                    CargarVuelos();
                }
                else
                {
                    MessageBox.Show("Error al editar vuelo");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un vuelo para editar");
            }
        }

        // Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int idVuelo = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["IdVuelo"].Value);

                if (negocio.Eliminar(idVuelo))
                {
                    MessageBox.Show("Vuelo eliminado correctamente");
                    CargarVuelos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar vuelo");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un vuelo para eliminar");
            }
        }

        // Evento cuando haces clic en el DataGridView para cargar los datos en los campos
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtOrigen.Text = dataGridView3.Rows[e.RowIndex].Cells["Origen"].Value.ToString();
                txtDestino.Text = dataGridView3.Rows[e.RowIndex].Cells["Destino"].Value.ToString();
                txtPrecio.Text = dataGridView3.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
                Fecha1.Value = Convert.ToDateTime(dataGridView3.Rows[e.RowIndex].Cells["Fecha"].Value);   // Nuevo nombre del DateTimePicker
                txtAsientos.Text = dataGridView3.Rows[e.RowIndex].Cells["AsientosDisponibles"].Value.ToString();
            }
        }

    }
}
