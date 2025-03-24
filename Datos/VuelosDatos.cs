using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprar_Vuelos.Datos
{
    public class VueloDatos
    {
        public List<Vuelo> Listar()
        {
            List<Vuelo> lista = new List<Vuelo>();

            using (SqlConnection cn = Conexion.ObtenerConexion()) 
            {
                string query = "SELECT * FROM Vuelos";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Vuelo
                    {
                        IdVuelo = Convert.ToInt32(dr["IdVuelo"]),
                        Origen = dr["Origen"].ToString(),
                        Destino = dr["Destino"].ToString(),
                        Precio = Convert.ToDecimal(dr["Precio"]),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        AsientosDisponibles = Convert.ToInt32(dr["AsientosDisponibles"])
                    });
                }
            }

            return lista;
        }

        public bool Agregar(Vuelo vuelo)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion()) 
            {
                string query = "INSERT INTO Vuelos (Origen, Destino, Precio, Fecha, AsientosDisponibles) " +
                               "VALUES (@Origen, @Destino, @Precio, @Fecha, @AsientosDisponibles)";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Origen", vuelo.Origen);
                cmd.Parameters.AddWithValue("@Destino", vuelo.Destino);
                cmd.Parameters.AddWithValue("@Precio", vuelo.Precio);
                cmd.Parameters.AddWithValue("@Fecha", vuelo.Fecha);
                cmd.Parameters.AddWithValue("@AsientosDisponibles", vuelo.AsientosDisponibles);

                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Editar(Vuelo vuelo)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion()) 
            {
                string query = "UPDATE Vuelos SET Origen = @Origen, Destino = @Destino, Precio = @Precio, Fecha = @Fecha, AsientosDisponibles = @AsientosDisponibles " +
                               "WHERE IdVuelo = @IdVuelo";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@IdVuelo", vuelo.IdVuelo);
                cmd.Parameters.AddWithValue("@Origen", vuelo.Origen);
                cmd.Parameters.AddWithValue("@Destino", vuelo.Destino);
                cmd.Parameters.AddWithValue("@Precio", vuelo.Precio);
                cmd.Parameters.AddWithValue("@Fecha", vuelo.Fecha);
                cmd.Parameters.AddWithValue("@AsientosDisponibles", vuelo.AsientosDisponibles);

                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(int idVuelo)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion()) 
            {
                string query = "DELETE FROM Vuelos WHERE IdVuelo = @IdVuelo";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@IdVuelo", idVuelo);

                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }


}
