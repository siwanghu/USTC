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
using System.Runtime.InteropServices;
using System.Threading;
using System.IO.Ports;
using System.IO;

namespace WinUI
{
    class Screen
    {
        [DllImport("Screen.dll", EntryPoint = "setShowMode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe int setShowMode(int showmode);

        [DllImport("Screen.dll", EntryPoint = "setShowTime", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe int setShowTime(int showtime);

        [DllImport("Screen.dll", EntryPoint = "setShowSpeed", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe int setShowSpeed(int showspeed);

        [DllImport("Screen.dll", EntryPoint = "initPort", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe int initPort(int serialPort, int baudrate, int showmode, int showtime, int showspeed);

        [DllImport("Screen.dll", EntryPoint = "openScreen", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe int openScreen(int address);

        [DllImport("Screen.dll", EntryPoint = "closeScreen", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe int closeScreen(int address);

        [DllImport("Screen.dll", EntryPoint = "sendText", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe int sendText(int address, string text);

        private int showmode;
        private int showspeed;
        private int showtime;

        public Screen(int serialPort, int baudrate)
        {
            showmode = 1;
            showtime = 1;
            showspeed = 3;
            initPort(serialPort, baudrate, showmode, showtime, showspeed);
        }

        public Screen(int serialPort, int baudrate, int showmode, int showtime, int showspeed)
        {
            initPort(serialPort, baudrate, showmode, showtime, showspeed);
        }

        public void initConfigure(int showmode, int showtime, int showspeed)
        {
            this.showtime = showtime;
            this.showmode = showmode;
            this.showspeed = showspeed;
            setShowMode(showmode);
            setShowTime(showtime);
            setShowSpeed(showspeed);
        }

        public void open_Screen(int address)
        {
            openScreen(address);
        }

        public void close_Screen(int address)
        {
            closeScreen(address);
        }

        public void send_Text(int address, string text)
        {
            sendText(address, text);
        }
    }
}
