using System;
using System.Windows.Forms;
using ShadowLines.Classes;
using ShadowLines.Models;

namespace ShadowLines.Forms
{
    public partial class FormExcluirCliente : Form
    {
        public FormExcluirCliente()
        {
            InitializeComponent();
        }

        public void PopularComboBoxClientes()
        {
            var clientes = Classes.Cliente.Select("%");
            comboBoxClientes.DataSource = clientes;
            comboBoxClientes.DisplayMember = "Nome";
            comboBoxClientes.ValueMember = "ClienteID";
            comboBoxClientes.SelectedIndex = -1;
        }

        private void FormExcluirCliente_Load(object sender, EventArgs e)
        {
            comboBoxClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxClientes.AutoCompleteSource = AutoCompleteSource.ListItems;

            PopularComboBoxClientes();
        }

        public void Salvar() 
        {
            Cliente clientes = new Cliente();
            if (comboBoxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um cliente para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int clienteId = (int)comboBoxClientes.SelectedValue;
            var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este cliente?", 
                                                 "Confirmação de Exclusão", 
                                                 MessageBoxButtons.YesNo, 
                                                 MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    ClienteModel cliente = new ClienteModel();

                    cliente.ClienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);

                    clientes.Delete(cliente);
                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir o cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
