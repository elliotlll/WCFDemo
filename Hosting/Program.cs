using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Contracts;
using Services;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(GetServerInfoService)))
            {
                host.AddServiceEndpoint(typeof(IGetServerInfo),new WSHttpBinding(),"http://127.0.0.1:9999/getserverinfoservice");
                if (host.Description.Behaviors.Find<System.ServiceModel.Description.ServiceMetadataBehavior>() == null)
                {
                    System.ServiceModel.Description.ServiceMetadataBehavior behavior = new System.ServiceModel.Description.ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;
                    behavior.HttpGetUrl = new Uri("http://127.0.0.1:9999/getserverinfoservice/metadata");
                    host.Description.Behaviors.Add(behavior);
                }
                host.Opened += delegate
                {
                    Console.WriteLine("GetServerInfoService 已经启动，按任意键结束服务！");
                };
                host.Open();

                Console.Read();
            }
        }
    }
}
