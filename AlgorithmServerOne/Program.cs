using Common;
using System;
using System.ServiceModel;

namespace AlgorithmServerOne
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Compute)))
            {
                host.Open();
                Console.WriteLine("Server is running.......");
                Console.WriteLine("Type \"exit\" to shutdown");
                string input = "";
                while (input != "exit")
                {
                    input = Console.ReadLine();
                }
            }
        }
    }
}
