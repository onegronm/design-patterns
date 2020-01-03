namespace StrategyCharacterDemo
{
    public class Troll : Character
    {
        public override void Fight()
        {
            weapon.useWeapon();
        }
    }
}