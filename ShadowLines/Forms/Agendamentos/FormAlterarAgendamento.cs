using Microsoft.Data.SqlClient;
using ShadowLines.Classes;
using ShadowLines.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShadowLines.Forms.Agendamentos
{
    public partial class FormAlterarAgendamento : Form
    {
        public FormAlterarAgendamento()
        {
            InitializeComponent();
        }
        public void PopularComboBoxClientes()
        {
            List<AgendamentoModel> lista = Agendamento.Select();

            MessageBox.Show(lista.Count.ToString());

            comboBoxClientes.DataSource = lista;
            comboBoxClientes.DisplayMember = "Display";
            comboBoxClientes.ValueMember = "AgendamentoID";
            comboBoxClientes.SelectedIndex = -1;
        }

        public void PopularComboBoxFuncionarios()
        {
            var lista = Funcionario.Select();
            comboBoxFuncionario.DataSource = lista;
            comboBoxFuncionario.DisplayMember = "Nome";
            comboBoxFuncionario.ValueMember = "FuncionarioID";
            comboBoxFuncionario.SelectedIndex = -1;
        }

        public void PopularComboBoxServicos()
        {
            var lista = Servico.Select();

            comboBoxServicos.DataSource = lista;
            comboBoxServicos.DisplayMember = "Nome";
            comboBoxServicos.ValueMember = "ServicoID";
            comboBoxServicos.SelectedIndex = -1;
        }

        private void FormAlterarAgendamento_Load(object sender, EventArgs e)
        {
            comboBoxClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxClientes.AutoCompleteSource = AutoCompleteSource.ListItems;

            PopularComboBoxClientes();
            PopularComboBoxFuncionarios();
            PopularComboBoxServicos();
        }

        private void comboBoxClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedIndex == -1) return;

            int id = Convert.ToInt32(comboBoxClientes.SelectedValue);
            var c = Agendamento.Select();

            comboBoxFuncionario.Text = c.Find(x => x.AgendamentoID == id)?.NomeFuncionario;
            comboBoxServicos.Text = c.Find(x => x.AgendamentoID == id)?.Servicos;

            txtData.Text = c.Find(x => x.AgendamentoID == id)?.DataAgendamento.ToString("dd/MM/yyyy HH:mm");
            txtValor.Text = c.Find(x => x.AgendamentoID == id)?.Valor.ToString("F2");
            txtSituacao.Text = c.Find(x => x.AgendamentoID == id)?.Situacao;
            txtPagamento.Text = c.Find(x => x.AgendamentoID == id)?.Pagamento;
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

        private void Salvar()
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxClientes.Text))
                {
                    MessageBox.Show("Erro! escolha o nome do cliente");
                    return;
                }
                AgendamentoModel ag = new AgendamentoModel();

                ag.ClienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);
                ag.FuncionarioID = Convert.ToInt32(comboBoxFuncionario.SelectedValue);
                ag.DataAgendamento = DateTime.Parse(txtData.Text);
                ag.Servicos = comboBoxServicos.Text;
                ag.Valor = decimal.Parse(txtValor.Text);
                ag.Situacao = txtSituacao.Text;
                ag.Pagamento = txtPagamento.Text;

                Agendamento agendamento = new Agendamento();
                agendamento.UpdateTable(ag);
                MessageBox.Show("Agendamento alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex}");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
