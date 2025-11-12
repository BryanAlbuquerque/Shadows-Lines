using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace ShadowLines.Classes
{
    internal class Agendamento
    {
        public int ClientID { get; set; }
        public int FuncionarioID { get; set; }
        public DateTime DataAgendamento { get; set; }
        public string Servico { get; set; }
        public decimal Valor { get; set; }
        public string Pagamento { get; set; }

        private readonly string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public Agendamento(int clientID, DateTime dataAgendamento, string servico, 
            int funcionarioID, decimal valor, string pagamento)
        {
            ClientID = clientID;
            FuncionarioID = funcionarioID;
            DataAgendamento = dataAgendamento;
            Servico = servico;
            Valor = valor;
            Pagamento = pagamento;
        }


        private bool IsAvailable()
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) FROM Agendamentos
                                 WHERE FuncionarioID = @FuncionarioID 
                                 AND DataAgendamento = @DataAgendamento";

                using (var command = new SqlCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@FuncionarioID", FuncionarioID);
                    command.Parameters.AddWithValue("@DataAgendamento", DataAgendamento);

                    conexao.Open();
                    int count = (int)command.ExecuteScalar();

                    return count == 0;
                }
            }
        }

        // 🔹 2. Cadastra o agendamento (se disponível)
        public bool RegistrarAgendamento()
        {
            if (!IsAvailable())
            {
                MessageBox.Show("❌ Este horário já está ocupado para este funcionário.",
                                "Horário Indisponível",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (var conexao = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Agendamentos 
                                (ClienteID, FuncionarioID, DataAgendamento, Servico, Valor, Pagamento)
                                VALUES 
                                (@ClienteID, @FuncionarioID, @DataAgendamento, @Servico, @Valor, @Pagamento)";

                using (var command = new SqlCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@ClienteID", ClientID);
                    command.Parameters.AddWithValue("@FuncionarioID", FuncionarioID);
                    command.Parameters.AddWithValue("@DataAgendamento", DataAgendamento);
                    command.Parameters.AddWithValue("@Servico", Servico);
                    command.Parameters.AddWithValue("@Valor", Valor);
                    command.Parameters.AddWithValue("@Pagamento", Pagamento);

                    conexao.Open();
                    int rows = command.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("✅ Agendamento realizado com sucesso!",
                                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("❌ Falha ao registrar o agendamento.",
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
    }
}
