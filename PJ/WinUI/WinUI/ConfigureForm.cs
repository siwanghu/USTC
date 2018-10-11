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
    public partial class ConfigureForm : Form
    {
        private ConfigureXml configureXml = null;
        private UIForm uiForm = new UIForm();
        private ScreenForm screenForm = new ScreenForm();
        private VipForm vipForm = new VipForm();
        private PrintForm printForm = new PrintForm();
        private LanguageForm languageForm = new LanguageForm();
        private PasswordForm passwordForm = new PasswordForm();
        private HelpForm helpForm = new HelpForm();

        public ConfigureForm()
        {
            InitializeComponent();
            configureXml = ConfigureXml.getInstance();
        }

        private void configureForm_load(object sender, EventArgs e)
        {
            uiForm.TopLevel = false;
            uiForm.Parent = this.configureForm_form_panel;
            uiForm.Dock = DockStyle.Fill;
            uiForm.Show();
        }

        private void system_ui_button_click(object sender, EventArgs e)
        {
            screenForm.Hide();
            vipForm.Hide();
            printForm.Hide();
            languageForm.Hide();
            passwordForm.Hide();
            helpForm.Hide();
            uiForm.TopLevel = false;
            uiForm.Parent = this.configureForm_form_panel;
            uiForm.Dock = DockStyle.Fill;
            uiForm.Show();
        }

        private void system_screen_button_click(object sender, EventArgs e)
        {
            uiForm.Hide();
            vipForm.Hide();
            printForm.Hide();
            languageForm.Hide();
            passwordForm.Hide();
            helpForm.Hide();
            screenForm.TopLevel = false;
            screenForm.Parent = this.configureForm_form_panel;
            screenForm.Dock = DockStyle.Fill;
            screenForm.Show();
        }

        private void system_vip_button_click(object sender, EventArgs e)
        {
            uiForm.Hide();
            screenForm.Hide();
            printForm.Hide();
            languageForm.Hide();
            passwordForm.Hide();
            helpForm.Hide();
            vipForm.TopLevel = false;
            vipForm.Parent = this.configureForm_form_panel;
            vipForm.Dock = DockStyle.Fill;
            vipForm.Show();
        }

        private void system_print_button_click(object sender, EventArgs e)
        {
            uiForm.Hide();
            screenForm.Hide();
            vipForm.Hide();
            languageForm.Hide();
            passwordForm.Hide();
            helpForm.Hide();
            printForm.TopLevel = false;
            printForm.Parent = this.configureForm_form_panel;
            printForm.Dock = DockStyle.Fill;
            printForm.Show();
        }

        private void system_language_button_click(object sender, EventArgs e)
        {
            uiForm.Hide();
            screenForm.Hide();
            vipForm.Hide();
            printForm.Hide();
            passwordForm.Hide();
            helpForm.Hide();
            languageForm.TopLevel = false;
            languageForm.Parent = this.configureForm_form_panel;
            languageForm.Dock = DockStyle.Fill;
            languageForm.Show();
        }

        private void system_password_button_click(object sender, EventArgs e)
        {
            uiForm.Hide();
            screenForm.Hide();
            vipForm.Hide();
            printForm.Hide();
            languageForm.Hide();
            helpForm.Hide();
            passwordForm.TopLevel = false;
            passwordForm.Parent = this.configureForm_form_panel;
            passwordForm.Dock = DockStyle.Fill;
            passwordForm.Show();
        }

        private void system_help_button_click(object sender, EventArgs e)
        {
            this.Hide();
            int userForm = int.Parse(configureXml.getUIForm());
            switch(userForm)
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
    }
}
