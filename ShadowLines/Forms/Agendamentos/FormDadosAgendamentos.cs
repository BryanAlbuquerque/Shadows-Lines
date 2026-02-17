using ShadowLines.Classes;
using ShadowLines.Models;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class FormDadosAgendamentos : Form
    {
        public FormDadosAgendamentos()
        {
            InitializeComponent();

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
        private void ClientesDados_Load(object sender, EventArgs e)
        {

            sfDataGrid.AutoGenerateColumns = false;
            sfDataGrid.AllowSorting = true;
            sfDataGrid.AllowFiltering = true;
            sfDataGrid.FilterRowPosition = RowPosition.Top;

            ConfigurarColunas();
            PopularComboBoxFuncionarios();
            PopularComboBoxServicos();
            sfDataGrid.DataSource = Agendamento.Busca("%");

            txtValor.Text = null;
        }

        private void ConfigurarColunas()
        {
            GridTextColumn nome = new GridTextColumn();
            nome.MappingName = "NomeCliente";
            nome.HeaderText = "Nome do Cliente";
            nome.Width = 220;
            sfDataGrid.Columns.Add(nome);

            GridTextColumn nomeFuncionario = new GridTextColumn();
            nomeFuncionario.MappingName = "NomeFuncionario";
            nomeFuncionario.HeaderText = "Nome do Funcionario";
            nomeFuncionario.Width = 170;
            sfDataGrid.Columns.Add(nomeFuncionario);

            GridTextColumn dataAgendamento = new GridTextColumn();
            dataAgendamento.MappingName = "DataAgendamento";
            dataAgendamento.HeaderText = "Data do Agendamento";
            dataAgendamento.Width = 200;
            dataAgendamento.Format = "dd/MM/yyyy HH:mm";
            sfDataGrid.Columns.Add(dataAgendamento);

            GridTextColumn servico = new GridTextColumn();
            servico.MappingName = "Servicos";
            servico.HeaderText = "Serviço";
            servico.Width = 180;
            sfDataGrid.Columns.Add(servico);

            GridTextColumn valor = new GridTextColumn();
            valor.MappingName = "Valor";
            valor.HeaderText = "Valor";
            valor.Format = "C2";
            valor.Width = 220;
            sfDataGrid.Columns.Add(valor);

            GridTextColumn situacao = new GridTextColumn();
            situacao.MappingName = "Situacao";
            situacao.HeaderText = "Situação do agendamento";
            situacao.Width = 200;
            sfDataGrid.Columns.Add(situacao);

            GridTextColumn pagamento = new GridTextColumn();
            pagamento.MappingName = "Pagamento";
            pagamento.HeaderText = "Pagamento";
            pagamento.Width = 180;
            sfDataGrid.Columns.Add(pagamento);
        }


        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            if (SessaoUsuarioModel.NivelAcesso == 2)
            {
                FormNivelAcesso2 menu = new FormNivelAcesso2();
                menu.Show();
                this.Hide();
            }
            else if (SessaoUsuarioModel.NivelAcesso == 3)
            {
                FormNivelAcesso3 menu = new FormNivelAcesso3();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro: Nível de acesso inválido. Contate o administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "Deseja realmente fechar o sistema?",
            "Confirmar saída",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void Pesquisar()
        {
            Agendamento agendamento = new Agendamento();

            sfDataGrid.DataSource = Agendamento.Busca(txtBusca.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        public void Salvar()
        {
            if (sfDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Erro! Selecione um agendamento na tabela.");
                return;
            }

            try
            {
                AgendamentoModel selecionado = sfDataGrid.SelectedItem as AgendamentoModel;

                if (selecionado == null)
                {
                    MessageBox.Show("Erro ao obter o agendamento selecionado.");
                    return;
                }

                AgendamentoModel ag = new AgendamentoModel();

                ag.AgendamentoID = selecionado.AgendamentoID;
                ag.ClienteID = selecionado.ClienteID;

                ag.FuncionarioID = Convert.ToInt32(comboBoxFuncionario.SelectedValue);
                ag.DataAgendamento = DateTime.Parse(txtData.Text);
                ag.Servicos = comboBoxServicos.Text;
                ag.Valor = decimal.Parse(txtValor.Text.Replace("R$", "").Trim());
                ag.Situacao = txtSituacao.Text;
                ag.Pagamento = txtPagamento.Text;

                Agendamento agendamento = new Agendamento();
                bool ok = agendamento.UpdateTable(ag);

                if (ok)
                {
                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sfDataGrid.DataSource = Agendamento.Busca("%");
                }
                else
                {
                    MessageBox.Show("Erro ao alterar os dados.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void sfDataGridPanel_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            if (sfDataGrid.SelectedItem == null)
                return;

            AgendamentoModel agendamento = sfDataGrid.SelectedItem as AgendamentoModel;

            if (agendamento == null)
                return;

            txtCliente.Text = agendamento.NomeCliente;
            comboBoxFuncionario.Text = agendamento.NomeFuncionario;
            txtData.Text = agendamento.DataAgendamento.ToString("dd/MM/yyyy");
            comboBoxServicos.Text = agendamento.Servicos;
            txtValor.Text = agendamento.Valor.ToString("C2");
            txtPagamento.Text = agendamento.Pagamento;
            txtSituacao.Text = agendamento.Situacao;
        }

        private void comboBoxServicos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxServicos.SelectedIndex == -1) return;

            ServicoModel servico = (ServicoModel)comboBoxServicos.SelectedItem;
            txtValor.Text = servico.Valor.ToString("F2");
        }

        private void sfDataGrid_Click(object sender, EventArgs e)
        {

        }
    }
}
