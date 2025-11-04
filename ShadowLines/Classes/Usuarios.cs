using Microsoft.Data.SqlClient;
using System;

namespace ShadowLines.Classes
{
    internal class Usuarios
    {
        private readonly string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public string NomeUsuario { get; set; }
        public string SenhaId{ get; set; }

        public Usuarios(string nomeUsuario, string senhaId)
        {
            NomeUsuario = nomeUsuario;
            SenhaId = senhaId;
        }

        public string ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(NomeUsuario) || string.IsNullOrWhiteSpace(SenhaId))
                return "Erro! Existem campos em branco.";

            if (!long.TryParse(SenhaId, out _))
                return "Inválido. Digite apenas números.";

            return null;
        }

        public int AutenticarUsuario()
        {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query =
                      @"SELECT Nome, Nivel_Acesso
                        FROM Funcionarios 
                        WHERE Nome = @NomeUsuario
                        AND FuncionarioID = @SenhaId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NomeUsuario", NomeUsuario);
                    command.Parameters.AddWithValue("@SenhaId", long.Parse(SenhaId));

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            SessaoUsuarioModel.NomeUsuario = reader["Nome"].ToString();
                            SessaoUsuarioModel.NivelAcesso = Convert.ToInt32(reader["Nivel_Acesso"]);

                            return SessaoUsuarioModel.NivelAcesso; // 1, 2 ou 3 conforme BD
                        }

                        return 0; // Falha de autenticação
                    }
                    catch
                    {
                        throw;
                    }
                }
        }
    }
}
