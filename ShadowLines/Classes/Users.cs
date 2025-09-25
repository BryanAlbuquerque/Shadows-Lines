using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace ShadowLines.Classes
{
    internal class Users
    {
        public static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public string UserName { get; set; }
        public int Password { get; set; }

        public Users(string userName, int password)
        {
            UserName = userName;
            Password = password;
        }

        public int AuthenticateUser(string username, int password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
                  @"SELECT Nivel_Acesso
                  FROM Funcionarios 
                  WHERE Nome = @Username 
                  AND ID_Funcionario = @Password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result == null ? 0 : Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao autenticar: " + ex.Message);
                    return 0;
                }
            }
        }
    }
}