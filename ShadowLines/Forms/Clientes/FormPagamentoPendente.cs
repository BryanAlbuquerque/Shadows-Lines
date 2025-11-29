using ShadowLines.Classes;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Windows.Forms;

namespace ShadowLines.Forms.Clientes
{
    public partial class FormPagamentoPendente : Form
    {
        private SfDataGrid grid;
        public FormPagamentoPendente()
        {
            InitializeComponent();
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

        private void FormPagamentoPendente_Load_1(object sender, EventArgs e)
        {
            sfDataGridPanel.AutoGenerateColumns = false;
            sfDataGridPanel.AllowSorting = true;
            sfDataGridPanel.AllowFiltering = true;
            sfDataGridPanel.FilterRowPosition = RowPosition.Top;

            ConfigurarColunas();
            sfDataGridPanel.DataSource = Agendamento.ListaPendentes(txtBuscar.Text);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            sfDataGridPanel.DataSource = Agendamento.ListaPendentes(txtBuscar.Text);
        }
    }
}
