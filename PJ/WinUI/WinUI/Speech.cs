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
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace WinUI
{
    class Speech
    {
        private int volume;
        private int rate;
        private static Speech speech = null;
        private SpeechSynthesizer synthesizer = null;

        private Speech()
        {
            Volume = 100;
            Rate = 1;
            synthesizer = new SpeechSynthesizer();
        }

        public static Speech getInstance()
        {
            if (speech == null)
            {
                speech = new Speech();
                return speech;
            }
            else
            {
                return speech;
            }
        }

        public void speechText(string text)
        {
            synthesizer.Speak(text);
        }

        public int Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
            }
        }

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }
    }
}
