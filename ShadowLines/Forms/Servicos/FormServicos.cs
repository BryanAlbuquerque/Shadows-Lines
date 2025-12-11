using ShadowLines.Classes;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Windows.Forms;

namespace ShadowLines.Forms.Servicos
{
    public partial class FormServicos : Form
    {
        public FormServicos()
        {
            InitializeComponent();
        }

        private void FormServicos_Load(object sender, EventArgs e)
        {
            sfDataGridPanel.AutoGenerateColumns = false;
            sfDataGridPanel.AllowSorting = true;
            sfDataGridPanel.AllowFiltering = true;
            sfDataGridPanel.FilterRowPosition = RowPosition.Top;

            ConfigurarColunas();
            sfDataGridPanel.DataSource = Servico.Buscar(txtBuscar.Text);
        }

        private void ConfigurarColunas()
        {
            GridTextColumn nome = new GridTextColumn();
            nome.HeaderText = "Nome";
            nome.MappingName = "Nome";
            nome.Width = 300;
            sfDataGridPanel.Columns.Add(nome);

            GridTextColumn valor = new GridTextColumn();
            valor.HeaderText = "Valor do Serviço";
            valor.MappingName = "Valor";
            valor.Width = 300;
            valor.Format = "C2";
            sfDataGridPanel.Columns.Add(valor);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();

            sfDataGridPanel.DataSource = Servico.Buscar(txtBuscar.Text);
        }
    }
}
