using Microsoft.Data.SqlClient;
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
            var lista = Agendamento.Select();

            comboBoxClientes.DataSource = lista;
            comboBoxClientes.DisplayMember = "NomeCliente";
            comboBoxClientes.ValueMember = "ClienteID";
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
            comboBoxCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            PopularComboBoxClientes();
            PopularComboBoxFuncionarios();
            PopularComboBoxServicos();
        }

        private void comboBoxClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedIndex == -1) return;

            int id = Convert.ToInt32(comboBoxClientes.SelectedValue);
            var c = Agendamento.Select();

            comboBoxFuncionario.Text = c.Find(x => x.ClienteID == id)?.NomeFuncionario;
            comboBoxServicos.Text = c.Find(x => x.ClienteID == id)?.Servico;

            txtData.Text = c.Find(x => x.ClienteID == id)?.DataAgendamento.ToString("dd/MM/yyyy HH:mm");
            txtValor.Text = c.Find(x => x.ClienteID == id)?.Valor.ToString("F2");
            txtSituacao.Text = c.Find(x => x.ClienteID == id)?.Situacao;
            txtPagamento.Text = c.Find(x => x.ClienteID == id)?.Pagamento;
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
                Agendamento agendamento = new Agendamento();

                agendamento.ClienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);
                agendamento.FuncionarioID = Convert.ToInt32(comboBoxFuncionario.SelectedValue);
                agendamento.DataAgendamento = DateTime.Parse(txtData.Text);
                agendamento.Servico = comboBoxServicos.Text;
                agendamento.Valor = decimal.Parse(txtValor.Text);
                agendamento.Situacao = txtSituacao.Text;
                agendamento.Pagamento = txtPagamento.Text;

                agendamento.UpdateTable();
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
