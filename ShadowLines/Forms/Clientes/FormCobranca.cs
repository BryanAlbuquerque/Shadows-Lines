using ShadowLines.Classes;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowLines.Forms.Clientes
{
    public partial class FormCobranca : Form
    {
        public FormCobranca()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void FormCobranca_Load(object sender, EventArgs e)
        {
            PopularComboBoxCliente();
        }

        private void PopularComboBoxCliente()
        {
            var lista = Agendamento.ListaPendentes("%");

            comboBoxClientes.DataSource = lista;
            comboBoxClientes.DisplayMember = "NomeCliente";
            comboBoxClientes.ValueMember = "ClienteID";
            comboBoxClientes.SelectedIndex = -1;
        }

        private void comboBoxClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedIndex == -1) return;

            int id = Convert.ToInt32(comboBoxClientes.SelectedValue);
            var c = Cliente.SelectedSet(id);

            txtEmail.Text = c.Email;
        }

        public async Task<bool> EnviarCobrancaAsync(string email, string assunto, string mensagem)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5244");

                var body = new
                {
                    Para = email,
                    Assunto = assunto,
                    Mensagem = mensagem
                };

                var json = System.Text.Json.JsonSerializer.Serialize(body);
                using (var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json"))
                {
                    var response = await client.PostAsync("/api/email/enviar", content);
                    return response.IsSuccessStatusCode;
                }
            }
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string cliente = comboBoxClientes.Text;
            string email = txtEmail.Text;
            string assunto = txtAssunto.Text;
            string mensagem = txtCorpo.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Digite o e-mail do cliente!");
                return;
            }

            // Monta o corpo do e-mail com HTML
            string msgFinal = $@"
                            <h2>Cobrança de Pagamento</h2>
                            <p><b>Cliente:</b> {cliente}</p>
                            <p><b>Motivo:</b></p>
                            <p>{mensagem}</p>";

            bool enviado = await EnviarCobrancaAsync(email, assunto, msgFinal);

            if (enviado)
                MessageBox.Show("E-mail enviado com sucesso!");
            else
                MessageBox.Show("Erro ao enviar o e-mail, verifique a API.");
        }
    }
}
