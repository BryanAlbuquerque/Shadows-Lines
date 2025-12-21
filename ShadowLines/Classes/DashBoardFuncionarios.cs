using Microsoft.Data.SqlClient;
using ShadowLines.Models;
using System;
using System.Collections.Generic;

namespace ShadowLines.Classes
{
    public class DashBoardFuncionarios
    {
        private string connectionString = "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=True";

        public int ObterTotalAgendamentosHoje()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) FROM Agendamentos 
                                 WHERE FuncionarioID = @FuncionarioID 
                                 AND CONVERT(date, DataAgendamento) = CONVERT(date, GETDATE()) 
                                 AND Situacao <> 'Cancelado'"; 

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@FuncionarioID", SessaoUsuarioModel.FuncionarioID);
                conexao.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public decimal ObterValorTotalAgendamentosHojeFuncionario(int funcionarioId)
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = @"SELECT SUM(Valor) FROM Agendamentos 
                                 WHERE CONVERT(date, DataAgendamento) = CONVERT(date, GETDATE()) 
                                 AND Situacao <> 'Cancelado' 
                                 AND FuncionarioId = @FuncionarioId";
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@FuncionarioId", funcionarioId);
                conexao.Open();
                object result = cmd.ExecuteScalar();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

        public List<AgendamentoModel> ObterClientesDoDia()
        {
            List<AgendamentoModel> lista = new List<AgendamentoModel>();
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = @"SELECT c.Nome_Completo, a.Servico, a.Valor, a.DataAgendamento, a.Situacao, a.Pagamento 
                                 FROM Agendamentos a 
                                 INNER JOIN Clientes c ON c.ClienteID = a.ClienteID 
                                 WHERE FuncionarioID = @FuncionarioID 
                                 AND CONVERT(date, a.DataAgendamento) = CONVERT(date, GETDATE()) 
                                 AND a.Situacao <> 'Cancelado'";  
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@FuncionarioID", SessaoUsuarioModel.FuncionarioID);  
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