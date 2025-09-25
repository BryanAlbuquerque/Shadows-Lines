using System;

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

        public static string connectionString =
            "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

        public bool Appointment(string username, int password)
        {
            // Implementation go here.
            return true;
        }

    }
}
