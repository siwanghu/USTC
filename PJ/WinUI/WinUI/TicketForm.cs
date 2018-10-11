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
using System.Net;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace WinUI
{
    public partial class TicketForm : Form
    {
        private ConfigureXml configureXml = null;
        private string name = "";
        private string gender = "";
        private string nation = "";
        private string birth = "";
        private string address = "";
        private string id = "";
        private string picture = "";
        private string organization = "";
        private string time = "";
        private string bank_account = "";
        private string data = "";
        private Socket serverSocket = null;
        private static string isback = "";
        private Thread receiveThread=null;
        private System.Timers.Timer timer=null ;

        public TicketForm(string name, string sex, string nation, string birth, string address
            , string id, string picture, string organization, string time, string bank_account)
        {
            this.name = name;
            this.gender = sex;
            this.nation = nation;
            this.birth = birth;
            this.address = address;
            this.id = id;
            this.picture = picture;
            this.organization = organization;
            this.time = time;
            this.bank_account = bank_account;
            InitializeComponent();
            configureXml = ConfigureXml.getInstance();
        }

        private void TicketForm_load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(time_click);
            timer.AutoReset = true;
            timer.Enabled = true;
            Encoding myEncoding = Encoding.GetEncoding("UTF-8");
            string url = configureXml.getTomcatURL()+"?" + "name=" + HttpUtility.UrlEncode(name, myEncoding)+"&"+
                "gender=" + HttpUtility.UrlEncode(gender, myEncoding)+"&"+ "address=" + HttpUtility.UrlEncode(address, myEncoding)+"&"
                + "id=" + HttpUtility.UrlEncode(id, myEncoding) + "&" + "birth=" + HttpUtility.UrlEncode(birth, myEncoding) 
                + "&" + "time=" + HttpUtility.UrlEncode(time, myEncoding) + "&"+ "bank_account=" + HttpUtility.UrlEncode(bank_account, myEncoding);
            TicketForm_webBrowser.IsScriptingEnabled = true;  
            TicketForm_webBrowser.Navigate(url);
            Listener listener = new Listener(this,configureXml,serverSocket);         
            receiveThread = new Thread(new ThreadStart(listener.ReceiveMessage));
            receiveThread.Start();
        }

        private  void showMain()
        {
            isback = "";
            timer.Enabled = false;
        }

        private void time_click(object source, System.Timers.ElapsedEventArgs e)
        {
            if (isback.Equals("ok"))
            {
                this.Hide();
                this.showMain();               
            }
        }

        private class Listener
        {
            private TicketForm ticketForm;
            private ConfigureXml configureXml;
            private Socket serverSocket;

            public Listener(TicketForm ticketForm, ConfigureXml configureXml, Socket serverSocket)
            {
                this.ticketForm = ticketForm;
                this.configureXml = configureXml;
                this.serverSocket = serverSocket;
            }

            public void ReceiveMessage()
            {
                IPAddress ip = IPAddress.Parse(configureXml.getSocketIP());
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(ip, Int32.Parse(configureXml.getSocketPort())));
                serverSocket.Listen(0);
                Socket socket = serverSocket.Accept();
                byte[] buffer = new byte[1024 * 1024];
                int length = socket.Receive(buffer, buffer.Length, 0);
                isback = Encoding.UTF8.GetString(buffer, 0, length);
                socket.Close();
                serverSocket.Close();
            }          
        }

        private void Scroll_test(object sender, ScrollEventArgs e)
        {
            string txt=TicketForm_webBrowser.DocumentText;
            MessageBox.Show(txt);
        }
    }
}
