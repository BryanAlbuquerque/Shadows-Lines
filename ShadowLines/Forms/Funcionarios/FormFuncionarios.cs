using ShadowLines.Classes;
using ShadowLines.Forms.Funcionarios;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Windows.Forms;

namespace ShadowLines.Forms.FormsMenu2
{
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            sfDataGridPanel.AutoGenerateColumns = false;
            sfDataGridPanel.AllowSorting = true;
            sfDataGridPanel.AllowFiltering = true;
            sfDataGridPanel.FilterRowPosition = RowPosition.Top;
            sfDataGrid();
            sfDataGridPanel.DataSource = Funcionario.Buscar(txtBuscar.Text);
        }

        public void sfDataGrid()
        {
            Funcionario funcionario = new Funcionario();

            GridTextColumn nome = new GridTextColumn();
            nome.MappingName = "Nome";
            nome.HeaderText = "Nome Completo";
            nome.Width = 220;
            sfDataGridPanel.Columns.Add(nome);

            GridTextColumn cpf = new GridTextColumn();
            cpf.MappingName = "CPF";
            cpf.HeaderText = "CPF";
            cpf.Width = 150;
            sfDataGridPanel.Columns.Add(cpf);

            GridTextColumn Nascimento = new GridTextColumn();
            Nascimento.MappingName = "DataNascimento";
            Nascimento.HeaderText = "Data de Nascimento";
            Nascimento.Format = "dd/MM/yyyy";
            Nascimento.Width = 150;
            sfDataGridPanel.Columns.Add(Nascimento);

            GridTextColumn email = new GridTextColumn();
            email.MappingName = "Email";
            email.HeaderText = "E-mail";
            email.Width = 200;
            sfDataGridPanel.Columns.Add(email);

            GridTextColumn telefone = new GridTextColumn();
            telefone.MappingName = "Telefone";
            telefone.HeaderText = "Telefone";
            telefone.Width = 150;
            sfDataGridPanel.Columns.Add(telefone);

            GridTextColumn endereco = new GridTextColumn();
            endereco.MappingName = "Endereco";
            endereco.HeaderText = "Endereço";
            endereco.Width = 230;
            sfDataGridPanel.Columns.Add(endereco);

            GridTextColumn cargo = new GridTextColumn();
            cargo.MappingName = "Cargo";
            cargo.HeaderText = "Cargo";
            cargo.Width = 150;
            sfDataGridPanel.Columns.Add(cargo);

            GridTextColumn nivelAcesso = new GridTextColumn();
            nivelAcesso.MappingName = "NivelAcesso";
            nivelAcesso.HeaderText = "Nível de Acesso";
            nivelAcesso.Width = 125;
            sfDataGridPanel.Columns.Add(nivelAcesso);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            sfDataGridPanel.DataSource = Funcionario.Buscar(txtBuscar.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FormAlterarDadosFuncionarios formAlterar = new FormAlterarDadosFuncionarios();
            formAlterar.MdiParent = this.MdiParent;
            formAlterar.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormNivelAcesso3 formNivelAcesso2 = new FormNivelAcesso3();
            formNivelAcesso2.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrarFuncionario CadastroFuncionarios = new FormCadastrarFuncionario(); 
            CadastroFuncionarios.MdiParent = this.MdiParent;
            CadastroFuncionarios.Show();
        }
    }
}
