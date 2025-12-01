using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ShadowLines.Classes;

namespace ShadowLines.Forms
{
    public partial class FormReagendamento : Form
    {
        public FormReagendamento()
        {
            InitializeComponent();

            this.FormClosed += FormReagendamento_FormClosed;

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void FormReagendamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.MdiParent is FormMenu1 menu)
            {
                menu.Interface(true);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");
        }

        private void FormReagendamento_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            PopularComboBoxClientes();
            PopularComboBoxServicos();
        }

        public void PopularComboBoxClientes()
        {
            var lista = Cliente.Select("%");

            comboBoxCliente.DataSource = lista;
            comboBoxCliente.DisplayMember = "Nome_Completo";
            comboBoxCliente.ValueMember = "ClienteID";
            comboBoxCliente.SelectedIndex = -1;
        }

        public void PopularComboBoxServicos()
        {
            var lista = Servico.Select();

            comboBoxServicos.DataSource = lista;
            comboBoxServicos.DisplayMember = "Nome";
            comboBoxServicos.ValueMember = "ServicoID";
            comboBoxServicos.SelectedIndex = -1;
        }
        private void btnReagendar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxCliente.Text)
                    || string.IsNullOrEmpty(txtData.Text)
                    || string.IsNullOrEmpty(comboBoxServicos.Text)
                    || string.IsNullOrEmpty(txtValor.Text)) 
                {
                    MessageBox.Show("Erro existem espaços em branco!");
                    return; 
                }
                Agendamento agendamento = new Agendamento();

                agendamento.ClienteID = Convert.ToInt32(comboBoxCliente.SelectedValue);
                agendamento.DataAgendamento = DateTime.ParseExact(txtData.Text, "dd/MM/yyyy HH:mm", null);
                agendamento.Servico = comboBoxServicos.Text;
                agendamento.Valor = Convert.ToDecimal(txtValor.Text);

                agendamento.Update();
                MessageBox.Show("Reagendamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ocorreu um erro! {ex}");
            }
        }

        private void comboBoxServicos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxServicos.SelectedValue == null) { return; }

            int servicoID = Convert.ToInt32(comboBoxServicos.SelectedValue);

            Servico servicoSelecionado = Servico.SelectSet(servicoID);

            if (servicoSelecionado != null)
            {
                txtValor.Text = servicoSelecionado.Valor.ToString("F2");
            }
        }
    }
}
