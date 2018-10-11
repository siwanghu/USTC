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
using System.Runtime.InteropServices;
using System.Threading;

namespace WinUI
{
    class FaceSynCom
    {
        [DllImport("Comminterface.dll")]
        public static extern int SS_OpenDevice(int nPort, int nBaud, StringBuilder vidpidOrblueToothName);

        [DllImport("Comminterface.dll")]
        public static extern int SS_CloseDevice();
    
        [DllImport("Comminterface.dll")]
        public static extern int SS_ID_GetIdCardInfo(StringBuilder idcard_info, int timeout);

        [DllImport("Comminterface.dll")]
        public static extern int SS_ICC_GetICCInfo(int ICtype, StringBuilder AIDList, StringBuilder tagList, StringBuilder infoBuf);

        public bool openDevie()
        {
            if (SS_OpenDevice(1001, 0, new StringBuilder("261A0011")) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool closeDevice()
        {
            if (SS_CloseDevice() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] getIdCardInfo()
        {
            try
            {
                string currentDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
                StringBuilder idInfo = new StringBuilder(1024 * 100);
                int flag = SS_ID_GetIdCardInfo(idInfo, 10);
                if ((flag != 0) && (flag != 1))
                {
                    throw new Exception("身份证读取失败!");
                }
                string information = idInfo.ToString();
                string[] informations = information.Split(new Char[] { '|' });
                Image image = Image.FromFile(currentDirectory + "zp.jpg");
                image.Dispose();
                return informations;
            }
            catch
            {
                throw new Exception("身份证读取失败!");
            }
        }

        public string[] getBankCardInfo()
        {
            try
            {
                StringBuilder AIDList = new StringBuilder(256);
                StringBuilder tagList = new StringBuilder(256);
                StringBuilder infoBuf = new StringBuilder(1024);

                tagList.Append("A");
                Thread.Sleep(2000);
                if (SS_ICC_GetICCInfo(1, AIDList, tagList, infoBuf) != 0)
                {
                    throw new Exception("银行卡信息读取失败");
                }
                string account = infoBuf.ToString();

                return new string[] { account.Remove(0,4) };
            }
            catch
            {
                throw new Exception("银行卡信息读取失败");
            }
        }
    }
}

