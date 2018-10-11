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
    class GeneralRecord
    {
        private string bank_name;
        private bool customer_type;
        private string business_name;
        private int queue_number;
        private DateTime date;

        public GeneralRecord()
        {
            this.Bank_name = "未命名";
            this.Customer_type = false;
            this.Business_name = "未命名";
            this.Queue_number = 0;
            this.Date = DateTime.Today;
        }

        public GeneralRecord(string bank_name,bool customer_type,
            string business_name,int queue_number,DateTime date)
        {
            this.Bank_name = bank_name;
            this.Customer_type = customer_type;
            this.Business_name = business_name;
            this.Queue_number = queue_number;
            this.Date = date;
        }

        public string Bank_name
        {
            get
            {
                return bank_name;
            }

            set
            {
                bank_name = value;
            }
        }

        public bool Customer_type
        {
            get
            {
                return customer_type;
            }

            set
            {
                customer_type = value;
            }
        }

        public string Business_name
        {
            get
            {
                return business_name;
            }

            set
            {
                business_name = value;
            }
        }

        public int Queue_number
        {
            get
            {
                return queue_number;
            }

            set
            {
                queue_number = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
    }
}
