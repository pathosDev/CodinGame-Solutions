/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: orDer oF succeSsion          */
/* Difficulty: Easy                     */
/* Date solved: 05.03.2019              */
/*                                      */
/****************************************/

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static void Main()
    {
        //Read inputs.
        int n = int.Parse(Console.ReadLine());
        Royal royalLeader = ReadRoyal();

        for (int i = 0; i < n - 1; i++)
        {
            Royal royal = ReadRoyal();
            royalLeader.AddChild(royal);
        }

        //Traverse the complete tree.
        foreach (Royal royal in royalLeader.Traverse())
        {
            Console.WriteLine(royal.Name);
        }
    }

    private static Royal ReadRoyal()
    {
        string[] parts = Console.ReadLine().Split();
        return new Royal(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]);
    }

    //Represents a node in the tree.
    private class Royal
    {
        public string Name;
        public string Parent;
        public int Birth;
        public int Death;
        public string Religion;
        public bool IsFemale;

        private List<Royal> children;

        //Constructor.
        public Royal(string name, string parent, string birth, string death, string religion, string gender)
        {
            this.Name = name;
            this.Parent = parent;
            this.Birth = int.Parse(birth);
            this.Death = !death.Equals("-") ? int.Parse(death) : -1;
            this.Religion = religion;
            this.IsFemale = gender.Equals("F");

            this.children = new List<Royal>();
        }

        //Adds a child to the node or its subnodes.
        public void AddChild(Royal child)
        {
            if (child.Parent.Equals(this.Name))
            {
                this.children.Add(child);
            }
            else
            {
                foreach (Royal royal in this.children)
                {
                    royal.AddChild(child);
                }
            }
        }

        //Traverse the node and its subnodes with the rules given in the statement.
        public List<Royal> Traverse()
        {
            List<Royal> succession = new List<Royal>();

            //Exclude dead and catholic royals.
            if (this.Death == -1 && this.Religion.Equals("Anglican"))
            {
                succession.Add(this);
            }

            //Ordering rules.
            IOrderedEnumerable<Royal> sortedChildren = this.children.OrderBy(child => child.IsFemale).ThenBy(child => child.Birth);

            //Traverse subnodes.
            foreach (Royal child in sortedChildren)
            {
                succession.AddRange(child.Traverse());
            }

            return succession;
        }
    }
}