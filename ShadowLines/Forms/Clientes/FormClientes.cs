using ShadowLines.Classes;
using ShadowLines.Forms.Clientes;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
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

        private void cobrançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCobranca cobranca = Application.OpenForms.OfType<FormCobranca>().FirstOrDefault();
            if (cobranca == null)
            {
                cobranca = new FormCobranca();
                cobranca.Show();
            }
            else
            {
                if (cobranca.WindowState == FormWindowState.Minimized)
                {
                    cobranca.MdiParent = this.MdiParent;
                    cobranca.WindowState = FormWindowState.Normal;
                }
                cobranca.Activate();
            }
        }

        private void gerarBoletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerarBoleto boleto = new FormGerarBoleto();
            boleto.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroClientes cadastro = Application.OpenForms.OfType<FormCadastroClientes>().FirstOrDefault();


            if (cadastro == null)
            {
                cadastro = new FormCadastroClientes();
                cadastro.Show();
            }
            else
            {
                if (cadastro.WindowState == FormWindowState.Minimized)
                {
                    cadastro.MdiParent = this.MdiParent;
                    cadastro.WindowState = FormWindowState.Normal;
                }
                cadastro.Activate();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FormAlterarDadosCliente alterar = Application.OpenForms.OfType<FormAlterarDadosCliente>().FirstOrDefault();
            if (alterar == null)
            {
                alterar = new FormAlterarDadosCliente();
                alterar.Show();
            }
            else
            {
                if (alterar.WindowState == FormWindowState.Minimized)
                {
                    alterar.MdiParent = this.MdiParent;
                    alterar.WindowState = FormWindowState.Normal;
                }
                alterar.Activate();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FormExcluirCliente cliente = Application.OpenForms.OfType<FormExcluirCliente>().FirstOrDefault();
            if (cliente == null)
            {
                cliente = new FormExcluirCliente();
                cliente.Show();
            }
            else
            {
                if (cliente.WindowState == FormWindowState.Minimized)
                {
                    cliente.MdiParent = this.MdiParent;
                    cliente.WindowState = FormWindowState.Normal;
                }
                cliente.Activate();
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            sfDataGridPanel.Visible = true;

            sfDataGridPanel.AutoGenerateColumns = false;
            sfDataGridPanel.AllowSorting = true;
            sfDataGridPanel.AllowEditing = false;
            sfDataGridPanel.AllowFiltering = true;
            sfDataGridPanel.FilterRowPosition = RowPosition.Top;

            ConfigurarColunas();
            sfDataGridPanel.DataSource = Cliente.Select(txtBuscar.Text);

            // Pagamentos pendentes
            sfDataGridPanelPendentes.AutoGenerateColumns = false;
            sfDataGridPanelPendentes.AllowEditing = false;
            sfDataGridPanelPendentes.AllowSorting = true;
            sfDataGridPanelPendentes.AllowFiltering = true;
            sfDataGridPanelPendentes.FilterRowPosition = RowPosition.Top;

            ConfigurarColunasPagamentos();
            sfDataGridPanelPendentes.DataSource = Agendamento.ListaPendentes(txtBuscar.Text);
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

        private void ConfigurarColunasPagamentos()
        {
            GridTextColumn nome = new GridTextColumn();
            nome.MappingName = "NomeCliente";
            nome.HeaderText = "Nome do Cliente";
            nome.Width = 220;
            sfDataGridPanelPendentes.Columns.Add(nome);

            GridTextColumn nomeFuncionario = new GridTextColumn();
            nomeFuncionario.MappingName = "NomeFuncionario";
            nomeFuncionario.HeaderText = "Nome do Funcionario";
            nomeFuncionario.Width = 170;
            sfDataGridPanelPendentes.Columns.Add(nomeFuncionario);


            GridTextColumn dataAgendamento = new GridTextColumn();
            dataAgendamento.MappingName = "DataAgendamento";
            dataAgendamento.HeaderText = "Data do Agendamento";
            dataAgendamento.Width = 200;
            sfDataGridPanelPendentes.Columns.Add(dataAgendamento);

            GridTextColumn servico = new GridTextColumn();
            servico.MappingName = "Servico";
            servico.HeaderText = "Serviço";
            servico.Width = 180;
            sfDataGridPanelPendentes.Columns.Add(servico);

            GridTextColumn valor = new GridTextColumn();
            valor.MappingName = "Valor";
            valor.HeaderText = "Valor";
            valor.Width = 220;
            sfDataGridPanelPendentes.Columns.Add(valor);

            GridTextColumn situacao = new GridTextColumn();
            situacao.MappingName = "Situacao";
            situacao.HeaderText = "Situação do agendamento";
            situacao.Width = 200;
            sfDataGridPanelPendentes.Columns.Add(situacao);

            GridTextColumn pagamento = new GridTextColumn();
            pagamento.MappingName = "Pagamento";
            pagamento.HeaderText = "Pagamento";
            pagamento.Width = 175;
            sfDataGridPanelPendentes.Columns.Add(pagamento);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (sfDataGridPanel.Visible = true)
            {
                sfDataGridPanel.DataSource = Cliente.Select(txtBuscar.Text);
            }
            else if (sfDataGridPanelPendentes.Visible = true)
            {
                sfDataGridPanelPendentes.DataSource = Agendamento.ListaPendentes(txtBuscar.Text);
            }
        }

        private void clientesPagamentoPendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfDataGridPanelPendentes.Visible = true;
            sfDataGridPanel.Visible = false;
        }

        private void visualizarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfDataGridPanel.Visible = true;
            sfDataGridPanelPendentes.Visible = false;
        }
    }
}
