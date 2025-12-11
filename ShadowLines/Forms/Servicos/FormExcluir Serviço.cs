using ShadowLines.Models;
using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using ShadowLines.Classes;

namespace ShadowLines.Forms.Servicos
{
    public partial class FormExcluirServico : Form
    {
        public FormExcluirServico()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");
        }

        private void PopularComboBox()
        {
            var servicos = Classes.Servico.Select();
            comboBoxServicos.DataSource = servicos;
            comboBoxServicos.DisplayMember = "Nome";
            comboBoxServicos.ValueMember = "ServicoID";
            comboBoxServicos.SelectedIndex = -1;
        }

        private void FormExcluirServico_Load(object sender, EventArgs e)
        {
            comboBoxServicos.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxServicos.AutoCompleteSource = AutoCompleteSource.ListItems;

            PopularComboBox();
        }

        private void comboBoxServicos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxServicos.SelectedIndex == -1) return;

            ServicoModel servico = (ServicoModel)comboBoxServicos.SelectedItem;
            txtNome.Text = servico.Nome;
            txtValor.Text = servico.Valor.ToString("F2");
        }

        private void Excluir() 
        {
            if (string.IsNullOrEmpty(comboBoxServicos.Text)) 
            {
                MessageBox.Show("Selecione um serviço para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                Servico servicos = new Servico();

                bool ok = servicos.Delete((int)comboBoxServicos.SelectedValue);

                if (ok)
                {
                    MessageBox.Show("Serviço excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopularComboBox();
                    txtNome.Clear();
                    txtValor.Clear();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao excluir o serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Excluir();
        }
    }
}
