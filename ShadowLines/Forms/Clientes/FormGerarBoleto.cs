using ShadowLines.Classes;
using Syncfusion.WinForms.DataGrid;
using System.Windows.Forms;
using System;

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
            sfDataGrid.AutoGenerateColumns = false;
            sfDataGrid.AllowSorting = true;
            sfDataGrid.AllowEditing = false;
            sfDataGrid.AllowFiltering = true;

            sfDataGrid.DataSource = GerarBoletos.BoletoAgendamentoPendente(txtBuscar.Text);

            checkBoxAtualizacao.Checked = true;

            ConfigurarColunas();

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
            sfDataGrid.Columns.Add(valor);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            sfDataGrid.DataSource = GerarBoletos.BoletoAgendamentoPendente(txtBuscar.Text);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            sfDataGrid.DataSource = GerarBoletos.BoletoAgendamentoPendente();
        }
    }
}
