using ShadowLines.Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ShadowLines.Models;

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

        private void Salvar() 
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

            try
            {
                AgendamentoModel ag = new AgendamentoModel();

                ag.ClienteID = Convert.ToInt32(comboBoxCliente.SelectedValue);
                ag.Servicos = comboBoxServicos.Text;
                ag.FuncionarioID = Convert.ToInt32(comboBoxFuncionarios.SelectedValue);
                ag.Pagamento = txtStatus.Text;
                ag.Valor = Convert.ToDecimal(txtValor.Text);
                ag.DataAgendamento = Convert.ToDateTime(txtData.Text);

                Agendamento agendamento = new Agendamento();

                agendamento.Insert(ag);
                MessageBox.Show("Agendamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"ocorreu um erro: {ex}");
            }

        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento();
            int clienteId = Convert.ToInt32(comboBoxCliente.SelectedValue);

            if (!agendamento.PodeCriarNovoAgendamento(clienteId))
            {
                MessageBox.Show(
                    "Este cliente ainda possui um agendamento pendente e não pode criar outro.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; 
            }

            Salvar();
        }

        private void comboBoxServicos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxServicos.SelectedValue == null) { return; }

            int servicoID = Convert.ToInt32(comboBoxServicos.SelectedValue);

            ServicoModel servicoSelecionado = Servico.Buscar(servicoID);

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
