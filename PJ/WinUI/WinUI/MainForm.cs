/***********************************************************
* 版本: V1.0
* 创建人：胡思旺
* 创建时间：2017年10月20日 
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
    public partial class MainForm : Form
    {
        private ConfigureXml configureXml = null;

        public MainForm()
        {
            InitializeComponent();
            configureXml = ConfigureXml.getInstance();
        }

        private void MainForm_Queue_button_click(object sender, EventArgs e)
        {
            ConfigureXml configureXml = ConfigureXml.getInstance();
            int userForm = int.Parse(configureXml.getUIForm());
            switch (userForm)
            {
                case 1:
                    this.Hide();
                    new UserForm_one().Show();
                    break;
                case 2:
                    this.Hide();
                    new UserForm_two().Show();
                    break;
                case 3:
                    this.Hide();
                    new UserForm_three().Show();
                    break;
                default:
                    return;
            }
        }

        private void MainForm_load(object sender, EventArgs e)
        {
            transparent();
            mainForm_configure();
        }

        private void mainForm_configure()
        {
            string path = configureXml.getUIForm_Background();
            string control_path = configureXml.getUIForm_Control_Background();
            if (path != "" && control_path != "")
            {
                MainForm_background_pictureBox.Image = new Bitmap(path);
                MainForm_Queue_button.Image = new Bitmap(control_path);
                MainForm_Ticket_button.Image = new Bitmap(control_path);
            }
        }

        private void transparent()
        {
            this.MainForm_button_panel.Parent = this.MainForm_background_pictureBox;
            this.MainForm_time_label.Parent = this.MainForm_background_pictureBox;
        }

        private void MainForm_time_tick(object sender, EventArgs e)
        {
            this.MainForm_time_label.Text = DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss");
        }

        private void MainForm_Ticket_button_click(object sender, EventArgs e)
        {
            new IDForm().Show();
        }
    }
}
