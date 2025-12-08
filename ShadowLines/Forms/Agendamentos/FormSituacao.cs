using ShadowLines.Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ShadowLines.Models;

namespace ShadowLines.Forms
{
    public partial class FormSituacao : Form
    {
        public FormSituacao()
        {
            InitializeComponent();

            this.FormClosed += FormReagendamento_FormClosed;

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");
        }
        private void FormReagendamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.MdiParent is FormNivelAcesso1 menu)
            {
                menu.Interface(true);
            }
        }
        public void PopularComboBoxSituacao()
        {
            var agendamento = Agendamento.Select();

            var clientes = Cliente.Select("%");

            comboBoxClientes.DataSource = clientes;
            comboBoxClientes.DisplayMember = "Nome_Completo";
            comboBoxClientes.ValueMember = "AgendamentoID";
            comboBoxClientes.SelectedIndex = -1;
        }

        private void FormSituacao_Load(object sender, EventArgs e)
        {
            comboBoxClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxClientes.AutoCompleteSource = AutoCompleteSource.ListItems;

            PopularComboBoxSituacao();
        }

        public void Salvar()
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxClientes.Text)
                    || string.IsNullOrEmpty(comboBoxSituacao.Text))
                {
                    MessageBox.Show("Erro existem espaços em branco!");
                    return;
                }
                AgendamentoModel ag = new AgendamentoModel();
                ag.ClienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);
                ag.Situacao = comboBoxSituacao.SelectedItem.ToString();

                Agendamento agendamento = new Agendamento();
                agendamento.UpdateSituacao(ag);
                MessageBox.Show("Situação atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) 
            {
                MessageBox.Show($"Ocorreu um erro: {ex}");            
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
