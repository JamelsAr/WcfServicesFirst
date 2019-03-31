using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Service.Interface;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            //using(ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            //{
            //    //指定绑定和终结点的地址
            //    host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "http://127.0.0.1:3721/CalculatorService");
            //    //数据的发布
            //    if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
            //    {
            //        //创建服务行为
            //        ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            //        //是否发布元数据以便使用HTTPS/GET请求进行检索
            //        behavior.HttpGetEnabled = true;
            //        //使用HTTPS/GET请求的元数据发布的位置
            //        behavior.HttpGetUrl = new Uri("http://127.0.0.1:3721/CalculatorService/wcfapi");
            //        //添加到发布上
            //        host.Description.Behaviors.Add(behavior);
            //    }
            //    host.Opened += delegate
            //    {
            //        Console.WriteLine("CalculatorService已经启动,按任意键终止服务！");
            //    };
            //    //通讯状态转换到已打开
            //    host.Open();
            //    Console.ReadLine();
            //}

            using(ServiceHost host = new ServiceHost(typeof(CalculatorService))){
                //指定绑定终结点的地址
                host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "http://127.0.0.1:3721/CalculatorService");
                //数据的发布
                if(host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                {
                    //创建信息的发布对象
                    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                    //是否发布元数据以便使用HTTPS/GET请求进行检索
                    behavior.HttpGetEnabled = true;
                    //使用HTTPS/GET请求的元数据发布的位置
                    behavior.HttpGetUrl = new Uri("http://127.0.0.1:3721/CalculatorService/wcfapi");
                    //添加到发布服务上
                    host.Description.Behaviors.Add(behavior);

                }
                host.Opened += delegate
                {
                    Console.WriteLine("CalculatorService已经启动,按任意键终止服务！");
                };
                //通讯状态转换到已打开
                host.Open();
                Console.ReadLine();
            }
        }
    }
}
