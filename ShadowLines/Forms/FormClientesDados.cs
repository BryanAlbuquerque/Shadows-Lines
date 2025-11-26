using System;
using ShadowLines.Classes;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace ShadowLines.Forms
{
    public partial class FormClientesDados : Form
    {
        private SfDataGrid grid;
        public FormClientesDados()
        {
            InitializeComponent();
        }

        private void ClientesDados_Load(object sender, EventArgs e)
        {
            InicializarGrid();
            ConfigurarColunas();
        }

        private void InicializarGrid()
        {
            grid = new SfDataGrid();
            grid.Dock = DockStyle.Fill;
            grid.AutoGenerateColumns = false;
            grid.AllowSorting = true;
            grid.AllowFiltering = true;
            grid.FilterRowPosition = RowPosition.Top;

            sfDataGridPanel.Controls.Add(grid);
        }

        private void ConfigurarColunas()
        {
            GridTextColumn nome = new GridTextColumn();
            nome.MappingName = "Nome_Completo";
            nome.HeaderText = "Nome Completo";
            nome.Width = 200;
            grid.Columns.Add(nome);

            GridTextColumn cpf = new GridTextColumn();
            cpf.MappingName = "CPF";
            cpf.HeaderText = "CPF";
            cpf.Width = 120;
            grid.Columns.Add(cpf);

            GridTextColumn telefone = new GridTextColumn();
            telefone.MappingName = "Telefone";
            telefone.HeaderText = "Telefone";
            telefone.Width = 120;
            grid.Columns.Add(telefone);

            GridTextColumn email = new GridTextColumn();
            email.MappingName = "Email";
            email.HeaderText = "Email";
            email.Width = 180;
            grid.Columns.Add(email);
        }


        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            FormClientes clientes = new FormClientes();
            clientes.Show();
            this.Hide();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
