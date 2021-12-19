using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LoginUi.Usercontrols;


namespace LoginUi
{
    public partial class HomeScreen : Form
    {
        


        public HomeScreen()
        {
            InitializeComponent();
            UC_Resumes uc = new UC_Resumes();
            addUserControl(uc);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {
                timer2.Stop();
            }
            Opacity = Opacity + .16;
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Resumes uc = new UC_Resumes();
            addUserControl(uc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Clients uc = new UC_Clients();
            addUserControl(uc);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Letters uc = new UC_Letters();
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            US_Appointments uc = new US_Appointments();
            addUserControl(uc);
        }
    }
}
