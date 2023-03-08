using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimart_Management
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            CircleProgressBar.Value = startpoint;
            if (CircleProgressBar.Value == 100)
            {
                timer1.Stop();
                LoginForm login = new LoginForm();
                this.Hide();
                login.ShowDialog();
            }

        }
        int startpoint = 0;
        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
        }
    }
}
