using ShadowLines.Classes;
using ShadowLines.Models;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class FormReagendamento : Form
    {
        public FormReagendamento()
        {
            InitializeComponent();

            this.FormClosed += FormReagendamento_FormClosed;
        }

        private void FormReagendamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.MdiParent is FormNivelAcesso2 menu)
            {
                menu.Interface(true);
            }

            if (this.MdiParent is FormNivelAcesso2 menu03)
            {
                menu03.Interface(true);
            }

        }

        private void FormReagendamento_Load(object sender, EventArgs e)
        {
            sfDataGrid.AutoGenerateColumns = false;  
            sfDataGrid.Columns.Clear();              

            ConfigurarColunas();                     

            sfDataGrid.AllowSorting = true;
            sfDataGrid.AllowFiltering = true;
            sfDataGrid.FilterRowPosition = RowPosition.Top;

            sfDataGrid.DataSource = Agendamento.ListaEmAberto("%");  

            PopularComboBoxServicos();
        }


        public void PopularComboBoxServicos()
        {
            var lista = Servico.Select();

            comboBoxServicos.DataSource = lista;
            comboBoxServicos.DisplayMember = "Nome";
            comboBoxServicos.ValueMember = "ServicoID";
            comboBoxServicos.SelectedIndex = -1;
        }

        public void ConfigurarColunas()
        {
            GridTextColumn nome = new GridTextColumn();
            nome.MappingName = "NomeCliente";
            nome.HeaderText = "Nome do Cliente";
            nome.Width = 130;
            sfDataGrid.Columns.Add(nome);

            GridTextColumn servico = new GridTextColumn();
            servico.MappingName = "NomeFuncionario";
            servico.HeaderText = "Nome do Funcionario";
            servico.Width = 130;
            sfDataGrid.Columns.Add(servico);

            GridTextColumn dataAgendamento = new GridTextColumn();
            dataAgendamento.MappingName = "DataAgendamento";
            dataAgendamento.HeaderText = "Data do Agendamento";
            dataAgendamento.Width = 150;
            dataAgendamento.Format = "dd/MM/yyyy HH:mm";
            sfDataGrid.Columns.Add(dataAgendamento);

            GridTextColumn valor = new GridTextColumn();
            valor.MappingName = "Valor";
            valor.HeaderText = "Valor";
            valor.Format = "C2";
            valor.Width = 150;
            sfDataGrid.Columns.Add(valor);

            GridTextColumn situacao = new GridTextColumn();
            situacao.MappingName = "Situacao";
            situacao.HeaderText = "Situação";
            situacao.Width = 140;
            sfDataGrid.Columns.Add(situacao);

        }
        private void Salvar() 
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
                    MessageBox.Show("Erro! Selecione um agendamento válido na tabela.");
                    return;
                }
                selecionado.NomeCliente = txtCliente.Text;
                selecionado.DataAgendamento = DateTime.Parse(txtData.Text);
                selecionado.Servicos = comboBoxServicos.Text;
                selecionado.Valor = decimal.Parse(txtValor.Text, System.Globalization.NumberStyles.Currency);
                selecionado.Situacao = txtSituacao.Text;

                Agendamento.Update(selecionado);

                MessageBox.Show("Agendamento reagendado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                sfDataGrid.DataSource = Agendamento.ListaEmAberto("%");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnReagendar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void comboBoxServicos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxServicos.SelectedIndex == -1) return;

            ServicoModel servico = (ServicoModel)comboBoxServicos.SelectedItem;
            txtValor.Text = servico.Valor.ToString("F2");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento();

            sfDataGrid.DataSource = Agendamento.ListaEmAberto(txtBusca.Text);
        }

        private void sfDataGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            if (sfDataGrid.SelectedItem == null) return;

            AgendamentoModel selecionado = sfDataGrid.SelectedItem as AgendamentoModel;

            if (selecionado == null)
                return;

            txtCliente.Text = selecionado.NomeCliente;
            txtData.Text = selecionado.DataAgendamento.ToString("dd/MM/yyyy HH:mm");
            comboBoxServicos.Text = selecionado.Servicos;
            txtValor.Text = selecionado.Valor.ToString("C2");
            txtSituacao.Text = selecionado.Situacao;

        }
    }
}
