using System;

namespace RefactoringGuru.Flyweight.Forest
{
    class Program
    {
        static void Main(string[] args)
        {
            var forest = new Forest();
            forest.plantTree(1, 2, "maple", "green", "thick");
            forest.plantTree(3, 4, "maple", "green", "thick");
            forest.plantTree(6, 7, "maple", "red", "thin");
            forest.plantTree(8, 9, "palm", "green", "spread");
            forest.draw();
        }
    }
}
