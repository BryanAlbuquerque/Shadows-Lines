using System;
using System.Windows.Forms;
using ShadowLines.Classes;
using ShadowLines.Models;

namespace ShadowLines.Forms.Funcionarios
{
    public partial class FormAlterarDadosFuncionarios : Form
    {
        public FormAlterarDadosFuncionarios()
        {
            InitializeComponent();
        }

        private void PopularComboBoxFuncionarios()
        {
            var lista = Funcionario.Buscar("%");

            comboBoxFuncionarios.DataSource = lista;
            comboBoxFuncionarios.DisplayMember = "Nome";
            comboBoxFuncionarios.ValueMember = "FuncionarioID";
            comboBoxFuncionarios.SelectedIndex = -1;
        }
        private void FormAlterarDadosFuncionarios_Load(object sender, EventArgs e)
        {
            comboBoxFuncionarios.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxFuncionarios.AutoCompleteSource = AutoCompleteSource.ListItems;

            PopularComboBoxFuncionarios();
        }

        private void Salvar()
        {
            if (string.IsNullOrEmpty(txtNome.Text)
                || string.IsNullOrEmpty(txtCPF.Text)
                || string.IsNullOrEmpty(txtData.Text)
                || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtEndereço.Text)
                || string.IsNullOrEmpty(txtCargo.Text)
                || string.IsNullOrEmpty(comboBoxNivelAcesso.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FuncionarioModel func = new FuncionarioModel();
                Funcionario funcionario = new Funcionario();

                func.FuncionarioID = Convert.ToInt32(comboBoxFuncionarios.SelectedValue);
                func.Nome = txtNome.Text;
                func.CPF = Convert.ToInt64(txtCPF.Text);
                func.DataNascimento = Convert.ToDateTime(txtData.Text);
                func.Email = txtEmail.Text;
                func.Telefone = Convert.ToInt64(txtTelefone.Text);
                func.Endereco = txtEndereço.Text;
                func.Cargo = txtCargo.Text;
                func.NivelAcesso = Convert.ToInt32(comboBoxNivelAcesso.Text);

                bool sucesso = funcionario.Update(func);

                if (sucesso)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar os dados do funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void comboBoxFuncionarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxFuncionarios.SelectedIndex != -1)
            {
                FuncionarioModel funcionario = (FuncionarioModel)comboBoxFuncionarios.SelectedItem;
                txtNome.Text = funcionario.Nome;
                txtCPF.Text = funcionario.CPF.ToString();
                txtData.Text = funcionario.DataNascimento.ToString("dd/MM/yyyy");
                txtEmail.Text = funcionario.Email;
                txtTelefone.Text = funcionario.Telefone.ToString();
                txtEndereço.Text = funcionario.Endereco;
                txtCargo.Text = funcionario.Cargo;
                comboBoxNivelAcesso.Text = funcionario.NivelAcesso.ToString();
            }
        }
    }
}
