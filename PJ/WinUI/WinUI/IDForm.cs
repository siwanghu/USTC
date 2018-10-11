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
using System.Threading;

namespace WinUI
{
    public partial class IDForm : Form
    {
        private FaceSynCom faceSynCom = null;
        private ConfigureXml configureXml = null;
        private enum State {IDCARD,BANKCARD,COMMIT }
        private string name="";
        private string sex="";
        private string nation="";
        private string birth="";
        private string address="";
        private string id="";
        private string picture="";
        private string organization="";
        private string time="";
        private string bank_account="";
        string currentDirectory = "";
        Image image = null;
        private State flag = State.IDCARD;

        public IDForm()
        {
            InitializeComponent();
            configureXml = ConfigureXml.getInstance();
            faceSynCom = new FaceSynCom();
            currentDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
        }

        private void IDForm_time_tick(object sender, EventArgs e)
        {
            this.IDForm_time_label.Text = DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss");
        }

        private void transparent()
        {
            this.IDForm_control_panel.Parent = this.IDForm_background_pictureBox;
            this.IDForm_time_label.Parent = this.IDForm_background_pictureBox;
            this.IDForm_name_label.Parent = this.IDForm_control_panel;
            this.IDForm_name_textBox.Parent= this.IDForm_control_panel;
            this.IDForm_sex_label.Parent= this.IDForm_control_panel;
            this.IDForm_sex_textBox.Parent= this.IDForm_control_panel;
            this.IDForm_nation_label.Parent= this.IDForm_control_panel;
            this.IDForm_nation_textBox.Parent= this.IDForm_control_panel;
            this.IDForm_birth_label.Parent= this.IDForm_control_panel;
            this.IDForm_birth_textBox.Parent = this.IDForm_control_panel;
            this.IDForm_address_label.Parent = this.IDForm_control_panel;
            this.IDForm_address_textBox.Parent = this.IDForm_control_panel;
            this.IDForm_ID_label.Parent = this.IDForm_control_panel;
            this.IDForm_ID_textBox.Parent = this.IDForm_control_panel;
            this.IDForm_pictureBox.Parent = this.IDForm_control_panel;
            this.IDForm_times_label.Parent = this.IDForm_control_panel;
            this.IDForm_time_textBox.Parent = this.IDForm_control_panel;
            this.IDForm_organization_label.Parent = this.IDForm_control_panel;
            this.IDForm_organization_textBox.Parent = this.IDForm_control_panel;
        }

        private void IDForm_load(object sender, EventArgs e)
        { 
            flag = State.IDCARD;
            //flag = State.COMMIT;
            transparent();
            mainForm_configure();
            faceSynCom.openDevie();
        }
        
        private void mainForm_configure()
        {
            string path = configureXml.getUIForm_Background();
            string control_path = configureXml.getUIForm_Control_Background();
            if (path != "" && control_path != "")
            {
                this.IDForm_background_pictureBox.Image = new Bitmap(path);                     
                this.IDForm_ok_button.Image = new Bitmap(control_path);
                this.IDForm_next_button.Image = new Bitmap(control_path);
            }
        }

        private void IDForm_next_button_click(object sender, EventArgs e)
        {
            if(IDForm_next_button.Text.Equals("下一步"))
            {
                flag = State.BANKCARD;
                this.IDForm_name_label.Visible = false;
                this.IDForm_name_textBox.Visible = false;
                this.IDForm_sex_label.Visible = false;
                this.IDForm_sex_textBox.Visible = false;
                this.IDForm_nation_label.Visible = false;
                this.IDForm_nation_textBox.Visible = false;
                this.IDForm_birth_label.Visible = false;
                this.IDForm_birth_textBox.Visible = true;
                this.IDForm_address_label.Visible = false;
                this.IDForm_address_textBox.Visible = false;
                this.IDForm_ID_label.Visible = false;
                this.IDForm_ID_textBox.Visible = false;
                this.IDForm_pictureBox.Visible = false;
                this.IDForm_times_label.Visible = false;
                this.IDForm_time_textBox.Visible = false;
                this.IDForm_organization_label.Visible = false;
                this.IDForm_organization_textBox.Visible = false;
                this.IDForm_pictureBox.Visible = false;

                IDForm_name_textBox.Text = "";
                IDForm_sex_textBox.Text = "";
                IDForm_nation_textBox.Text = "";
                IDForm_birth_textBox.Text = "";
                IDForm_address_textBox.Text = "";
                IDForm_ID_textBox.Text = "";
                IDForm_organization_textBox.Text = "";
                IDForm_time_textBox.Text = "";
                IDForm_pictureBox.Image = null;

                this.IDForm_birth_label.Visible = true;
                this.IDForm_birth_label.Text = "卡号";
                this.IDForm_next_button.Text = "上一步";
                this.IDForm_ok_button.Text = "确认";
                flag = State.BANKCARD;
                return;
            }
            if(IDForm_next_button.Text.Equals("上一步"))
            {
                flag = State.IDCARD;
                this.IDForm_name_label.Visible = true;
                this.IDForm_name_textBox.Visible = true;
                this.IDForm_sex_label.Visible = true;
                this.IDForm_sex_textBox.Visible = true;
                this.IDForm_nation_label.Visible = true;
                this.IDForm_nation_textBox.Visible = true;
                this.IDForm_birth_label.Visible = true;
                this.IDForm_birth_textBox.Visible = true;
                this.IDForm_address_label.Visible = true;
                this.IDForm_address_textBox.Visible = true;
                this.IDForm_ID_label.Visible = true;
                this.IDForm_ID_textBox.Visible = true;
                this.IDForm_pictureBox.Visible = true;
                this.IDForm_times_label.Visible = true;
                this.IDForm_time_textBox.Visible = true;
                this.IDForm_organization_label.Visible = true;
                this.IDForm_organization_textBox.Visible = true;
                this.IDForm_pictureBox.Visible = true;

                this.IDForm_birth_label.Visible = true;
                this.IDForm_birth_textBox.Text = "";
                this.IDForm_birth_label.Text = "出生";
                this.IDForm_next_button.Text = "下一步";
                this.IDForm_ok_button.Text = "确认";
                flag = State.IDCARD;
                return;
            }
        }

        private void IDForm_ok_button_click(object sender, EventArgs e)
        {
            switch(flag)
            {
                case State.IDCARD:
                    try
                    {                       
                        String[] infos=faceSynCom.getIdCardInfo();
                        name = infos[0];
                        sex = infos[1];
                        nation = infos[2];
                        birth = infos[3];
                        address = infos[4];
                        id = infos[5];
                        organization = infos[6];
                        time = infos[7] + "-" + infos[8];        
                        image = Image.FromFile(currentDirectory + "zp.bmp");
                        picture = currentDirectory + "zp.bmp";
                        IDForm_name_textBox.Text = name;
                        IDForm_sex_textBox.Text = sex;
                        IDForm_nation_textBox.Text = nation;
                        IDForm_birth_textBox.Text = birth.Insert(4, "年").Insert(7, "月") + "日";
                        IDForm_address_textBox.Text = address;
                        IDForm_ID_textBox.Text = id;
                        IDForm_organization_textBox.Text = organization;
                        IDForm_time_textBox.Text = time.Insert(4,"年").Insert(7,"月").Insert(10,"日")
                            .Insert(16,"年").Insert(19,"月")+"日";
                        IDForm_pictureBox.Image = image;
                        this.IDForm_ok_button.Text = "提交";
                        flag = State.COMMIT;
                    }
                    catch
                    {
                        MessageBox.Show("身份证信息读取失败！", "提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        flag = State.IDCARD;
                        this.IDForm_ok_button.Text = "确认";
                    }
                    break;
                case State.BANKCARD:
                    try
                    {                       
                        string[] info = faceSynCom.getBankCardInfo();
                        bank_account = info[0];
                        IDForm_birth_textBox.Text = bank_account;
                        flag = State.COMMIT;
                        this.IDForm_ok_button.Text = "提交";
                    }
                    catch
                    {
                        MessageBox.Show("银行卡信息读取失败！", "提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        flag = State.BANKCARD;
                        this.IDForm_ok_button.Text = "确认";
                    }               
                    break;
                case State.COMMIT:
                    this.Hide();
                    faceSynCom.closeDevice();
                    new TicketForm(name,sex,nation,birth,address,id,picture,organization,time,bank_account).Show();                   
                    break;
            }
        }    

        private void IDForm_MouseDown_Double_click(object sender, MouseEventArgs e)
        {
            faceSynCom.closeDevice();
            this.Hide();
            new MainForm().Show();
        }
    }
}
