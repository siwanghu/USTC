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
    public partial class ScreenForm : Form
    {
        private ConfigureXml configureXml = null;

        public ScreenForm()
        {
            InitializeComponent();
            configureXml = ConfigureXml.getInstance();
        }

        private void system_background_button_click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = @"图片文件|*.jpg;*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.screenForm_background_textBox.Text = fileDialog.FileName;
            }
        }

        private void system_save_button_click(object sender, EventArgs e)
        {
            configureXml.setScreenForm_title(screenForm_name_textBox.Text);
            configureXml.setScreenForm_Background(screenForm_background_textBox.Text);
            MessageBox.Show("保存成功！", "提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
