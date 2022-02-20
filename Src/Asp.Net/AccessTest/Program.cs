﻿using System;

namespace OrmTest
{
    class Program
    {
        /// <summary>
        /// Set up config.cs file and start directly F5
        /// 设置Config.cs文件直接F5启动例子
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
 
            //Demo
            Demo0_SqlSugarClient.Init();
            Demo1_Queryable.Init();
            Demo2_Updateable.Init();
            Demo3_Insertable.Init();
            Demo4_Deleteable.Init();
            Demo5_SqlQueryable.Init();
            DemoN_SplitTable.Init();
            Demo6_Queue.Init();
            Demo7_Ado.Init();
            Demo8_Saveable.Init();
            Demo9_EntityMain.Init();
            DemoA_DbMain.Init();
            DemoB_Aop.Init();
            DemoC_GobalFilter.Init();
            DemoD_DbFirst.Init();;
            DemoE_CodeFirst.Init();
            DemoF_Utilities.Init();
            DemoG_SimpleClient.Init();
            DemoH_Tenant.Init();
            DemoJ_Report.Init();
            DemoL_Snowflake.Init();
            DemoM_UnitOfWork.Init();
             ;

            Console.WriteLine("all successfully.");
            Console.ReadKey();
        }

 
    }
}
