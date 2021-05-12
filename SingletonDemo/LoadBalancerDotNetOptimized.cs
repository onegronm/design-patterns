using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    /// <summary>
    /// The Singleton pattern simply uses a private constructor and a static readonly instance variable that is lazily initialized. Thread safety is guaranteed by the compiler.
    /// </summary>
    public sealed class LoadBalancerDotNetOptimized
    {
        /**
         * Static members are 'eagerly initialized', that is, immediately when class is loaded for the first time. .NET guarantees thread safety for static initialization.
         * If you have static members other than Instance, the first reference to those members will involve creating the instance. This can be corrected by accessing the instance through a nested class.
         * Even if the type is called by multiple threads at the same time, the static constructor is always executed one time.
         */
        private static readonly LoadBalancerDotNetOptimized uniqueInstance = new LoadBalancerDotNetOptimized();
        private List<string> servers = new List<string>();
        private Random random = new Random();

        // Note: constructor is private
        private LoadBalancerDotNetOptimized()
        {
            // List of available servers
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        public static LoadBalancerDotNetOptimized getInstance()
        {
            return uniqueInstance;
        }

        // random load balancer
        public string Server
        {
            get

            {
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }
    }
}
