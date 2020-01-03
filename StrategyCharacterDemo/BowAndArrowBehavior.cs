using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCharacterDemo
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("I am Robin Hood with my bow and arrow!");
        }
    }
}
