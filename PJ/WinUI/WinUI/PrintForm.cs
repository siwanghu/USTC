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
    public partial class PrintForm : Form
    {
        private ConfigureXml configureXml = null;

        public PrintForm()
        {
            InitializeComponent();
            configureXml = ConfigureXml.getInstance();
        }

        private void system_save_button_click(object sender, EventArgs e)
        {
            bool[] bools = {printForm_welcome_checkBox.Checked,printForm_number_checkBox.Checked,
                                printForm_queue_checkBox.Checked,printForm_time_checkBox.Checked};
            configureXml.setPrintForm_titles(bools);
            MessageBox.Show("保存成功！", "提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
