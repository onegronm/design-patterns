using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCharacterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Character king = new King();
            king.SetWeapon(new BowAndArrowBehavior());
            king.Fight();

            Character queen = new Queen();
            queen.SetWeapon(new KnifeBehavior());
            queen.Fight();

            Character knight = new Knight();
            knight.SetWeapon(new SwordBehavior());
            knight.Fight();

            Character troll = new Troll();
            troll.SetWeapon(new AxeBehavior());
            troll.Fight();

            Console.Read();
        }
    }
}
