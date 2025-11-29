using ShadowLines.Classes;
using System;
using System.Windows.Forms;

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
            if (this.MdiParent is Menu01 menu)
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
            comboBoxClientes.ValueMember = "ClienteID";
            comboBoxClientes.SelectedIndex = -1;
        }

        private void FormSituacao_Load(object sender, EventArgs e)
        {
            PopularComboBoxSituacao();
        }

        public void Salvar() 
        { 
            Agendamento agendamento = new Agendamento();
            agendamento.ClienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);
            agendamento.Situacao = comboBoxSituacao.SelectedItem.ToString();

            agendamento.UpdateSituacao();
            MessageBox.Show("Situação atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
