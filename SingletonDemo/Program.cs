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

            LoadBalancerDotNetOptimized b5 = LoadBalancerDotNetOptimized.getInstance();
            LoadBalancerDotNetOptimized b6 = LoadBalancerDotNetOptimized.getInstance();
            LoadBalancerDotNetOptimized b7 = LoadBalancerDotNetOptimized.getInstance();
            LoadBalancerDotNetOptimized b8 = LoadBalancerDotNetOptimized.getInstance();

            LoadBalancerDotNetOptimized _balancer = LoadBalancerDotNetOptimized.getInstance();
            for (int i = 0; i < 15; i++)
            {
                string server = _balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }

        }
    }
}
