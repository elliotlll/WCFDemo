using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            GetServerInfoService.GetServerInfoClient client = new GetServerInfoService.GetServerInfoClient();
            string STime = client.GetServerTime();
            Console.WriteLine(STime);
            string SName = client.GetServerName();
            Console.WriteLine(SName);
            Console.Read();
        }
    }
}
