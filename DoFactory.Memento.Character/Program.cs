using System;

namespace DoFactory.Memento.Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character()
            {
                Level = 75,
                Name = "Qui-din",
                Weapon = "Lightsaber"
            };

            // store internal state
            var state = new CharacterMemory();
            state.Memento = character.SaveState();

            // change originator
            character.Name = "donttellmetheodds";
            character.Level = 50;
            character.Weapon = "blaster";

            // restore saved state
            character.RestoreMemento(state.Memento);

            Console.ReadKey();
        }
    }
}
