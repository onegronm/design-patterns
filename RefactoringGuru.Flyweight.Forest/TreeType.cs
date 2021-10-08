using System;
namespace RefactoringGuru.Flyweight.Forest
{
    /// <summary>
    /// The Flyweight class contains the intrinsic (immutable) state of the tree
    /// Texture, name, and colors shared between many trees are here
    /// You would waste a lot of memory storing this information in each tree object
    /// We extract repeating data into a separate object which which lots of individual trees can reference
    /// </summary>
    public class TreeType
    {
        public string name { get; private set; }
        public string color { get; private set; }
        public string texture { get; private set; }

        public TreeType(string name, string color, string texture)
        {
            this.name = name;
            this.color = color;
            this.texture = texture;
        }

        public void draw(int x, int y)
        {
            Console.WriteLine($"Drawing tree on canvas on coordinate ({x},{y})");
        }
    }
}
