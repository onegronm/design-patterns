using System;
using System.IO;
using System.Text.Json;

namespace DoFactory.Memento.Character
{
    /// <summary>
    /// Stores internal state of the Originator object
    /// Protects against access by objects other than the originator
    /// Ideally, only originator has access to memento's internal state
    /// </summary>
    public class Memento
    {
        string state;

        public Memento Serialize(Object o)
        {
            state = JsonSerializer.Serialize(o);
            return this;
        }

        public object Deserialize()
        {
            object o = JsonSerializer.Deserialize(state, typeof(object));
            return o;
        }
    }
}
