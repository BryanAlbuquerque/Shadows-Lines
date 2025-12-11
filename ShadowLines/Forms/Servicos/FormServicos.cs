using ShadowLines.Classes;
using ShadowLines.Forms;
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
            nome.Width = 400;
            sfDataGridPanel.Columns.Add(nome);

            GridTextColumn valor = new GridTextColumn();
            valor.HeaderText = "Valor do Serviço";
            valor.MappingName = "Valor";
            valor.Width = 400;
            valor.Format = "C2";
            sfDataGridPanel.Columns.Add(valor);

            GridTextColumn dataInclusao = new GridTextColumn();
            dataInclusao.HeaderText = "Data de Inclusão";
            dataInclusao.MappingName = "DataInclusao";
            dataInclusao.Width = 400;
            dataInclusao.Format = "dd/MM/yyyy HH:mm";
            sfDataGridPanel.Columns.Add(dataInclusao);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();

            sfDataGridPanel.DataSource = Servico.Buscar(txtBuscar.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormNivelAcesso2 formNivelAcesso2 = new FormNivelAcesso2();
            formNivelAcesso2.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrarServico servico = new FormCadastrarServico();
            servico.MdiParent = this.MdiParent;
            servico.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FormAlterarServicos servicos = new FormAlterarServicos();
            servicos.MdiParent = this.MdiParent;
            servicos.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FormExcluirServico servico = new FormExcluirServico();
            servico.MdiParent = this.MdiParent;
            servico.Show();
        }
    }
}
