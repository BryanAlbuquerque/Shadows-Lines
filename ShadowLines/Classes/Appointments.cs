using System;
using Microsoft.Data.SqlClient;

namespace ShadowLines.Classes
{
    internal class Appointments
    {
        public int ClientID { get; set; }
        public DateTime DateAppointments { get; set; }
        public string Service { get; set; }
        public int EmployeeID { get; set; }
        public double Value { get; set; }
        public string Situation { get; set; }
        public string Payment { get; set; }

        private string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public Appointments(int clientID, DateTime dateAppointments, string service, int employeeID, double value, string situation, string payment)
        {
            ClientID = clientID;
            DateAppointments = dateAppointments;
            Service = service;
            EmployeeID = employeeID;
            Value = value;
            Situation = situation;
            Payment = payment;
        }

        public bool Appointment()
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                string query = 
                @"INSERT INTO Appointments 
                (ClientID, DateAppointments, Service, EmployeeID, Value, Situation, Payment) 
                VALUES (@ClientID, @DateAppointments, @Service, @EmployeeID, @Value, @Situation, @Payment)";

                using (var command = new SqlCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@ClientID", ClientID);
                    command.Parameters.AddWithValue("@DateAppointments", DateAppointments);
                    command.Parameters.AddWithValue("@Service", Service);
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    command.Parameters.AddWithValue("@Value", Value);
                    command.Parameters.AddWithValue("@Situation", Situation);
                    command.Parameters.AddWithValue("@Payment", Payment);

                    conexao.Open();
                    int rows = command.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }
    }
}
