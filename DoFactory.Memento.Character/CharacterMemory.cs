using System;
namespace DoFactory.Memento.Character
{
    /// <summary>
    /// The Caretaker class is responsible for the memento's safekeeping
    /// Never operates on or examines the contents of a memento
    /// </summary>
    public class CharacterMemory
    {
        public Memento Memento { get; set; }
    }
}
