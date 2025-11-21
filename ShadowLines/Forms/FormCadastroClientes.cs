using System;
using ShadowLines.Classes;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class FormCadastroClientes : Form
    {
        public FormCadastroClientes()
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

        private void FormCadastroClientes_Load(object sender, EventArgs e)
        {

        }

        private void Salvar() 
        { 
            Cliente clientes = new Cliente();
            
            clientes.Nome_Completo = txtNome.Text;
            clientes.CPF = Convert.ToInt64(txtCpf.Text.Replace(".", "").Replace("-", ""));
            clientes.Telefone = Convert.ToInt64(txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""));
            clientes.Email = txtEmail.Text;
            clientes.Data_Nascimento = Convert.ToDateTime(txtData.Text);
            clientes.Endereco = txtEndereco.Text;

            clientes.Insert();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
