using ShadowLines.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace ShadowLines.Forms.FormsMenu2
{
    public partial class FormAgendamento2 : Form
    {
        public FormAgendamento2()
        {
            InitializeComponent();
        }

        private void Agendar() 
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxCliente.Text)
                    || string.IsNullOrEmpty(comboBoxServicos.Text)
                    || string.IsNullOrEmpty(comboBoxFuncionarios.Text)
                    || string.IsNullOrEmpty(txtStatus.Text)
                    || string.IsNullOrEmpty(txtValor.Text)
                    || string.IsNullOrEmpty(txtData.Text))
                {
                    MessageBox.Show("Erro existem espaços em branco");
                    return;
                }


                Agendamento agendamento = new Agendamento();

                agendamento.ClienteID = Convert.ToInt32(comboBoxCliente.SelectedValue);
                agendamento.Servico = comboBoxServicos.Text;
                agendamento.FuncionarioID = Convert.ToInt32(comboBoxFuncionarios.SelectedValue);
                agendamento.Pagamento = txtStatus.Text;
                agendamento.Valor = Convert.ToDecimal(txtValor.Text);
                agendamento.DataAgendamento = Convert.ToDateTime(txtData.Text);

                agendamento.Insert();
                MessageBox.Show("Agendamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {

                MessageBox.Show($"ocorreu um erro: {ex}");
            }

        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Agendar();
        }

       
    }
}
