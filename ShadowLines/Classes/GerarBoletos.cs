using Microsoft.Data.SqlClient;
using ShadowLines.Models;
using System;
using System.Collections.Generic;

namespace ShadowLines.Classes
{
    internal class GerarBoletos
    {
        private readonly static string _connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";


        public static List<AgendamentoModel> ListarClientes(string termo)
        {
            List<AgendamentoModel> lista = new List<AgendamentoModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT 
                    A.AgendamentoID, 
                    A.ClienteID, 
                    A.DataAgendamento, 
                    A.Servico, 
                    A.Valor, 
                    A.Situacao, 
                    C.Nome AS NomeCliente

                    FROM Agendamentos A
                 INNER JOIN Clientes C ON A.ClienteID = C.ClienteID
                 WHERE Pagamento = 'Pendente'
                    AND (C.Nome LIKE '%' + @termo + '%'
                    AND A.Servico LIKE '%' + @termo + '%')";


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
                                DataAgendamento = r.GetDateTime(r.GetOrdinal("DataAgendamento")),
                                Servicos = r["Servico"].ToString(),
                                Valor = (decimal)r["Valor"],
                                NomeCliente = r["NomeCliente"].ToString(),
                            });
                        }
                    }
                }
            }

            return lista;
        }


        public static List<AgendamentoModel> ListarClienteDataSelecionada(DateTime dataPassado, DateTime dataRecente)
        {
            List<AgendamentoModel> lista = new List<AgendamentoModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT 
                    A.AgendamentoID, 
                    A.ClienteID, 
                    A.DataAgendamento, 
                    A.Servico, 
                    A.Valor, 
                    A.Situacao, 
                    C.Nome AS NomeCliente
                    FROM Agendamentos A
                 INNER JOIN Clientes C ON A.ClienteID = C.ClienteID
                 WHERE Pagamento = 'Pendente'
                    AND A.DataAgendamento BETWEEN @dataPassado AND @dataRecente";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dataPassado", dataPassado);
                    cmd.Parameters.AddWithValue("@dataRecente", dataRecente);
                    conn.Open();

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new AgendamentoModel()
                            {
                                AgendamentoID = r.GetInt32(r.GetOrdinal("AgendamentoID")),
                                ClienteID = r.GetInt32(r.GetOrdinal("ClienteID")),
                                DataAgendamento = r.GetDateTime(r.GetOrdinal("DataAgendamento")),
                                Servicos = r["Servico"].ToString(),
                                Valor = (decimal)r["Valor"],
                                NomeCliente = r["NomeCliente"].ToString(),
                            });
                        }
                    }

                }
            }
            return lista;
        }
    }
}
