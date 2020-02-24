using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMSQL.Telas;

namespace SistemaMSQL
{
    public partial class InicioCarregamento : Form
    {
        public InicioCarregamento()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if(progressBar1.Value >= 100)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
                timer1.Enabled = true;
                progressBar1.Visible = false;
                timer1.Enabled = false;
                
            }
        }
    }
}
