using System;
using System.Text.Json;

namespace DoFactory.Memento.Character
{
    /// <summary>
    /// The Originator class creates a memento containing a snapshot of its current internal state
    /// Uses the Memento to restore its internal state
    /// </summary>
    public class Character
    {
        private string name;
        private int level;
        private string weapon;

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public string Weapon { get => weapon; set => weapon = value; }

        /// <summary>
        /// Stores (serializes) memento
        /// </summary>
        /// <returns></returns>
        public Memento SaveState()
        {
            var memento = new Memento();
            return memento.Serialize(this);
        }

        public void RestoreMemento(Memento m)
        {
            var character = (Character)m.Deserialize();
            this.name = character.name;
            this.level = character.level;
            this.weapon = character.weapon;
        }
    }
}
