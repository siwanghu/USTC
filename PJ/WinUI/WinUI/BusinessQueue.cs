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
    class BusinessQueue
    {
        private string business_name;
        private Queue<GeneralRecord> business_queue;
        private Queue<GeneralRecord> business_vip_queue;
        private DataBase DB;

        public BusinessQueue(string business_name)
        {
            this.business_name = business_name;
            business_queue = new Queue<GeneralRecord>();
            business_vip_queue = new Queue<GeneralRecord>();
            DB = new DataBase();
            DB.openDB();
        }

        public void EnGeneralQueue(GeneralRecord record)
        {
            if(record.Queue_number>0)
            {
                business_queue.Enqueue(record);
            }
        }

        public GeneralRecord DeGeneralQueue()
        {
            if(business_queue.Count>0)
            {
                return business_queue.Dequeue();
            }
            else
            {
                throw new Exception("队列以为空！");
            }
        }

        public void EnVipQueue(GeneralRecord record)
        {
            if(record.Queue_number>0&&record.Customer_type==true)
            {
                business_vip_queue.Enqueue(record);
            }
        }

        public GeneralRecord DeVipQueue()
        {
            if(business_vip_queue.Count>0)
            {
                return business_vip_queue.Dequeue();
            }
            else
            {
                throw new Exception("队列以为空!");
            }
        }

        public void EnBusinessQueue(GeneralRecord record)
        {
            if(record.Queue_number>0)
            {
                if(record.Customer_type==true)
                {
                    this.EnVipQueue(record);
                }
                else
                {
                    this.EnGeneralQueue(record);
                }
            }
        }

        public GeneralRecord DeBusinessQueue()
        {
            if(business_vip_queue.Count>0)
            {
                GeneralRecord record= business_vip_queue.Dequeue();
                DB.deleteRecord(record.Customer_type,record.Business_name,record.Queue_number);
                return record;
            }
            else
            {
                if(business_queue.Count>0)
                {
                    GeneralRecord record = business_queue.Dequeue();
                    DB.deleteRecord(record.Customer_type, record.Business_name, record.Queue_number);
                    return record;
                }
                else
                {
                    return null;
                }
            }
        }

        public int getGeneralQueueCount()
        {
            return business_queue.Count;
        }

        public int getVipQueueCount()
        {
            return business_vip_queue.Count;
        }

        public string getBusinessQueueName()
        {
            return business_name;
        }
    }
}
