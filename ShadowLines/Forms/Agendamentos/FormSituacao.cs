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
            if (this.MdiParent is FormNivelAcesso2 menu)
            {
                menu.Interface(true);
            }
        }
        public void PopularComboBoxClientes()
        {
            var lista = Agendamento.Select();

            comboBoxClientes.DataSource = lista;
            comboBoxClientes.DisplayMember = "Display";
            comboBoxClientes.ValueMember = "ClienteID";
            comboBoxClientes.SelectedIndex = -1;
        }

        private void FormSituacao_Load(object sender, EventArgs e)
        {
            comboBoxClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxClientes.AutoCompleteSource = AutoCompleteSource.ListItems;

            PopularComboBoxClientes();
        }

        public void Salvar()
        {
            if (string.IsNullOrEmpty(comboBoxClientes.Text)
                || string.IsNullOrEmpty(comboBoxSituacao.Text))
            {
                MessageBox.Show("Erro: existem espaços em branco!");
                return;
            }

            try
            {
                AgendamentoModel ag = new AgendamentoModel();

                ag.ClienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);
                ag.Situacao = comboBoxSituacao.SelectedItem.ToString();

                Agendamento agendamento = new Agendamento();
                bool ok = agendamento.UpdateSituacao(ag);

                if (ok)
                    MessageBox.Show("Situação atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Nenhum agendamento encontrado para este cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
