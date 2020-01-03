namespace StrategyCharacterDemo
{
    public class Knight : Character
    {
        public override void Fight()
        {
            weapon.useWeapon();
        }
    }
}