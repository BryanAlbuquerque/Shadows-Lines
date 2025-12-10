using ShadowLines.Classes;
using ShadowLines.Models;
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ShadowLines.Forms.Funcionarios
{
    public partial class FormCadastrarFuncionario : Form
    {
        public FormCadastrarFuncionario()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Time_Ticker;
            timer.Start();

        }

        private void Time_Ticker(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FormCadastrarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void Cadastro()
        {
            if (string.IsNullOrEmpty(txtNome.Text)
                || string.IsNullOrEmpty(txtCpf.Text)
                || string.IsNullOrEmpty(txtData.Text)
                || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtTelefone.Text)
                || string.IsNullOrEmpty(txtEndereco.Text)
                || string.IsNullOrEmpty(txtCargo.Text)
                || string.IsNullOrEmpty(txtAcesso.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Funcionario funcionario = new Funcionario();
                FuncionarioModel func = new FuncionarioModel();

                func.Nome = txtNome.Text;
                func.CPF = long.Parse(txtCpf.Text);
                func.DataNascimento = DateTime.Parse(txtData.Text);
                func.Email = txtEmail.Text;
                func.Telefone = long.Parse(txtTelefone.Text);
                func.Endereco = txtEndereco.Text;
                func.Cargo = txtCargo.Text;
                func.NivelAcesso = int.Parse(txtAcesso.Text);

                bool sucesso = funcionario.Insert(func);

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
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro();
        }
    }
}
