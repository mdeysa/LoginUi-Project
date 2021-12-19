using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUi
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity = Opacity + .13;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            pictureBox1.Dispose();
            this.Hide();
            var HomeScreen = new HomeScreen();
            HomeScreen.Show();

        }
    }
}
