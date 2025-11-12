using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace ShadowLines.Classes
{
    internal class Reagendamento
    {
        private readonly string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public void AlterarHorario(string clienteId, DateTime novoHorario)
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE Agendamentos
                    SET DataAgendamento = @novoHorario
                    WHERE ClienteId = @clienteId";
                using (var comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@novoHorario", novoHorario);
                    comando.Parameters.AddWithValue("@clienteId", clienteId);
                    try
                    {
                        conexao.Open();
                        int rowsAffected = comando.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Horário alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if(rowsAffected < 0)
                        {
                            MessageBox.Show("Nenhum agendamento encontrado com o ID fornecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (string.IsNullOrEmpty(clienteId)) 
                        {
                            MessageBox.Show("Erro! Existem espaços em branco");
                        }
                        else if(novoHorario < DateTime.Now) 
                        {
                            MessageBox.Show("Permitido somente datas futuras");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao alterar horário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
