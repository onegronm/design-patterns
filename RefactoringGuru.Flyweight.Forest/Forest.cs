using System;
using System.Collections.Generic;

namespace RefactoringGuru.Flyweight.Forest
{
    /// <summary>
    /// This is the client
    /// </summary>
    public class Forest
    {
        private static List<Tree> trees = new List<Tree>();

        public void plantTree(int x, int y, string name, string color, string texture)
        {
            var treeType = TreeFactory.GetTreeType(name, color, texture);
            Tree tree = new Tree(x, y, treeType);
            trees.Add(tree);
        }

        public void draw()
        {
            foreach(var tree in trees)
            {
                tree.Draw();
            }
        }
    }
}
