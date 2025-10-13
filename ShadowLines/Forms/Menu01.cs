using System;
using ShadowLines.Classes;
using ShadowLines.Forms;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class Menu01 : Form
    {
        public Menu01()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

        }
    }
}
