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
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace WinUI
{
    class SerialPortCom
    {
        private SerialPort serialPort;
        private string port;
        private int baudrate;
        private Parity parity;
        private int databits;
        private StopBits stopbits;
        private bool read_again;
        private Thread thread;
        private List<string> buffer;
        private CallBack callback;

        public SerialPortCom()
        {
            serialPort = new SerialPort();
        }

        private void readSerialPort()
        {
            while (read_again)
            {
                byte[] data = new byte[1];
                try
                {
                    serialPort.Read(data, 0, data.Length);
                    buffer.Add(data[0].ToString("X2"));
                    Console.Out.WriteLine(data[0].ToString("X2"));
                    if (data[0].ToString("X2").Equals("16"))
                    {
                        callback.callback(buffer);
                        buffer.Clear();
                    }
                }
                catch (TimeoutException)
                {
                    Console.WriteLine("超时错误!");
                }
            }
        }

        public void openSerialPort()
        {
            serialPort.PortName = port;
            serialPort.BaudRate = baudrate;
            serialPort.Parity = parity;
            serialPort.DataBits = databits;
            serialPort.StopBits = stopbits;
            buffer = new List<string>();
            serialPort.Open();
        }

        public void receiveSerialData(CallBack callback)
        {
            this.callback = callback;
            read_again = true;
            thread = new Thread(readSerialPort);
            thread.Start();
        }

        public void callPager(byte id)
        {
            byte[] data = new byte[] { 255, 104, 2, 2, 104, id, 3, 4, 22 };
            serialPort.Write(data, 0, data.Length);
        }

        public void stopReceiveSerialData()
        {
            read_again = false;
        }

        public void closeSerialPort()
        {
            read_again = false;           
            serialPort.Close();
            thread.Abort();
        }

        public string Port
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
            }
        }

        public int Baudrate
        {
            get
            {
                return baudrate;
            }
            set
            {
                baudrate = value;
            }
        }

        public Parity Parity
        {
            get
            {
                return parity;
            }
            set
            {
                parity = value;
            }
        }

        public int Databits
        {
            get
            {
                return databits;
            }
            set
            {
                databits = value;
            }
        }

        public StopBits Stopbits
        {
            get
            {
                return stopbits;
            }
            set
            {
                stopbits = value;
            }
        }
    }
}
