using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Checking : Account
    {
        public Checking(string name, decimal initialDeposit)
            :base(name, initialDeposit)
        {

        }
    }
}
