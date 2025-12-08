using ShadowLines.Classes;
using System;
using System.Data.SqlClient;
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
            if (this.MdiParent is FormNivelAcesso1 menu)
            {
                menu.Interface(true);
            }
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

        public void PopularComboBoxFuncionarios()
        {
            var lista = Funcionario.Select();
            comboBoxFuncionarios.DataSource = lista;
            comboBoxFuncionarios.DisplayMember = "Nome";
            comboBoxFuncionarios.ValueMember = "FuncionarioID";
            comboBoxFuncionarios.SelectedIndex = -1;
        }

        private void FormAgendamento_Load(object sender, EventArgs e)
        {
            comboBoxCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            PopularComboBoxClientes();
            PopularComboBoxServicos();
            PopularComboBoxFuncionarios();

            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxCliente.Text) 
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

                agendamento.ClienteID = Convert.ToInt32(comboBoxCliente.SelectedValue);
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

        private void comboBoxCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) 
            { 
                comboBoxCliente.DataSource = Cliente.Select(comboBoxCliente.Text);
            }
        }
    }
}
