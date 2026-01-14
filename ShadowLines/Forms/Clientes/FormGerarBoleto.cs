using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowLines.Forms.Clientes
{
    public partial class FormGerarBoleto : Form
    {
        public FormGerarBoleto()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void FormGerarBoleto_Load(object sender, EventArgs e)
        {
            checkBoxAtualizacao.Checked = true;

        }
    }
}
