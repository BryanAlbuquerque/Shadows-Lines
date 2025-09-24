using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShadowLines
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            RoundedPanel panel = new RoundedPanel()
            {
                BorderRadius = 50,
                BorderColor = Color.Blue,
                BorderSize = 3,
                BackColor = Color.LightGray,
                Size = new Size(200, 100),
                Location = new Point(50, 50)
            };

            this.Controls.Add(panel);
        }
    }
}
