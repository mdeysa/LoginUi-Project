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

namespace LoginUi
{
    public partial class Create : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     
            int nTopRect,      
            int nRightRect,    
            int nBottomRect,   
            int nWidthEllipse, 
            int nHeightEllipse 
        );



        public Create()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 70, 70));
        }

        

       

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool check =  true;
            do
            {
                if (txtNewUser.Text.Contains("!") || txtNewUser.Text.Contains("_"))
                {
                    this.loginInfoTableAdapter.Insert(txtNewUser.Text, txtNewPass.Text);
                    this.loginInfoTableAdapter.Fill(this.loginDataSet.LoginInfo);
                    Properties.Settings.Default.Save();
                    this.Hide();
                    var Login = new Login();
                    Login.Show();
                }
                else
                {
                    MessageBox.Show("Please include ! or _ in your Username");
                    txtNewUser.Text = "Username";
                    txtNewPass.Text = "Password";
                    check = false;
                }

            } while (check = false);
            

        }

        private void txtNewUser_Enter(object sender, EventArgs e)
        {
            if (txtNewUser.Text == "Username")
            {
                txtNewUser.Text = "";
                txtNewUser.ForeColor = Color.White;
            }
        }

        private void txtNewUser_Leave(object sender, EventArgs e)
        {
            if (txtNewUser.Text == "")
            {
                txtNewUser.Text = "Username";
                txtNewUser.ForeColor = Color.White;
            }
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "Password")
            {
                txtNewPass.Text = "";
                txtNewPass.ForeColor = Color.White;
            }
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                txtNewPass.Text = "Password";
                txtNewPass.ForeColor = Color.White;
            }

        }

        private void iconBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Login = new Login();
            Login.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity = Opacity + .13;

        }
    }
}
