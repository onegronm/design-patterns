using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCharacterDemo
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("You shall die by the sword!");
        }
    }
}
