using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinUI
{
    class DataBase
    {
        private MySqlConnection sqlCon = null;
        private MySqlCommand sqlcmd = null;
        private string mysqlURL = null;
        private ConfigureXml configureXml = null;

        public DataBase()
        {
            this.mysqlURL = "";
            configureXml = ConfigureXml.getInstance();
            string[] DBconf = configureXml.getDatabaseConf();
            mysqlURL = String.Format("Database={0};Data Source={1};User Id={2};Password={3};pooling={4};CharSet={5};port={6}",
                DBconf[0], DBconf[1], DBconf[2], DBconf[3], DBconf[4], DBconf[5],DBconf[6]);
            //createDB();
        }

        private void createDB()
        {
            String sql = "create table client3(bankBranch varchar(25),customerType varchar(25),serviceType varchar(25),customerId int primary key auto_increment,currentTime datetime,queueId int);";
            if (openDB())
            {
                getSqlCommand(sql);
                int ret = sqlcmd.ExecuteNonQuery();
                if (ret > 0)
                {

                }
                closeDB();
            }
        }
       
        public bool openDB()
        {
            sqlCon = new MySqlConnection(mysqlURL);
            try
            {
                sqlCon.Open();
                return true;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        
        public bool closeDB()
        {
            try
            {
                sqlCon.Close();
                return true;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        private bool getSqlCommand(String sql)
        {
            sqlcmd = new MySqlCommand(sql, sqlCon);
            if (sqlcmd == null)
                return false;
            else
                return true;
        }

        
        private List<GeneralRecord> getResultset(String sql)
        {
            if (getSqlCommand(sql))
            {
                MySqlDataReader reader = sqlcmd.ExecuteReader();
                List<GeneralRecord> list = new List<GeneralRecord>();
                try
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            GeneralRecord client = new GeneralRecord();
                            client.Business_name = reader.GetString(1);
                            if (reader.GetString(2).Equals("True"))
                                client.Customer_type = true;
                            else
                                client.Customer_type = false;
                            client.Date = reader.GetDateTime(4);
                            client.Queue_number = reader.GetInt32(5);
                            list.Add(client);

                            Console.WriteLine("取号:" + reader.GetString(5) + "   客户类型:" + reader.GetString(1) + "   客户业务:" + reader.GetString(2) + "   时间:" + reader.GetString(4));
                        }
                    }
                }
                catch (Exception)
                {
                    throw new Exception("查询失败了!");
                }
                finally
                {
                    reader.Close();
                }
                return list;
            }
            else
            {
                throw new Exception("sql语句执行失败!");
            }
        }

        
        private GeneralRecord selectClient(List<GeneralRecord> list)
        {
            GeneralRecord client = new GeneralRecord();
            if (list.Count == 1)
            {
                client = list[0];
                list.RemoveAt(0);
            }
            else
            {
                client = list[0];
                int position = 0;
                for (int i = 0; i < list.Count; i++)
                {

                    if (client.Queue_number > list[i].Queue_number)
                    {
                        client = list[i];
                        position = i;
                    }
                }
                list.RemoveAt(position);
            }
            return client;
        }

        //按客户类型和客户业务查询
        public List<GeneralRecord> searchTable(String customerType, String serviceType)
        {
            String sqlSearch = "select * from client where customerType='" + customerType + "' and serviceType='" + serviceType + "'";
            List<GeneralRecord> list = getResultset(sqlSearch);

            //方案一：排序
            //int i, j;
            //client client;
            //for (i=0; i<list.Count; i++)
            //{
            //    client = list[i];
            //    for(j=i+1; j<list.Count; j++)
            //    {
            //        if(list[j].QueueId < client.QueueId)
            //        {
            //            list.Insert(i, list[j]);
            //            list.RemoveAt(j+1);
            //        }
            //    }

            //}

            //方案二
            List<GeneralRecord> list1 = new List<GeneralRecord>();
            GeneralRecord client;
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                client = selectClient(list);
                list1.Add(client);
            }

            //for (int i=0; i<list1.Count; i++)
            //{
            //    Console.WriteLine(list1[i].QueueId + list1[i].serviceType+list1[i].customerType+list1[i].currentTime);
            //}
            return list1;

        }

        
        public bool deleteTable()
        {
            DateTime currentTime = DateTime.Now;
            String sqlDelete = "delete from client where currentTime <'" + currentTime + "'";
            getSqlCommand(sqlDelete);
            int ret = sqlcmd.ExecuteNonQuery();
            if (ret > 0)
                return true;
            else
                return false;
        }
      
        public bool insertTable(bool customerType, String serviceType, Int32 QueueId)
        {
            String bankBranch = "中国银行";
            DateTime currentTime = DateTime.Now;
            String sqlSearch = "insert into client(bankBranch, customerType, serviceType, QueueId, currentTime) value('" + bankBranch + "','" + customerType + "','" + serviceType + "','" + QueueId + "','" + currentTime + "')";
            getSqlCommand(sqlSearch);
            int ret = sqlcmd.ExecuteNonQuery();
            if (ret > 0)
                return true;
            else
                return false;
        }

        public bool deleteRecord(bool customerType, String serviceType, Int32 QueueId)
        {
            String sqlSearch = "delete from client where customerType='"+customerType+"' and serviceType='"+serviceType+"' and QueueId='"+QueueId+"'";
            getSqlCommand(sqlSearch);
            int ret = sqlcmd.ExecuteNonQuery();
            if (ret > 0)
                return true;
            else
                return false;
        }

    }
}
