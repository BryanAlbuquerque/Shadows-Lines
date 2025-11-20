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

        // ==============================
        //   SELECT - LISTAR TODOS
        // ==============================
        public static List<Agendamento> Listar()
        {
            var lista = new List<Agendamento>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Agendamentos ORDER BY DataAgendamento DESC";

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
                                Pagamento = r["Pagamento"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        // ==============================
        //  SELECT POR CLIENTE
        // ==============================
        public static List<Agendamento> ListarPorCliente(int clienteId)
        {
            var lista = new List<Agendamento>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * FROM Agendamentos 
                                 WHERE ClienteID = @ID
                                 ORDER BY DataAgendamento DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", clienteId);

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

        // ==============================
        //  INSERT
        // ==============================
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

        // ==============================
        //  UPDATE
        // ==============================
        public bool Update()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE Agendamentos SET
                        ClienteID = @ClienteID,
                        FuncionarioID = @FuncionarioID,
                        DataAgendamento = @DataAgendamento,
                        Servico = @Servico,
                        Valor = @Valor,
                        Pagamento = @Pagamento,
                        Situacao = @Situacao
                    WHERE AgendamentoID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", AgendamentoID);
                    cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                    cmd.Parameters.AddWithValue("@FuncionarioID", FuncionarioID);
                    cmd.Parameters.AddWithValue("@DataAgendamento", DataAgendamento);
                    cmd.Parameters.AddWithValue("@Servico", Servico);
                    cmd.Parameters.AddWithValue("@Valor", Valor);
                    cmd.Parameters.AddWithValue("@Pagamento", Pagamento);
                    cmd.Parameters.AddWithValue("@Situacao", Situacao);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
