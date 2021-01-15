using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class IndividualAccount : Checking
    {
        public IndividualAccount(string name, decimal initialDeposit)
            :base(name, initialDeposit)
        {

        }
    }
}
