/***********************************************************
* 版本: V1.0
* 创建人：胡思旺
* 创建时间：2017年9月20日 
* 版权所有:胡思旺
* 说明：未经作者同意不得用于商业用途
* 联系方式:siwanghu@hotmail.com
************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    class UserFormThree_CallBack : CallBack
    {
        private BusinessQueue businessQueue_one = null;
        private BusinessQueue businessQueue_two = null;
        private BusinessQueue businessQueue_three = null;
        private BusinessQueue businessQueue_four = null;
        private BusinessQueue businessQueue_five = null;
        private BusinessQueue businessQueue_six = null;
        private Hashtable hashTable = null;
        private Screen screen = null;

        public UserFormThree_CallBack(BusinessQueue businessQueue_one, BusinessQueue businessQueue_two
            , BusinessQueue businessQueue_three, BusinessQueue businessQueue_four, BusinessQueue businessQueue_five, BusinessQueue businessQueue_six)
        {
            this.businessQueue_one = businessQueue_one;
            this.businessQueue_two = businessQueue_two;
            this.businessQueue_three = businessQueue_three;
            this.businessQueue_four = businessQueue_four;
            this.businessQueue_five = businessQueue_five;
            this.businessQueue_six = businessQueue_six;
            hashTable = ConfigureXml.getInstance().getDeviceMapping();
            screen = new Screen(Int32.Parse(ConfigureXml.getInstance().getHardWareOfScreener()), 9600);
        }

        private string getDeviceName(List<string> buffer)
        {
            int a = Convert.ToInt32(buffer[5], 16);
            return (string)hashTable[Convert.ToInt32(buffer[5], 16).ToString()];
        }

        void CallBack.callback(List<string> buffer)
        {
            GeneralRecord record;
            bool[] languages = ConfigureXml.getInstance().getLanguageForm_languages();
            string businessQueue_one_name = businessQueue_one.getBusinessQueueName();
            string businessQueue_two_name = businessQueue_two.getBusinessQueueName();
            string businessQueue_three_name = businessQueue_three.getBusinessQueueName();
            string businessQueue_four_name = businessQueue_four.getBusinessQueueName();
            string businessQueue_five_name = businessQueue_three.getBusinessQueueName();
            string businessQueue_six_name = businessQueue_four.getBusinessQueueName();
            if (businessQueue_one_name.Equals(getDeviceName(buffer)))
            {
                record = businessQueue_one.DeBusinessQueue();
                if (record != null)
                {
                    screen.send_Text(Convert.ToInt32(buffer[5], 16), "请" + record.Queue_number + "号到" + Convert.ToInt32(buffer[5], 16) + "号柜台");
                    if (languages[0])
                    {
                        Speech.getInstance().speechText("请" + LanguageTool.getInstance().
                            parseInt(record.Queue_number) + "号到" + Convert.ToInt32(buffer[5], 16) + "号柜台办理业务");
                    }
                    if (languages[1])
                    {
                        Speech.getInstance().speechText("please " + LanguageTool.getInstance().
                            parseEnglish(record.Queue_number) + "to the " + LanguageTool.getInstance().intToenglish(Convert.ToInt32(buffer[5], 16)) + " window");
                    }
                }
                else
                {
                    Speech.getInstance().speechText(businessQueue_one_name + "暂时无人排队");
                }
            }
            if (businessQueue_two_name.Equals(getDeviceName(buffer)))
            {
                record = businessQueue_two.DeBusinessQueue();
                if (record != null)
                {
                    screen.send_Text(Convert.ToInt32(buffer[5], 16), "请" + record.Queue_number + "号到" + Convert.ToInt32(buffer[5], 16) + "号柜台");
                    if (languages[0])
                    {
                        Speech.getInstance().speechText("请" + LanguageTool.getInstance().
                            parseInt(record.Queue_number) + "号到" + Convert.ToInt32(buffer[5], 16) + "号柜台办理业务");
                    }
                    if (languages[1])
                    {
                        Speech.getInstance().speechText("please " + LanguageTool.getInstance().
                            parseEnglish(record.Queue_number) + "to the " + LanguageTool.getInstance().intToenglish(Convert.ToInt32(buffer[5], 16)) + " window");
                    }
                }
                else
                {
                    Speech.getInstance().speechText(businessQueue_two_name + "暂时无人排队");
                }
            }
            if (businessQueue_three_name.Equals(getDeviceName(buffer)))
            {
                record = businessQueue_three.DeBusinessQueue();
                if (record != null)
                {
                    screen.send_Text(Convert.ToInt32(buffer[5], 16), "请" + record.Queue_number + "号到" + Convert.ToInt32(buffer[5], 16) + "号柜台");
                    if (languages[0])
                    {
                        Speech.getInstance().speechText("请" + LanguageTool.getInstance().
                            parseInt(record.Queue_number) + "号到" + Convert.ToInt32(buffer[5], 16) + "号柜台办理业务");
                    }
                    if (languages[1])
                    {
                        Speech.getInstance().speechText("please " + LanguageTool.getInstance().
                            parseEnglish(record.Queue_number) + "to the " + LanguageTool.getInstance().intToenglish(Convert.ToInt32(buffer[5], 16)) + " window");
                    }
                }
                else
                {
                    Speech.getInstance().speechText(businessQueue_three_name + "暂时无人排队");
                }
            }
            if (businessQueue_four_name.Equals(getDeviceName(buffer)))
            {
                record = businessQueue_four.DeBusinessQueue();
                if (record != null)
                {
                    screen.send_Text(Convert.ToInt32(buffer[5], 16), "请" + record.Queue_number + "号到" + Convert.ToInt32(buffer[5], 16) + "号柜台");
                    if (languages[0])
                    {
                        Speech.getInstance().speechText("请" + LanguageTool.getInstance().
                            parseInt(record.Queue_number) + "号到" + Convert.ToInt32(buffer[5], 16) + "号柜台办理业务");
                    }
                    if (languages[1])
                    {
                        Speech.getInstance().speechText("please " + LanguageTool.getInstance().
                            parseEnglish(record.Queue_number) + "to the " + LanguageTool.getInstance().intToenglish(Convert.ToInt32(buffer[5], 16)) + " window");
                    }
                }
                else
                {
                    Speech.getInstance().speechText(businessQueue_four_name + "暂时无人排队");
                }
            }
            if (businessQueue_five_name.Equals(getDeviceName(buffer)))
            {
                record = businessQueue_five.DeBusinessQueue();
                if (record != null)
                {
                    screen.send_Text(Convert.ToInt32(buffer[5], 16), "请" + record.Queue_number + "号到" + Convert.ToInt32(buffer[5], 16) + "号柜台");
                    if (languages[0])
                    {
                        Speech.getInstance().speechText("请" + LanguageTool.getInstance().
                            parseInt(record.Queue_number) + "号到" + Convert.ToInt32(buffer[5], 16) + "号柜台办理业务");
                    }
                    if (languages[1])
                    {
                        Speech.getInstance().speechText("please " + LanguageTool.getInstance().
                            parseEnglish(record.Queue_number) + "to the " + LanguageTool.getInstance().intToenglish(Convert.ToInt32(buffer[5], 16)) + " window");
                    }
                }
                else
                {
                    Speech.getInstance().speechText(businessQueue_four_name + "暂时无人排队");
                }
            }
            if (businessQueue_six_name.Equals(getDeviceName(buffer)))
            {
                record = businessQueue_six.DeBusinessQueue();
                if (record != null)
                {
                    screen.send_Text(Convert.ToInt32(buffer[5], 16), "请" + record.Queue_number + "号到" + Convert.ToInt32(buffer[5], 16) + "号柜台");
                    if (languages[0])
                    {
                        Speech.getInstance().speechText("请" + LanguageTool.getInstance().
                            parseInt(record.Queue_number) + "号到" + Convert.ToInt32(buffer[5], 16) + "号柜台办理业务");
                    }
                    if (languages[1])
                    {
                        Speech.getInstance().speechText("please " + LanguageTool.getInstance().
                            parseEnglish(record.Queue_number) + "to the " + LanguageTool.getInstance().intToenglish(Convert.ToInt32(buffer[5], 16)) + " window");
                    }
                }
                else
                {
                    Speech.getInstance().speechText(businessQueue_four_name + "暂时无人排队");
                }
            }
        }
    }
}

