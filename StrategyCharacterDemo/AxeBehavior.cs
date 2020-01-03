using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCharacterDemo
{
    public class AxeBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Behold the Stormbreaker!");
        }
    }
}
