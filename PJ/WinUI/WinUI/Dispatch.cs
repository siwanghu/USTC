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
    class Dispatch
    {
        private BusinessQueue[] business_queues;

        public Dispatch(BusinessQueue[] business_queues)
        {
            this.business_queues = business_queues;
        }

        public GeneralRecord DispatchRecord(string business_name)
        {
            if (HasReservation())
            {
                DispatchReservation(business_name);
            }
            else
            {
                if (business_queues != null && business_queues.Length > 0)
                {
                    foreach (BusinessQueue business_queue in business_queues)
                    {
                        if (business_queue.getBusinessQueueName().Equals(business_name))
                        {
                            if (business_queue.getVipQueueCount() > 0)
                            {
                                return business_queue.DeVipQueue();
                            }
                            else
                            {
                                if (business_queue.getGeneralQueueCount() > 0)
                                {
                                    return business_queue.DeGeneralQueue();
                                }
                                else
                                {
                                    throw new Exception("队列为空！");
                                }
                            }
                        }
                    }
                    throw new Exception("不存在指定的" + business_name + "队列!");
                }
                else
                {
                    throw new Exception("不存在队列！");
                }
            }
            return null;
        }

        private bool HasReservation()
        {
            return false;
        }

        private GeneralRecord DispatchReservation(string business_name)
        {
            return new GeneralRecord();
        }
    }
}
