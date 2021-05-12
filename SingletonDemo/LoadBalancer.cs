using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    sealed class LoadBalancer
    {
        private static LoadBalancer uniqueInstance;
        private List<string> servers = new List<string>();
        private Random random = new Random();

        // lock synchronization object
        private static object syncLock = new object();

        // private constructor
        private LoadBalancer()
        {
            // List of available servers
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        public static LoadBalancer getInstance()
        {
            // support multithreaded applications through 'double checked locking' pattern
            // which avoids locking each time the method is invoked
            if(uniqueInstance == null)
            {
                lock (syncLock)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new LoadBalancer();
                    }
                }
            }

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
