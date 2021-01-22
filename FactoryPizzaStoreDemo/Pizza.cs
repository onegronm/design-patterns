using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizzaStoreDemo
{
    public abstract class Pizza : IPizza
    {
        public void bake()
        {
            throw new NotImplementedException();
        }

        public void box()
        {
            throw new NotImplementedException();
        }

        public void cut()
        {
            throw new NotImplementedException();
        }

        public void prepare()
        {
            throw new NotImplementedException();
        }
    }
}
