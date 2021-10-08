using System;
using System.Collections.Generic;

namespace RefactoringGuru.Flyweight.Forest
{
    /// <summary>
    /// The Flyweight factory decides whether to re-use existing flyweight or to create a new object
    /// </summary>
    public class TreeFactory
    {
        // key: name, color, and texture
        private static Dictionary<Tuple<string, string, string>, TreeType> treeTypes = new Dictionary<Tuple<string, string, string>, TreeType>();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            var key = new Tuple<string, string, string>(name, color, texture);

            if (treeTypes.TryGetValue(key, out TreeType value))
            {
                return value;
            }
            else
            {
                var newTreeType = new TreeType(name, color, texture);
                treeTypes.Add(key, newTreeType);
                return newTreeType;
            }
        }
    }
}
