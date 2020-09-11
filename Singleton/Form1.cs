using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    public partial class Form1 : Form
    {
        ThemeManager ZainM = ThemeManager.Instance;

        public Form1()
        {
            InitializeComponent();
            ZainM.initTheme();
        }

        private void btn_Click_1(object sender, EventArgs e)
        {
            ZainM.ApplyThemeOnButton(btn);
            ZainM.ApplyThemeOnForm(this);
            this.label1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
