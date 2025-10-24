using ShadowLines.Classes;
using System;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class ClientesDados : Form
    {
        public ClientesDados()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ClientesDados_Load(object sender, EventArgs e)
        {
            CarregarDadosClientes clientes = new CarregarDadosClientes();

            dtCostumers.DataSource = clientes.CarregarDados();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
