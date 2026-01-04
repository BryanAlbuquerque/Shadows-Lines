using Microsoft.Data.SqlClient;
using ShadowLines.Classes;
using ShadowLines.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShadowLines.Forms.FormsMenu2
{
    public partial class FormAgendamentoNivelAcesso3 : Form
    {
        public FormAgendamentoNivelAcesso3()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");
        }

        // Agendamento
        public void PopularComboBoxClientes()
        {
            var lista = Cliente.Select("%");

            comboBoxClientes.DataSource = lista;
            comboBoxClientes.DisplayMember = "Nome_Completo";
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

        // Reagendamento    
        public void PopularComboBoxClientesReagendamento()
        {
            var lista = Agendamento.Select();

            comboBoxClientesReagendamento.DataSource = lista;
            comboBoxClientesReagendamento.DisplayMember = "NomeCliente";
            comboBoxClientesReagendamento.ValueMember = "ClienteID";
            comboBoxClientesReagendamento.SelectedIndex = -1;
        }
        public void PopularComboBoxServicosReagendamento()
        {
            var lista = Servico.Select();
            comboBoxServicosReagendamento.DataSource = lista;
            comboBoxServicosReagendamento.DisplayMember = "Nome";
            comboBoxServicosReagendamento.ValueMember = "ServicoID";
            comboBoxServicosReagendamento.SelectedIndex = -1;
        }

        // Situação
        public void PopularComboBoxClientesSituacao()
        {
            var lista = Agendamento.Select();

            comboBoxClientesSituacao.DataSource = lista;
            comboBoxClientesSituacao.DisplayMember = "Display";
            comboBoxClientesSituacao.ValueMember = "ClienteID";
            comboBoxClientesSituacao.SelectedIndex = -1;
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


                AgendamentoModel ag = new AgendamentoModel();

                ag.ClienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);
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
            Agendar();
        }

        private void FormAgendamento2_Load(object sender, EventArgs e)
        {
            comboBoxClientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxClientes.AutoCompleteSource = AutoCompleteSource.CustomSource;

            comboBoxClientesReagendamento.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxClientesReagendamento.AutoCompleteSource = AutoCompleteSource.CustomSource;

            comboBoxClientesSituacao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            lblData.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");
            lblDataSituacao.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");

            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            txtDataReagendamento.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Agendamento
            PopularComboBoxClientes();
            PopularComboBoxFuncionarios();
            PopularComboBoxServicos();

            // Reagendamento 
            PopularComboBoxClientesReagendamento();
            PopularComboBoxServicosReagendamento();

            // Situação
            PopularComboBoxClientesSituacao();

        }

        private void comboBoxServicos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxServicos.SelectedIndex == -1) return;

            ServicoModel servico = (ServicoModel)comboBoxServicos.SelectedItem;
            txtValor.Text = servico.Valor.ToString("F2");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormNivelAcesso3 menu2 = new FormNivelAcesso3();
            menu2.Show();
            this.Hide();
        }

        private void Reagendar()
        {
            if (string.IsNullOrEmpty(comboBoxClientesReagendamento.Text)
                    || string.IsNullOrEmpty(txtValorReagendamento.Text)
                    || string.IsNullOrEmpty(txtDataReagendamento.Text))
            {
                MessageBox.Show("Erro existem espaços em branco");
                return;
            }
            try
            {
                AgendamentoModel ag = new AgendamentoModel();
                Agendamento agendamento = new Agendamento();

                ag.ClienteID = Convert.ToInt32(comboBoxClientesReagendamento.SelectedValue);

                ag.AgendamentoID = agendamento.GetUltimoAgendamentoId(ag.ClienteID);

                if (ag.AgendamentoID == 0)
                {
                    MessageBox.Show("Este cliente não possui agendamentos ativos para reagendar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ag.DataAgendamento = DateTime.ParseExact(
                                        txtDataReagendamento.Text,
                                        "dd/MM/yyyy HH:mm",
                                        null);

                ag.Servicos = comboBoxServicosReagendamento.Text;
                ag.Valor = Convert.ToDecimal(txtValorReagendamento.Text);

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
                MessageBox.Show($"ocorreu um erro: {ex}");
            }
        }
        private void btnReagendar_Click_1(object sender, EventArgs e)
        {
            Reagendar();
        }

        private void Alterar()
        {
            if (string.IsNullOrEmpty(comboBoxClientesSituacao.Text)
                || string.IsNullOrEmpty(comboBoxSituacao.Text))
            {
                MessageBox.Show("Erro existem espaços em branco");
                return;
            }

            try
            {
                AgendamentoModel ag = new AgendamentoModel();
                Agendamento agendamento = new Agendamento();

                ag.ClienteID = Convert.ToInt32(comboBoxClientesSituacao.SelectedValue);

                ag.AgendamentoID = agendamento.GetUltimoAgendamentoId(ag.ClienteID);

                if (ag.AgendamentoID == 0)
                {
                    MessageBox.Show("Este cliente não possui agendamentos ativos para reagendar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ag.AgendamentoID = agendamento.GetUltimoAgendamentoId(ag.ClienteID);
                ag.Situacao = comboBoxSituacao.Text;

                bool atualizado = agendamento.UpdateSituacao(ag);

                if (atualizado)
                {
                    MessageBox.Show("Situação atualizada com sucesso!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar. Tente novamente.",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"ocorreu um erro: {ex}");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void comboBoxServicosReagendamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxServicosReagendamento.SelectedIndex == -1) return;

            ServicoModel servico = (ServicoModel)comboBoxServicosReagendamento.SelectedItem;
            txtValorReagendamento.Text = servico.Valor.ToString("F2");

        }

        private void comboBoxClientesReagendamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxClientesReagendamento.SelectedIndex == -1) return;

            int id = Convert.ToInt32(comboBoxClientesReagendamento.SelectedValue);

            List<AgendamentoModel> lista = Agendamento.Busca("%");

            AgendamentoModel ag = lista.Find(x => x.ClienteID == id);

            if (ag == null) return;

            comboBoxServicosReagendamento.Text = ag.Servicos;

            txtDataReagendamento.Text = ag.DataAgendamento.ToString("dd/MM/yyyy HH:mm");
            txtValorReagendamento.Text = ag.Valor.ToString("F2");
        }
    }
}
