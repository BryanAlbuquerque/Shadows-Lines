using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using ShadowLines.Models;

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

        public List<AgendamentoModel> ObterAgendamentosDoDia()
        {
            List<AgendamentoModel> lista = new List<AgendamentoModel>();

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT c.Nome,
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
                    lista.Add(new AgendamentoModel
                    {
                        NomeCliente = reader.GetString(0),
                        Servicos = reader.GetString(1),
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
