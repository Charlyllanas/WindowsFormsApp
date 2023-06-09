using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WinFormsApp5.Models;

namespace WinFormsApp5.Entity
{
    public class Context
    {
        public class validResult
        {
            public bool valid { get; set; }
            public long? type { get; set; }
        }


        private string connectionString = @"server=CHARLY-PC\SQLEXPRESS; database=TecSanPedroDB; integrated security=true; TrustServerCertificate=True;";

        private SqlConnection GetSqlConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }

        public validResult Login(string matricula, string password, var validresulQuery)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Usuarios WHERE matricula = @matricula AND password = @password";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@matricula", matricula);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();
                var validresulQuery = new { valid = false, type = (long?)null };


                if (reader.Read())
                {
                    // Los datos de inicio de sesión son válidos, puedes acceder a los campos del registro
                    string nombre = reader["nombre"].ToString();
                    string type = reader["tipo"].ToString();
                    validresulQuery.valid = true;
                    validresulQuery.type = long.Parse(type);
                    MessageBox.Show($"Inicio de sesión exitoso. Bienvenido, {nombre} ");
                    return  validresulQuery;
                }
                else
                {
                    // El inicio de sesión falló, el usuario o la contraseña son incorrectos
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    return validresulQuery;
                }

            }
            
        }
    }

}
