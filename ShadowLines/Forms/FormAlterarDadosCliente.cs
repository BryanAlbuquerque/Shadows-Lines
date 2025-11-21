using ShadowLines.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class FormAlterarDadosCliente : Form
    {
        public FormAlterarDadosCliente()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }   

        private void PopularComboBoxClientes()
        {
            var lista = Cliente.Select();

            comboBoxClientes.DataSource = lista;
            comboBoxClientes.DisplayMember = "Nome_Completo";
            comboBoxClientes.ValueMember = "ClienteID";
            comboBoxClientes.SelectedIndex = -1;
        }

        private void FormAlterarDadosCliente_Load(object sender, EventArgs e)
        {
            PopularComboBoxClientes();
        }

        private void Salvar()
        {
            Cliente clientes = new Cliente();

            clientes.ClienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);
            clientes.Nome_Completo = txtNome.Text;
            clientes.CPF = Convert.ToInt64(txtCpf.Text.Replace(".", "").Replace("-", ""));
            clientes.Telefone = Convert.ToInt64(txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""));
            clientes.Email = txtEmail.Text;
            clientes.Data_Nascimento = DateTime.ParseExact(txtData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            clientes.Endereco = txtEndereco.Text;

            clientes.Update();

            MessageBox.Show("Dados alterados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Salvar();   
        }

        private void comboBoxClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedValue == null) { return; }

            int servicoID = Convert.ToInt32(comboBoxClientes.SelectedValue);

            Cliente servicoSelecionado = Cliente.SelectSet(txtNo);

            if (servicoSelecionado != null)
            {
                txtValor.Text = servicoSelecionado.Valor.ToString("F2");
            }
        }
    }
}
