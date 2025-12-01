using ShadowLines.Classes;
using ShadowLines.Forms.Agendamentos;
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

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgendamento agendamento = new FormAgendamento();
            agendamento.MdiParent = this;
            agendamento.Show();
        }

        private void reagendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReagendamento reagendamento = new FormReagendamento();
            reagendamento.MdiParent = this;
            reagendamento.Show();
        }

        private void alterarSituaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSituacao situacao = new FormSituacao();
            situacao.MdiParent = this;
            situacao.Show();
        }
    }
}
