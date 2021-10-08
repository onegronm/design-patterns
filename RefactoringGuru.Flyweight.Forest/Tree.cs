using System;
namespace RefactoringGuru.Flyweight.Forest
{
    /// <summary>
    /// The contextual object contains the extrinsic (mutable) part of the tree state
    /// An application can create billions of these since they are pretty small:
    /// just two integer coordinates and one reference field
    /// </summary>
    public class Tree
    {
        public int X { get; set; }
        public int Y { get; set; }
        public TreeType TreeType { get; set; }

        public Tree(int x, int y, TreeType treeType)
        {
            X = x;
            Y = y;
            TreeType = treeType;
        }

        public void Draw()
        {
            TreeType.draw(X, Y);
        }
    }
}
