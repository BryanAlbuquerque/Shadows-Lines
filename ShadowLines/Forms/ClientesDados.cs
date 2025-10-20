using ShadowLines.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            CostumersData costumersData = new CostumersData();

            dtCostumers.DataSource = costumersData.LoadData();
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
