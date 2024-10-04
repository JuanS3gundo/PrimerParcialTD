using DAL.Contracts;
using DAL.Implementations.Memory;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.SQLServer
{
    public class MisionSqlServer : IMision
    {
        private static MisionSqlServer _current;
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString;

        
        public static MisionSqlServer Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new MisionSqlServer();
                }
                return _current;
            }
        }

        
        public void GuardarMision(Mision mision)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Misiones (FechaHora, ValorSensor1, ValorSensor2) VALUES (@FechaHora, @ValorSensor1, @ValorSensor2)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FechaHora", mision.FechaHora);
                command.Parameters.AddWithValue("@ValorSensor1", mision.ValorSensor1);
                command.Parameters.AddWithValue("@ValorSensor2", mision.ValorSensor2);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        
        public List<Mision> ObtenerMisiones(DateTime fechaDesde, DateTime fechaHasta)
        {
            var misiones = new List<Mision>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT FechaHora, ValorSensor1, ValorSensor2 FROM Misiones WHERE FechaHora BETWEEN @FechaDesde AND @FechaHasta";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                command.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var mision = new Mision(
                            reader.GetDateTime(0),
                            reader.GetBoolean(1),
                            reader.GetBoolean(2)
                        );
                        misiones.Add(mision);
                    }
                }
            }

            return misiones;
        }

        public List<Mision> ObtenerTodasLasMisiones()
        {
            throw new NotImplementedException();
        }
    }
}
