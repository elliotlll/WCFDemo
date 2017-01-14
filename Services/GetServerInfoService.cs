using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;

namespace Services
{
    public class GetServerInfoService:IGetServerInfo
    {
        public string GetServerTime()
        {
            return DateTime.Now.ToString();
        }

        public string GetServerName()
        {
            return "Server Name:Orchardcn";
        }
    }
}
