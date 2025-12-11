using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using ShadowLines.Classes;
using ShadowLines.Models;

namespace ShadowLines.Forms.Servicos
{
    public partial class FormCadastrarServico : Form
    {
        public FormCadastrarServico()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");
        }

        private void FormCadastrarServico_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar() 
        {
            if (string.IsNullOrEmpty(txtNome.Text)
                || string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                Servico servico = new Servico();
                ServicoModel servc = new ServicoModel();

                servc.Nome = txtNome.Text;
                servc.Valor = decimal.Parse(txtValor.Text);

                bool ok = servico.Insert(servc);

                if (ok)
                {
                    MessageBox.Show("Serviço cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar o serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar o serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }
    }
}
