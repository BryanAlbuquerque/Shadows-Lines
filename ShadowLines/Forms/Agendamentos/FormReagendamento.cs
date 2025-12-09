using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ShadowLines.Classes;
using ShadowLines.Models;

namespace ShadowLines.Forms
{
    public partial class FormReagendamento : Form
    {
        public FormReagendamento()
        {
            InitializeComponent();

            this.FormClosed += FormReagendamento_FormClosed;
        }

        private void FormReagendamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.MdiParent is FormNivelAcesso1 menu)
            {
                menu.Interface(true);
            }
        }

        private void FormReagendamento_Load(object sender, EventArgs e)
        {
            comboBoxCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            PopularComboBoxClientes();
            PopularComboBoxServicos();
        }

        public void PopularComboBoxClientes()
        {
            var lista = Agendamento.Select();

            comboBoxCliente.DataSource = lista;
            comboBoxCliente.DisplayMember = "NomeCliente";
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

        private void Salvar() 
        {
            if (string.IsNullOrEmpty(comboBoxCliente.Text)
                    || string.IsNullOrEmpty(txtData.Text)
                    || string.IsNullOrEmpty(comboBoxServicos.Text)
                    || string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Erro existem espaços em branco!");
                return;
            }

            try
            {
                AgendamentoModel ag = new AgendamentoModel();
                Agendamento agendamento = new Agendamento();

                ag.ClienteID = Convert.ToInt32(comboBoxCliente.SelectedValue);

                ag.AgendamentoID = agendamento.GetUltimoAgendamentoId(ag.ClienteID);

                if (ag.AgendamentoID == 0)
                {
                    MessageBox.Show("Este cliente não possui agendamentos ativos para reagendar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ag.DataAgendamento = DateTime.ParseExact(
                                        txtData.Text,
                                        "dd/MM/yyyy HH:mm",
                                        null);

                ag.Servicos = comboBoxServicos.Text;
                ag.Valor = Convert.ToDecimal(txtValor.Text);

                bool atualizado = agendamento.Update(ag);

                if (atualizado)
                {
                    MessageBox.Show("Reagendamento realizado com sucesso!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível reagendar. Tente novamente.",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ocorreu um erro! {ex}");
            }

        }
        private void btnReagendar_Click(object sender, EventArgs e)
        {
            Salvar();
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
