using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

public class LoadAppointments
{
    public static string connectionString =
        "Server=DESKTOP-BRYAN\\SQLEXPRESS;Database=ShadowLines;Trusted_Connection=True;TrustServerCertificate=true";

    public void LoadAppointment(FlowLayoutPanel flowLayoutPanel)
    {
        string query = "SELECT A.AgendamentoID, C.Nome AS Cliente, A.DataAgendamento, A.Servico, A.Valor, A.Situacao, A.Pagamento " +
                       "FROM Agendamentos A " +
                       "INNER JOIN Clientes C ON A.ClienteID = C.ClienteID " +
                       "WHERE CAST(A.DataAgendamento AS DATE) = CAST(GETDATE() AS DATE)"; // Filtra agendamentos para o dia de hoje

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Limpa o FlowLayoutPanel
            flowLayoutPanel.Controls.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                Panel panelAgendamento = new Panel();
                panelAgendamento.Width = flowLayoutPanel.Width - 20; // Define a largura do painel (com padding)
                panelAgendamento.Height = 80; // Define a altura do painel (ajuste conforme necessário)
                panelAgendamento.Margin = new Padding(10);
                panelAgendamento.BorderStyle = BorderStyle.FixedSingle;

                // Adicionando Labels dentro do painel
                Label lblCliente = new Label();
                lblCliente.Text = $"Cliente: {row["Cliente"]}";
                lblCliente.Location = new Point(10, 10);
                panelAgendamento.Controls.Add(lblCliente);

                Label lblServico = new Label();
                lblServico.Text = $"Serviço: {row["Servico"]}";
                lblServico.Location = new Point(10, 30);
                panelAgendamento.Controls.Add(lblServico);

                Label lblValor = new Label();
                lblValor.Text = $"Valor: R$ {row["Valor"]}";
                lblValor.Location = new Point(10, 50);
                panelAgendamento.Controls.Add(lblValor);

                Label lblPagamento = new Label();
                lblPagamento.Text = $"Pagamento: {row["Pagamento"]}";
                lblPagamento.ForeColor = (row["Pagamento"].ToString() == "Pago") ? Color.Green : Color.Red;
                lblPagamento.Location = new Point(150, 50);
                panelAgendamento.Controls.Add(lblPagamento);

                // Adiciona o painel ao FlowLayoutPanel
                flowLayoutPanel.Controls.Add(panelAgendamento);
            }
        }
    }
}
