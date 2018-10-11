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
using System.Text;
using System.Threading.Tasks;

namespace WinUI
{
    class LanguageTool
    {
        private string[] parse = { "零","一","二","三","四",
                                   "五","六","七","八","九", };
        private string[] english = { "zero","one","two","three","four",
                                   "five","six","seven","eight","nine", "Eleven"
                                    ,"Twelve","Thirteen","Fourteen","Fifteen",
                                    "Sixteen","Seventeen","Eighteen","Nineteen","Twenty" };

        private static LanguageTool languageTool = null;

        private LanguageTool() { }

        public static LanguageTool getInstance()
        {
            if(languageTool==null)
            {
                languageTool = new LanguageTool();
                return languageTool;
            }
            else
            {
                return languageTool;
            }
        }

        public string intToenglish(int id)
        {
            return english[id];
        }

        public string parseInt(int number)
        {
            string text = "";
            Stack<int> stack = new Stack<int>();
            while(number/10!=0)
            {
                stack.Push(number%10);
                number = number / 10;
            }
            stack.Push(number % 10);
            while(stack.Count>0)
            {
                text += parse[stack.Pop()];
            }
            return text;
        }

        public string parseEnglish(int number)
        {
            string text = "";
            Stack<int> stack = new Stack<int>();
            while (number / 10 != 0)
            {
                stack.Push(number % 10);
                number = number / 10;
            }
            stack.Push(number % 10);
            while (stack.Count > 0)
            {
                text += english[stack.Pop()]+" ";
            }
            return text;
        }
    }
}
