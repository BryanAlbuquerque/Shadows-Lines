using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace ShadowLines.Classes
{
    internal class Agendamento
    {
        private readonly static string _connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public int AgendamentoID { get; set; }
        public int ClienteID { get; set; }
        public int FuncionarioID { get; set; }
        public DateTime DataAgendamento { get; set; }
        public string Servico { get; set; }
        public decimal Valor { get; set; }
        public string Situacao { get; set; }
        public string Pagamento { get; set; }
        public string NomeCliente { get; set; } // Nome do cliente da tabela Clientes
        public string NomeFuncionario { get; set; } // Nome do funcionário da tabela Funcionarios

        public static List<Agendamento> Select()
        {
            var lista = new List<Agendamento>();
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
                         INNER JOIN Funcionarios F ON A.FuncionarioID = F.FuncionarioID
                         ORDER BY A.DataAgendamento DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new Agendamento()
                            {
                                AgendamentoID = r.GetInt32(r.GetOrdinal("AgendamentoID")),
                                ClienteID = r.GetInt32(r.GetOrdinal("ClienteID")),
                                FuncionarioID = r.GetInt32(r.GetOrdinal("FuncionarioID")),
                                DataAgendamento = r.GetDateTime(r.GetOrdinal("DataAgendamento")),
                                Servico = r["Servico"].ToString(),
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


        public static List<Agendamento> Busca(string termo)
        {
            var lista = new List<Agendamento>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT @termo FROM Agendamentos
                                 WHERE @termo LIKE %termo%";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@termo", termo);

                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new Agendamento()
                            {
                                AgendamentoID = r.GetInt32(r.GetOrdinal("AgendamentoID")),
                                ClienteID = r.GetInt32(r.GetOrdinal("ClienteID")),
                                FuncionarioID = r.GetInt32(r.GetOrdinal("FuncionarioID")),
                                DataAgendamento = r.GetDateTime(r.GetOrdinal("DataAgendamento")),
                                Servico = r["Servico"].ToString(),
                                Valor = (decimal)r["Valor"],
                                Situacao = r["Situacao"].ToString(),
                                Pagamento = r["Pagamento"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public bool Insert()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO Agendamentos 
                    (ClienteID, FuncionarioID, DataAgendamento, Servico, Valor, Pagamento)
                    VALUES 
                    (@ClienteID, @FuncionarioID, @DataAgendamento, @Servico, @Valor, @Pagamento)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                    cmd.Parameters.AddWithValue("@FuncionarioID", FuncionarioID);
                    cmd.Parameters.AddWithValue("@DataAgendamento", DataAgendamento);
                    cmd.Parameters.AddWithValue("@Servico", Servico);
                    cmd.Parameters.AddWithValue("@Valor", Valor);
                    cmd.Parameters.AddWithValue("@Pagamento", Pagamento);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE Agendamentos SET
                    DataAgendamento = @DataAgendamento,
                    Servico = @Servico,
                    Valor = @Valor
                    WHERE ClienteID = @ClienteID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                    cmd.Parameters.AddWithValue("@DataAgendamento", DataAgendamento);
                    cmd.Parameters.AddWithValue("@Servico", Servico);
                    cmd.Parameters.AddWithValue("@Valor", Valor);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        public bool UpdateSituacao()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE Agendamentos SET
                    Situacao = @Situacao
                    WHERE ClienteID = @ClienteID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                    cmd.Parameters.AddWithValue("@Situacao", Situacao);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateTable() 
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE Agendamentos SET
                    
                    Pagamento = @Pagamento
                    WHERE ClienteID = @ClienteID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                    cmd.Parameters.AddWithValue("@Pagamento", Pagamento);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
