using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCharacterDemo
{
    public class King : Character
    {
        public override void Fight()
        {
            weapon.useWeapon();
        }
    }
}
