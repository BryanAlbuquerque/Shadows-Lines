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
    public partial class FormAgendamento : Form
    {
        public FormAgendamento()
        {
            InitializeComponent();
            this.FormClosed += FormAgendamento_FormClosed;

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");
        }

        private void FormAgendamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.MdiParent is Menu01 menu)
            {
                menu.Interface(true);
            }
        }

        public void PopularComboBoxClientes()
        {
            Cliente clientes = new Cliente();
            comboBox1.DataSource = Cliente.ListarClientes();
            comboBox1.DisplayMember = "Nome_Completo";
            comboBox1.ValueMember = "ClienteID";
        }

        public void PopularComboBoxServicos()
        {
            // Lógica para popular o ComboBox
        }

        public void PopularComboBoxFuncionarios()
        {
            // Lógica para popular o ComboBox
        }
    }
}
