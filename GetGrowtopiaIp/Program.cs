using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GetGrowtopiaIp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Get Growtopia IP/Port by Ninjego/Hergon";

            WebClient client = new WebClient();
            string FullString = client.DownloadString("http://www.growtopia2.com/growtopia/server_data.php");
            string[] stringarg = FullString.Split('|');
            string[] splitiparg = stringarg[1].Split('\n');
            Console.WriteLine(splitiparg[0]);
            string[] splitportarg = stringarg[2].Split('\n');
            Console.WriteLine(splitportarg[0]);
            Thread.Sleep(-1);
        }
    }
}
