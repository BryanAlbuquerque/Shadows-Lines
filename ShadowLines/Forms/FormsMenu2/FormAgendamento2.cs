using ShadowLines.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace ShadowLines.Forms.FormsMenu2
{
    public partial class FormAgendamento2 : Form
    {
        public FormAgendamento2()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");
        }

        public void PopularComboBoxClientes()
        {
            var lista = Agendamento.Select();

            comboBoxClientes.DataSource = lista;
            comboBoxClientes.DisplayMember = "NomeCliente";
            comboBoxClientes.ValueMember = "ClienteID";
            comboBoxClientes.SelectedIndex = -1;

        }

        public void PopularComboBoxFuncionarios()
        {
            var lista = Funcionario.Select();
            comboBoxFuncionarios.DataSource = lista;
            comboBoxFuncionarios.DisplayMember = "Nome";
            comboBoxFuncionarios.ValueMember = "FuncionarioID";
            comboBoxFuncionarios.SelectedIndex = -1;
        }

        public void PopularComboBoxServicos()
        {
            var lista = Servico.Select();

            comboBoxServicos.DataSource = lista;
            comboBoxServicos.DisplayMember = "Nome";
            comboBoxServicos.ValueMember = "ServicoID";
            comboBoxServicos.SelectedIndex = -1;
        }
        private void Agendar() 
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxClientes.Text)
                    || string.IsNullOrEmpty(comboBoxServicos.Text)
                    || string.IsNullOrEmpty(comboBoxFuncionarios.Text)
                    || string.IsNullOrEmpty(txtStatus.Text)
                    || string.IsNullOrEmpty(txtValor.Text)
                    || string.IsNullOrEmpty(txtData.Text))
                {
                    MessageBox.Show("Erro existem espaços em branco");
                    return;
                }


                Agendamento agendamento = new Agendamento();

                agendamento.ClienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);
                agendamento.Servico = comboBoxServicos.Text;
                agendamento.FuncionarioID = Convert.ToInt32(comboBoxFuncionarios.SelectedValue);
                agendamento.Pagamento = txtStatus.Text;
                agendamento.Valor = Convert.ToDecimal(txtValor.Text);
                agendamento.DataAgendamento = Convert.ToDateTime(txtData.Text);

                agendamento.Insert();
                MessageBox.Show("Agendamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {

                MessageBox.Show($"ocorreu um erro: {ex}");
            }

        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Agendar();
        }

        private void FormAgendamento2_Load(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");

            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            PopularComboBoxClientes();
            PopularComboBoxFuncionarios();
            PopularComboBoxServicos();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu2 menu2 = new FormMenu2();
            menu2.Show();
            this.Hide();
        }
    }
}
