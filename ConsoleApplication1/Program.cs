using ConsoleApplication1.HelloServiceTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloServiceClient client = new HelloServiceClient();
            string str=client.sayHello("张三");
            Console.WriteLine(str);
            Console.Read();
        }
    }
}
