using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Interface;
using System.ServiceModel;

namespace ChannelClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //基于地址和绑定对象创建一个ChannelFactory<ICalculator>  通过代码
            //using (ChannelFactory<ICalculator> channelFactory = new ChannelFactory<ICalculator>(new WSHttpBinding(), "http://127.0.0.1:3721/CalculatorService"))
            //{
            //    //创建服务代理对象
            //    ICalculator proxy = channelFactory.CreateChannel();
            //    //调用计算器方法
            //    Console.WriteLine("x+y={2} when  x={0} and y={1}",1,2,proxy.Add(1,2));
            //    Console.WriteLine("x-y={2} when  x={0} and y={1}", 1, 2, proxy.Add(1, 2));
            //    Console.WriteLine("x*y={2} when  x={0} and y={1}", 1, 2, proxy.Add(1, 2));
            //    Console.WriteLine("x/y={2} when  x={0} and y={1}", 1, 2, proxy.Add(1, 2));

            //    Console.ReadLine();
            //}



            //基于地址和绑定对象创建一个ChannelFactory<ICalculator>   通过配置文件
            using (ChannelFactory<ICalculator> channelFactory = new ChannelFactory<ICalculator>("calculatorService"))
            {
                //创建服务代理对象
                ICalculator proxy = channelFactory.CreateChannel();
                //调用计算器方法
                Console.WriteLine("x+y={2} when  x={0} and y={1}", 1, 2, proxy.Add(1, 2));
                Console.WriteLine("x-y={2} when  x={0} and y={1}", 1, 2, proxy.Add(1, 2));
                Console.WriteLine("x*y={2} when  x={0} and y={1}", 1, 2, proxy.Add(1, 2));
                Console.WriteLine("x/y={2} when  x={0} and y={1}", 1, 2, proxy.Add(1, 2));

                Console.ReadLine();
            }
        }
    }
}
