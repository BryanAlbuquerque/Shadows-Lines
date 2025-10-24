using Microsoft.Data.SqlClient;
using System;

namespace ShadowLines.Classes
{
    internal class Usuarios
    {
        private static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public string UserName { get; set; }
        public string Password { get; set; }

        public Usuarios(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
                return "Erro! Existem campos em branco.";

            if (!long.TryParse(Password, out _))
                return "CPF inválido. Digite apenas números.";

            return null;
        }

        /// <summary>
        /// Retorna o nível de acesso do usuário. 
        /// Se retornar 0, significa falha na autenticação.
        /// </summary>
        public int AutenticarUsuario()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
                  @"SELECT Nivel_Acesso
                  FROM Funcionarios 
                  WHERE Nome = @Username 
                  AND FuncionarioID = @PasswordValue";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", UserName);
                command.Parameters.AddWithValue("@PasswordValue", long.Parse(Password));

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int nivel))
                    {
                        return nivel; // 1 ou 2, conforme o BD
                    }

                    return 0; // falha na autenticação
                }
                catch
                {
                    throw; // será tratado no formulário
                }
            }
        }
    }
}
