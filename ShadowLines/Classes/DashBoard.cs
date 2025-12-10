using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace ShadowLines.Classes
{
    public class Dashboard
    {
        private string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=True";

        public int ObterTotalAgendamentosHoje()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) FROM Agendamentos 
                                 WHERE CONVERT(date, DataAgendamento) = CONVERT(date, GETDATE())";

                SqlCommand cmd = new SqlCommand(query, conexao);
                conexao.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public int ObterAgendamentosCanceladosHoje()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) FROM Agendamentos 
                                 WHERE Situacao = 'Cancelado'
                                 AND CONVERT(date, DataAgendamento) = CONVERT(date, GETDATE())";

                SqlCommand cmd = new SqlCommand(query, conexao);
                conexao.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public decimal ObterValorTotalAgendamentosHoje()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = @"SELECT SUM(Valor) FROM Agendamentos 
                                 WHERE CONVERT(date, DataAgendamento) = CONVERT(date, GETDATE())
                                 AND Situacao <> 'Cancelado'";

                SqlCommand cmd = new SqlCommand(query, conexao);
                conexao.Open();
                object result = cmd.ExecuteScalar();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

        public class AgendamentoInfo
        {
            public string NomeCliente { get; set; }
            public string Servico { get; set; }
            public decimal Valor { get; set; }
            public DateTime DataAgendamento { get; set; }
            public string Situacao { get; set; }
            public string Pagamento { get; set; }
        }
        public List<AgendamentoInfo> ObterAgendamentosDoDia()
        {
            List<AgendamentoInfo> lista = new List<AgendamentoInfo>();

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT c.Nome_Completo,
                   a.Servico,
                   a.Valor,
                   a.DataAgendamento,
                   a.Situacao,
                   a.Pagamento
                   FROM Agendamentos a
                   INNER JOIN Clientes c 
                   ON c.ClienteID = a.ClienteID
                   WHERE CONVERT(date, a.DataAgendamento) = CONVERT(date, GETDATE())";

                SqlCommand cmd = new SqlCommand(query, conexao);
                conexao.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new AgendamentoInfo
                    {
                        NomeCliente = reader.GetString(0),
                        Servico = reader.GetString(1),
                        Valor = reader.GetDecimal(2),
                        DataAgendamento = reader.GetDateTime(3),
                        Situacao = reader.GetString(4),
                        Pagamento = reader.GetString(5)
                    });
                }
            }

            return lista;
        }
    }
}
