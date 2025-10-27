using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace ShadowLines.Classes
{
    internal class MudarHorario
    {
        private readonly string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public void AlterarHorario(int agendamentoId, DateTime novoHorario)
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE Agendamentos
                    SET DataAgendamento = @novoHorario
                    WHERE AgendamentoID = @agendamentoId";
                using (var comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@novoHorario", novoHorario);
                    comando.Parameters.AddWithValue("@agendamentoId", agendamentoId);
                    try
                    {
                        conexao.Open();
                        int rowsAffected = comando.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Horário alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum agendamento encontrado com o ID fornecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
