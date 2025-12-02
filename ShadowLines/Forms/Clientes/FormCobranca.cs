using ShadowLines.Classes;
using System;
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
    }
}
