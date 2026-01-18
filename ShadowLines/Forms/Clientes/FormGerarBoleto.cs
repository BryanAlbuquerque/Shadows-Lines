using ShadowLines.Classes;
using ShadowLines.Models;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Windows.Forms;

namespace ShadowLines.Forms.Clientes
{
    public partial class FormGerarBoleto : Form
    {
        public FormGerarBoleto()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void FormGerarBoleto_Load(object sender, EventArgs e)
        {

            DateTimerDataAntiga.Value = DateTime.Now.AddMonths(-1);
            DateTimerDataRecente.Value = DateTime.Now;

            sfDataGrid.AutoGenerateColumns = false;
            sfDataGrid.AllowSorting = true;
            sfDataGrid.AllowEditing = false;
            sfDataGrid.AllowFiltering = true;

            ConfigurarColunas();

            txtCliente.ReadOnly = true;
            txtData.ReadOnly = true;
            txtServico.ReadOnly = true;
            txtValor.ReadOnly = true;
            txtSituacao.ReadOnly = true;

        }

        private void ConfigurarColunas()
        {
            GridTextColumn nome = new GridTextColumn();
            nome.MappingName = "NomeCliente";
            nome.HeaderText = "Nome do Cliente";
            nome.Width = 220;
            sfDataGrid.Columns.Add(nome);

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
            valor.Width = 220;
            valor.Format = "C2";
            sfDataGrid.Columns.Add(valor);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            sfDataGrid.DataSource = GerarBoletos.PesquisarClientes(txtBuscar.Text);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            sfDataGrid.DataSource = 
                GerarBoletos.ListarClienteDataSelecionada(DateTimerDataAntiga.Value, DateTimerDataRecente.Value);
        }

        private void sfDataGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {

            if (sfDataGrid.SelectedItem == null)
                return;

            AgendamentoModel agendamento = sfDataGrid.SelectedItem as AgendamentoModel;

            if (agendamento == null)
                return;

            txtCliente.Text = agendamento.NomeCliente;
            txtData.Text = agendamento.DataAgendamento.ToString("dd/MM/yyyy");
            txtServico.Text = agendamento.Servicos;
            txtValor.Text = agendamento.Valor.ToString("C2");
            txtSituacao.Text = "Pendente";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
            this.Hide();
        }
    }
}
