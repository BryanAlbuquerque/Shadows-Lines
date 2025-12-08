using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using ShadowLines.Models;

namespace ShadowLines.Classes
{
    internal class Agendamento
    {
        private readonly static string _connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public static List<AgendamentoModel> Select()
        {
            List<AgendamentoModel> lista = new List<AgendamentoModel>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT 
                            A.AgendamentoID, 
                            A.ClienteID, 
                            A.FuncionarioID, 
                            A.DataAgendamento, 
                            A.Servico, 
                            A.Valor, 
                            A.Situacao, 
                            A.Pagamento, 
                         C.Nome_Completo AS NomeCliente, F.Nome AS NomeFuncionario
                         FROM Agendamentos A
                         INNER JOIN Clientes C ON A.ClienteID = C.ClienteID
                         INNER JOIN Funcionarios F ON A.FuncionarioID = F.FuncionarioID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new AgendamentoModel()
                            {
                                AgendamentoID = r.GetInt32(r.GetOrdinal("AgendamentoID")),
                                ClienteID = r.GetInt32(r.GetOrdinal("ClienteID")),
                                FuncionarioID = r.GetInt32(r.GetOrdinal("FuncionarioID")),
                                DataAgendamento = r.GetDateTime(r.GetOrdinal("DataAgendamento")),
                                Servicos = r["Servico"].ToString(),
                                Valor = (decimal)r["Valor"],
                                Situacao = r["Situacao"].ToString(),
                                Pagamento = r["Pagamento"].ToString(),
                                NomeCliente = r["NomeCliente"].ToString(),
                                NomeFuncionario = r["NomeFuncionario"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }


        public static List<AgendamentoModel> Busca(string termo)
        {
           List<AgendamentoModel> lista = new List<AgendamentoModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT 
                    A.AgendamentoID, 
                    A.ClienteID, 
                    A.FuncionarioID, 
                    A.DataAgendamento, 
                    A.Servico, 
                    A.Valor, 
                    A.Situacao, 
                    A.Pagamento, 
                    C.Nome_Completo AS NomeCliente, 
                    F.Nome AS NomeFuncionario

                    FROM Agendamentos A
                         INNER JOIN Clientes C ON A.ClienteID = C.ClienteID
                         INNER JOIN Funcionarios F ON A.FuncionarioID = F.FuncionarioID
                         WHERE C.Nome_Completo LIKE '%' + @termo + '%' 
                    OR F.Nome LIKE '%' + @termo + '%' 
                    OR A.Servico LIKE '%' + @termo + '%'
                    OR A.DataAgendamento LIKE '%' + @termo + '%'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@termo", termo);

                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new AgendamentoModel()
                            {
                                AgendamentoID = r.GetInt32(r.GetOrdinal("AgendamentoID")),
                                ClienteID = r.GetInt32(r.GetOrdinal("ClienteID")),
                                FuncionarioID = r.GetInt32(r.GetOrdinal("FuncionarioID")),
                                DataAgendamento = r.GetDateTime(r.GetOrdinal("DataAgendamento")),
                                Servicos = r["Servico"].ToString(),
                                Valor = (decimal)r["Valor"],
                                Situacao = r["Situacao"].ToString(),
                                Pagamento = r["Pagamento"].ToString(),
                                NomeCliente = r["NomeCliente"].ToString(),
                                NomeFuncionario = r["NomeFuncionario"].ToString() 
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public static List<AgendamentoModel> ListaPendentes(string termo)
        {
            List<AgendamentoModel> lista = new List<AgendamentoModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT 
                    A.AgendamentoID, 
                    A.ClienteID, 
                    A.FuncionarioID, 
                    A.DataAgendamento, 
                    A.Servico, 
                    A.Valor, 
                    A.Situacao, 
                    A.Pagamento, 
                    C.Nome_Completo AS NomeCliente, 
                    F.Nome AS NomeFuncionario

                    FROM Agendamentos A
                 INNER JOIN Clientes C ON A.ClienteID = C.ClienteID
                 INNER JOIN Funcionarios F ON A.FuncionarioID = F.FuncionarioID
                 WHERE Pagamento = 'Pendente'
                    AND (C.Nome_Completo LIKE '%' + @termo + '%'
                    AND F.Nome LIKE '%' + @termo + '%'
                    AND A.Servico LIKE '%' + @termo + '%'
                    AND A.DataAgendamento LIKE '%' + @termo + '%')";
                    

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@termo", termo);

                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new AgendamentoModel()
                            {
                                AgendamentoID = r.GetInt32(r.GetOrdinal("AgendamentoID")),
                                ClienteID = r.GetInt32(r.GetOrdinal("ClienteID")),
                                FuncionarioID = r.GetInt32(r.GetOrdinal("FuncionarioID")),
                                DataAgendamento = r.GetDateTime(r.GetOrdinal("DataAgendamento")),
                                Servicos = r["Servico"].ToString(),
                                Valor = (decimal)r["Valor"],
                                Situacao = r["Situacao"].ToString(),
                                Pagamento = r["Pagamento"].ToString(),
                                NomeCliente = r["NomeCliente"].ToString(),
                                NomeFuncionario = r["NomeFuncionario"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }



        public bool Insert(AgendamentoModel ag)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO Agendamentos 
                    (ClienteID, FuncionarioID, DataAgendamento, Servico, Valor, Pagamento)
                    VALUES 
                    (@ClienteID, @FuncionarioID, @DataAgendamento, @Servicos, @Valor, @Pagamento)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", ag.ClienteID);
                    cmd.Parameters.AddWithValue("@FuncionarioID", ag.FuncionarioID);
                    cmd.Parameters.AddWithValue("@DataAgendamento", ag.DataAgendamento);
                    cmd.Parameters.AddWithValue("@Servicos", ag.Servicos);
                    cmd.Parameters.AddWithValue("@Valor", ag.Valor);
                    cmd.Parameters.AddWithValue("@Pagamento", ag.Pagamento);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(AgendamentoModel ag)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE Agendamentos SET
                    DataAgendamento = @DataAgendamento,
                    Servico = @Servicos,
                    Valor = @Valor
                    WHERE ClienteID = @ClienteID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", ag.ClienteID);
                    cmd.Parameters.AddWithValue("@DataAgendamento", ag.DataAgendamento);
                    cmd.Parameters.AddWithValue("@Servicos", ag.Servicos);
                    cmd.Parameters.AddWithValue("@Valor", ag.Valor);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        public bool UpdateSituacao(AgendamentoModel ag)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE Agendamentos SET
                    Situacao = @Situacao
                    WHERE ClienteID = @ClienteID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", ag.ClienteID);
                    cmd.Parameters.AddWithValue("@Situacao", ag.Situacao);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateTable(AgendamentoModel ag) 
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE Agendamentos SET
                    FuncionarioID = @FuncionarioID,
                    Servico = @Servicos, 
                    DataAgendamento = @DataAgendamento,
                    Valor = @Valor,
                    Situacao = @Situacao,
                    Pagamento = @Pagamento
                    WHERE ClienteID = @ClienteID";  

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", ag.ClienteID);
                    cmd.Parameters.AddWithValue("@FuncionarioID", ag.FuncionarioID);
                    cmd.Parameters.AddWithValue("@Servicos", ag.Servicos);
                    cmd.Parameters.AddWithValue("@DataAgendamento", ag.DataAgendamento);
                    cmd.Parameters.AddWithValue("@Valor", ag.Valor);
                    cmd.Parameters.AddWithValue("@Situacao", ag.Situacao);
                    cmd.Parameters.AddWithValue("@Pagamento", ag.Pagamento);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
