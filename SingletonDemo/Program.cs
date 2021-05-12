using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer b1 = LoadBalancer.getInstance();
            LoadBalancer b2 = LoadBalancer.getInstance();
            LoadBalancer b3 = LoadBalancer.getInstance();
            LoadBalancer b4 = LoadBalancer.getInstance();

            LoadBalancer balancer = LoadBalancer.getInstance();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }

        }
    }
}
