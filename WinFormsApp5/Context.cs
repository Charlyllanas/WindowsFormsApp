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
            public int? type { get; set; }
        }


        private string connectionString = @"server=CHARLY-PC\SQLEXPRESS; database=TecSanPedroDB; integrated security=true; TrustServerCertificate=True;";

        private SqlConnection GetSqlConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }

        public validResult Login(string matricula, string password)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Usuarios WHERE matricula = @matricula AND password = @password";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@matricula", matricula);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();
                var validresulQuery = new validResult();


                if (reader.Read())
                {
                    // Los datos de inicio de sesión son válidos, puedes acceder a los campos del registro
                    string nombre = reader["nombre"].ToString();
                    string type = reader["tipo"].ToString();
                    validresulQuery.valid = true;
                    validresulQuery.type = int.Parse(type);
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

        public async Task<bool> SolicitudExcelenciaAsync(string matricula, string correo, int promedio, int tipo)
        {
            try
            {
               
                    using (SqlConnection connection = GetSqlConnection())
                    {
                    await connection.OpenAsync();

                    string query = "INSERT INTO [TecSanPedroDB].[dbo].[SolicitudBecas] (correo, promedio, matricula, tipo, status) VALUES (@correo, @promedio, @matricula, @tipo, 'Revision')";
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@correo", correo);
                        command.Parameters.AddWithValue("@promedio", promedio);
                        command.Parameters.AddWithValue("@matricula", matricula);
                        command.Parameters.AddWithValue("@tipo", tipo);

                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            // Registro exitoso
                            MessageBox.Show("Registro realizado correctamente");
                            return true;
                        }
                        else
                        {
                            // Error en el registro
                            MessageBox.Show("Error al realizar el registro");
                            return false;
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el registro: " + ex.Message);
                return false;
            }
        }
        public async Task<bool> solicitudBecaDeportivaAsync(string matricula, string correo, int promedio, int tipo, string club)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                await connection.OpenAsync();

                string query = "INSERT INTO [TecSanPedroDB].[dbo].[SolicitudBecas] (correo, promedio, matricula, tipo, club, status) VALUES (@correo, @promedio, @matricula, @tipo, @club,'Revision')";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@promedio", promedio);
                command.Parameters.AddWithValue("@matricula", matricula);
                command.Parameters.AddWithValue("@tipo", tipo);
                command.Parameters.AddWithValue("@club", club);

                int rowsAffected = await command.ExecuteNonQueryAsync();

                if (rowsAffected > 0)
                {
                    // Registro exitoso
                    MessageBox.Show("Registro realizado correctamente");
                    return true;
                }
                else
                {
                    // Error en el registro
                    MessageBox.Show("Error al realizar el registro");
                    return false;
                }
            }
        }

        public async Task<bool> SolicitudBecaAyudaAsync(string matricula, string correo, int promedio, int tipo, int ingreso)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                await connection.OpenAsync();

                string query = "INSERT INTO [TecSanPedroDB].[dbo].[SolicitudBecas] (correo, promedio, matricula, tipo, ingreso, status) VALUES (@correo, @promedio, @matricula, @tipo, @ingreso,'Revision')";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@promedio", promedio);
                command.Parameters.AddWithValue("@matricula", matricula);
                command.Parameters.AddWithValue("@tipo", tipo);
                command.Parameters.AddWithValue("@ingreso", ingreso);

                int rowsAffected = await command.ExecuteNonQueryAsync();

                if (rowsAffected > 0)
                {
                    // Registro exitoso
                    MessageBox.Show("Registro realizado correctamente");
                    return true;
                }
                else
                {
                    // Error en el registro
                    MessageBox.Show("Error al realizar el registro");
                    return false;
                }
            }
        }

        public async Task<int> ExisteBecaAsync(string matricula)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                await connection.OpenAsync();

                string query = "SELECT COUNT(*) FROM [TecSanPedroDB].[dbo].[SolicitudBecas] WHERE matricula = @matricula";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@matricula", matricula);

                var count = await command.ExecuteScalarAsync();

                return Convert.ToInt32(count);
            }
        }
    }

}
