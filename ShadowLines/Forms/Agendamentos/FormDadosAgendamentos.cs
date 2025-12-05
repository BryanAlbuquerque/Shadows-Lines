using System;
using ShadowLines.Classes;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using ShadowLines.Forms.Agendamentos;

namespace ShadowLines.Forms
{
    public partial class FormDadosAgendamentos : Form
    {
        public FormDadosAgendamentos()
        {
            InitializeComponent();
        }

        private void ClientesDados_Load(object sender, EventArgs e)
        {

            sfDataGridPanel.AutoGenerateColumns = false;
            sfDataGridPanel.AllowSorting = true;
            sfDataGridPanel.AllowFiltering = true;
            sfDataGridPanel.FilterRowPosition = RowPosition.Top;

            ConfigurarColunas();
            sfDataGridPanel.DataSource = Agendamento.Select();
        }

        private void ConfigurarColunas()
        {
            GridTextColumn nome = new GridTextColumn();
            nome.MappingName = "NomeCliente";
            nome.HeaderText = "Nome do Cliente";
            nome.Width = 220;
            sfDataGridPanel.Columns.Add(nome);

            GridTextColumn nomeFuncionario = new GridTextColumn();
            nomeFuncionario.MappingName = "NomeFuncionario";
            nomeFuncionario.HeaderText = "Nome do Funcionario";
            nomeFuncionario.Width = 170;
            sfDataGridPanel.Columns.Add(nomeFuncionario);


            GridTextColumn dataAgendamento = new GridTextColumn();
            dataAgendamento.MappingName = "DataAgendamento";
            dataAgendamento.HeaderText = "Data do Agendamento";
            dataAgendamento.Width = 200;
            sfDataGridPanel.Columns.Add(dataAgendamento);

            GridTextColumn servico = new GridTextColumn();
            servico.MappingName = "Servico";
            servico.HeaderText = "Serviço";
            servico.Width = 180;
            sfDataGridPanel.Columns.Add(servico);

            GridTextColumn valor = new GridTextColumn();
            valor.MappingName = "Valor";
            valor.HeaderText = "Valor";
            valor.Format = "C2";
            valor.Width = 220;
            sfDataGridPanel.Columns.Add(valor);

            GridTextColumn situacao = new GridTextColumn();
            situacao.MappingName = "Situacao";
            situacao.HeaderText = "Situação do agendamento";
            situacao.Width = 200;
            sfDataGridPanel.Columns.Add(situacao);

            GridTextColumn pagamento = new GridTextColumn();
            pagamento.MappingName = "Pagamento";
            pagamento.HeaderText = "Pagamento";
            pagamento.Width = 180;
            sfDataGridPanel.Columns.Add(pagamento);
        }


        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            if (SessaoUsuarioModel.NivelAcesso == 1)
            {
                FormNivelAcesso1 menu = new FormNivelAcesso1();
                menu.Show();
                this.Hide();
            }
            else if (SessaoUsuarioModel.NivelAcesso == 2)
            {
                FormNivelAcesso2 menu = new FormNivelAcesso2();
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

            sfDataGridPanel.DataSource = Agendamento.Busca(txtBusca.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FormAlterarAgendamento alterarAgendamento = new FormAlterarAgendamento();
            alterarAgendamento.MdiParent = this.MdiParent;
            alterarAgendamento.Show();
        }
    }
}
