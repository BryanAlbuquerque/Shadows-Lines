using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ShadowLines.Classes;
using ShadowLines.Models;

namespace ShadowLines.Forms.Servicos
{
    public partial class FormAlterarServicos : Form
    {
        public FormAlterarServicos()
        {
            InitializeComponent();
        }

        private void PopularComboBox()
        {
            var servicos = Classes.Servico.Select();
            comboBoxServicos.DataSource = servicos;
            comboBoxServicos.DisplayMember = "Nome";
            comboBoxServicos.ValueMember = "ServicoID";
            comboBoxServicos.SelectedIndex = -1; 
        }

        private void FormAlterarServicos_Load(object sender, EventArgs e)
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

        private void Salvar() 
        {
            if (string.IsNullOrEmpty(comboBoxServicos.Text)) 
            { 
                MessageBox.Show("Selecione um serviço para alterar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                Servico servico = new Servico();
                ServicoModel servc = new ServicoModel();

                servc.ServicoID = Convert.ToInt32(comboBoxServicos.SelectedValue);
                servc.Nome = txtNome.Text;
                servc.Valor = Convert.ToDecimal(txtValor.Text);

                bool sucesso = servico.Update(servc);

                if (sucesso)
                {
                    MessageBox.Show("Serviço alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao alterar o serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
