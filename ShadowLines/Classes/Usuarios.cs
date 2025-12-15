using Microsoft.Data.SqlClient;
using System;

namespace ShadowLines.Classes
{
    internal class Usuarios
    {
        private readonly string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public string NomeUsuario { get; set; }
        public string SenhaId { get; set; }

        public int Login()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =
                  @"SELECT Nome, NivelAcesso
                        FROM Funcionarios 
                        WHERE Nome = @NomeUsuario
                        AND FuncionarioID = @SenhaId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NomeUsuario", NomeUsuario);
                command.Parameters.AddWithValue("@SenhaId", SenhaId);


                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    SessaoUsuarioModel.NomeUsuario = reader["Nome"].ToString();
                    SessaoUsuarioModel.NivelAcesso = Convert.ToInt32(reader["NivelAcesso"]);

                    return SessaoUsuarioModel.NivelAcesso; // 1 ou 2 conforme BD
                }

                return 0; // Falha de autenticação
            }

        }
    }
}
