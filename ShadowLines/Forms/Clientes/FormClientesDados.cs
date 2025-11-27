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

            sfDataGridPanel.AutoGenerateColumns = false;
            sfDataGridPanel.AllowSorting = true;
            sfDataGridPanel.AllowFiltering = true;
            sfDataGridPanel.FilterRowPosition = RowPosition.Top;

            ConfigurarColunas();
            sfDataGridPanel.DataSource = Cliente.Select();
        }


        private void ConfigurarColunas()
        {
            GridTextColumn nome = new GridTextColumn();
            nome.MappingName = "Nome_Completo";
            nome.HeaderText = "Nome Completo";
            nome.Width = 220;
            sfDataGridPanel.Columns.Add(nome);

            GridTextColumn cpf = new GridTextColumn();
            cpf.MappingName = "CPF";
            cpf.HeaderText = "CPF";
            cpf.Width = 170;
            sfDataGridPanel.Columns.Add(cpf);

            GridTextColumn telefone = new GridTextColumn();
            telefone.MappingName = "Telefone";
            telefone.HeaderText = "Telefone";
            telefone.Width = 180;
            sfDataGridPanel.Columns.Add(telefone);

            GridTextColumn email = new GridTextColumn();
            email.MappingName = "Email";
            email.HeaderText = "Email";
            email.Width = 220;
            sfDataGridPanel.Columns.Add(email);

            GridTextColumn dataNascimento = new GridTextColumn();
            dataNascimento.MappingName = "Data_Nascimento";
            dataNascimento.HeaderText = "Data Nascimento";
            dataNascimento.Format = "dd/MM/yyyy";
            dataNascimento.Width = 200;
            sfDataGridPanel.Columns.Add(dataNascimento);

            GridTextColumn endereco = new GridTextColumn();
            endereco.MappingName = "Endereco";
            endereco.HeaderText = "Endereço";
            endereco.Width = 200;
            sfDataGridPanel.Columns.Add(endereco);

            GridTextColumn dataCadastro = new GridTextColumn();
            dataCadastro.MappingName = "DataCadastro";
            dataCadastro.HeaderText = "Data do Cadastro";
            dataCadastro.Width = 180;
            sfDataGridPanel.Columns.Add(dataCadastro);
        }


        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            FormClientes clientes = new FormClientes();
            clientes.Show();
            this.Hide();
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
                this.Close(); // Fecha o formulário
            }
        }
    }
}
