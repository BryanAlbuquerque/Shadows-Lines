using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace ShadowLines.Classes
{
    internal class Appointments
    {
        public int ClientID { get; set; }
        public DateTime DateAppointments { get; set; }
        public string Service { get; set; }
        public int EmployeeID { get; set; }
        public decimal Value { get; set; }
        public string Payment { get; set; }
        public string Situation { get; set; }

        private readonly string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public Appointments(int clientID, DateTime dateAppointments, string service,
            int employeeID, decimal value, string payment)
        {
            ClientID = clientID;
            DateAppointments = dateAppointments;
            Service = service;
            EmployeeID = employeeID;
            Value = value;
            Payment = payment;
            Situation = "Em Aberto";
        }

        // 🔹 1. Verifica se o funcionário já tem agendamento
        private bool IsAvailable()
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) FROM Agendamentos
                                 WHERE FuncionarioID = @FuncionarioID 
                                 AND DataAgendamento = @DataAgendamento";

                using (var command = new SqlCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@FuncionarioID", EmployeeID);
                    command.Parameters.AddWithValue("@DataAgendamento", DateAppointments);

                    conexao.Open();
                    int count = (int)command.ExecuteScalar();

                    return count == 0; // true = disponível
                }
            }
        }

        // 🔹 2. Cadastra o agendamento (se disponível)
        public bool RegisterAppointments()
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
                    command.Parameters.AddWithValue("@FuncionarioID", EmployeeID);
                    command.Parameters.AddWithValue("@DataAgendamento", DateAppointments);
                    command.Parameters.AddWithValue("@Servico", Service);
                    command.Parameters.AddWithValue("@Valor", Value);
                    command.Parameters.AddWithValue("@Pagamento", Payment);

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
