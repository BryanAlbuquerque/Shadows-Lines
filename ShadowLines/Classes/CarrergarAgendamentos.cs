using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace ShadowLines.Classes
{
    internal class CarrergarAgendamentos
    {
        private readonly string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public List<Agendamentos> ObterAgendamentosDoDia()
        {
            List<Agendamentos> lista = new List<Agendamentos>();

            string query = @"
                SELECT 
                    A.AgendamentoID,
                    A.ClienteID,
                    C.Nome_Completo AS NomeCliente,
                    A.DataAgendamento,
                    A.Servico,
                    A.FuncionarioID,
                    A.Valor,
                    A.Situacao,
                    A.Pagamento
                FROM Agendamentos A
                JOIN Clientes C ON A.ClienteID = C.ClienteID
                WHERE CAST(A.DataAgendamento AS DATE) = CAST(GETDATE() AS DATE)
                ORDER BY A.DataAgendamento ASC";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Agendamentos
                    {
                        AgendamentoID = Convert.ToInt32(dr["AgendamentoID"]),
                        ClienteID = Convert.ToInt32(dr["ClienteID"]),
                        NomeCliente = dr["NomeCliente"].ToString(),
                        DataAgendamento = Convert.ToDateTime(dr["DataAgendamento"]),
                        Servico = dr["Servico"].ToString(),
                        FuncionarioID = Convert.ToInt32(dr["FuncionarioID"]),
                        Valor = Convert.ToDecimal(dr["Valor"]),
                        Situacao = dr["Situacao"].ToString(),
                        Pagamento = dr["Pagamento"].ToString()
                    });
                }
                dr.Close();
            }

            return lista;
        }
    }
}
