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
    public partial class UIForm : Form
    {
        private bool flag_one = false;
        private bool flag_two = false;
        private bool flag_three = false;
        private ConfigureXml configureXml = null;

        public UIForm()
        {
            InitializeComponent();
            configureXml = ConfigureXml.getInstance();
        }

        private void selectUI_one()
        {
            flag_one = true;
            flag_two = false;
            flag_three = false;
            UIForm_label_one.Visible = true;
            UIForm_label_two.Visible = true;
            UIForm_label_three.Visible = true;
            UIForm_label_four.Visible = false;
            UIForm_label_five.Visible = false;
            UIForm_label_six.Visible = false;
            UIForm_textBox_one.Visible = true;
            UIForm_textBox_two.Visible = true;
            UIForm_textBox_three.Visible = true;
            UIForm_textBox_four.Visible = false;
            UIForm_textBox_five.Visible = false;
            UIForm_textBox_six.Visible = false;
        }

        private void selectUI_two()
        {
            flag_one = false;
            flag_two = true;
            flag_three = false;
            UIForm_label_one.Visible = true;
            UIForm_label_two.Visible = true;
            UIForm_label_three.Visible = true;
            UIForm_label_four.Visible = true;
            UIForm_label_five.Visible = false;
            UIForm_label_six.Visible = false;
            UIForm_textBox_one.Visible = true;
            UIForm_textBox_two.Visible = true;
            UIForm_textBox_three.Visible = true;
            UIForm_textBox_four.Visible = true;
            UIForm_textBox_five.Visible = false;
            UIForm_textBox_six.Visible = false;
        }

        private void selectUI_three()
        {
            flag_one = false;
            flag_two = false;
            flag_three = true;
            UIForm_label_one.Visible = true;
            UIForm_label_two.Visible = true;
            UIForm_label_three.Visible = true;
            UIForm_label_four.Visible = true;
            UIForm_label_five.Visible = true;
            UIForm_label_six.Visible = true;
            UIForm_textBox_one.Visible = true;
            UIForm_textBox_two.Visible = true;
            UIForm_textBox_three.Visible = true;
            UIForm_textBox_four.Visible = true;
            UIForm_textBox_five.Visible = true;
            UIForm_textBox_six.Visible = true;
        }

        private void uiForm_load(object sender, EventArgs e)
        {
            selectUI_one();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(UIForm_radioButton_one.Checked)
            {
                selectUI_one();
            }
            if(UIForm_radioButton_two.Checked)
            {
                selectUI_two();
            }
            if(UIForm_radioButton_three.Checked)
            {
                selectUI_three();
            }
        }

        private void system_control_button_click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = @"图片文件|*.jpg;*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.UIForm_control_textBox.Text = fileDialog.FileName;
            }
        }

        private void system_background_button_click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = @"图片文件|*.jpg;*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.UIForm_background_textBox.Text = fileDialog.FileName;
            }
        }

        private void system_save_button_click(object sender, EventArgs e)
        {
            if(flag_one)
            {
                configureXml.setUIForm("1");
                configureXml.setUIForm_Background(UIForm_background_textBox.Text);
                configureXml.setUIForm_Control_Background(UIForm_control_textBox.Text);
                configureXml.setUIForm_id_name(new string[] {UIForm_textBox_one.Text,
                    UIForm_textBox_two.Text,UIForm_textBox_three.Text});
            }
            if(flag_two)
            {
                configureXml.setUIForm("2");
                configureXml.setUIForm_Background(UIForm_background_textBox.Text);
                configureXml.setUIForm_Control_Background(UIForm_control_textBox.Text);
                configureXml.setUIForm_id_name(new string[] {UIForm_textBox_one.Text,
                    UIForm_textBox_two.Text,UIForm_textBox_three.Text,UIForm_textBox_four.Text});
            }
            if(flag_three)
            {
                configureXml.setUIForm("3");
                configureXml.setUIForm_Background(UIForm_background_textBox.Text);
                configureXml.setUIForm_Control_Background(UIForm_control_textBox.Text);
                configureXml.setUIForm_id_name(new string[] {UIForm_textBox_one.Text,
                    UIForm_textBox_two.Text,UIForm_textBox_three.Text,UIForm_textBox_four.Text,
                                    UIForm_textBox_five.Text,UIForm_textBox_six.Text});
            }
            MessageBox.Show("保存成功！", "提示框",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }
    }
}
