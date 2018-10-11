/***********************************************************
* 版本: V1.0
* 创建人：胡思旺
* 创建时间：2017年9月20日 
* 版权所有:胡思旺
* 说明：未经作者同意不得用于商业用途
* 联系方式:siwanghu@hotmail.com
************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class LoginForm : Form
    {
        private ConfigureXml configureXml = null;
        private StringBuilder password;
        public LoginForm()
        {
            InitializeComponent();
            configureXml = ConfigureXml.getInstance();
            password = new StringBuilder();
        }

        private void loginForm_configure()
        {
            string path = configureXml.getUIForm_Background();
            string control_path = configureXml.getUIForm_Control_Background();
            if (path != "")
                loginForm_background_pictureBox.Image = new Bitmap(path);
            if (control_path != "")
            {
                loginForm_button_one.Image = new Bitmap(control_path);
                loginForm_button_two.Image = new Bitmap(control_path);
                loginForm_button_three.Image = new Bitmap(control_path);
                loginForm_button_four.Image = new Bitmap(control_path);
                loginForm_button_five.Image = new Bitmap(control_path);
                loginForm_button_six.Image = new Bitmap(control_path);
                loginForm_button_seven.Image = new Bitmap(control_path);
                loginForm_button_eight.Image = new Bitmap(control_path);
                loginForm_button_nine.Image = new Bitmap(control_path);
                loginForm_button_zero.Image = new Bitmap(control_path);
                loginForm_button_exit.Image = new Bitmap(control_path);
                loginForm_button_cancel.Image = new Bitmap(control_path);
                loginForm_button_login.Image = new Bitmap(control_path);
            }
        }

        private void loginForm_load(object sender, EventArgs e)
        {
            this.loginForm_login_panel.Parent = this.loginForm_background_pictureBox;
            loginForm_configure();
        }

        private void system_exit_button_click(object sender, EventArgs e)
        {
            this.Hide();
            System.Environment.Exit(0);
        }

        private void system_cancel_button_click(object sender, EventArgs e)
        {
            this.Hide();
            int userForm = int.Parse(configureXml.getUIForm());
            switch (userForm)
            {
                case 1:
                    new UserForm_one().Show();
                    break;
                case 2:
                    new UserForm_two().Show();
                    break;
                case 3:
                    new UserForm_three().Show();
                    break;
                default:
                    break;
            }
        }

        private void system_login_button_click(object sender, EventArgs e)
        {        
            if (password.ToString().Equals(configureXml.getPassword_password()))
            {
                this.Hide();
                new ConfigureForm().Show();
            }         
            else
            {
                password.Clear();
                MessageBox.Show("密码输入错误！", "提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void system_one_button_click(object sender, EventArgs e)
        {
            password.Append("1");
        }

        private void system_two_button_click(object sender, EventArgs e)
        {
            password.Append("2");
        }

        private void system_three_button_click(object sender, EventArgs e)
        {
            password.Append("3");
        }

        private void system_four_button_click(object sender, EventArgs e)
        {
            password.Append("4");
        }

        private void system_five_button_click(object sender, EventArgs e)
        {
            password.Append("5");
        }

        private void system_six_button_click(object sender, EventArgs e)
        {
            password.Append("6");
        }

        private void system_seven_button_click(object sender, EventArgs e)
        {
            password.Append("7");
        }

        private void system_eight_button_click(object sender, EventArgs e)
        {
            password.Append("8");
        }

        private void system_nine_button_click(object sender, EventArgs e)
        {
            password.Append("9");
        }

        private void system_zero_button_click(object sender, EventArgs e)
        {
            password.Append("0");
        }
    }
}
