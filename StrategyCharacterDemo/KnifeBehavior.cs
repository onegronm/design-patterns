using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCharacterDemo
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("I just have a knife!");
        }
    }
}
