using System;
using ShadowLines.Classes;
using ShadowLines.Forms;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class Menu01 : Form
    {
        public Menu01()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
        }
    }
}
