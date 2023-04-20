using System;

namespace ConsoleApp2
{
    internal class Program
    {
        class Branch
        {
            public List<Branch> branches = new();   //Need to add = new(); since it will throw a null error if it's not included.
        }

        static void Main(string[] args)
        {
            Branch root = new Branch();                             //Starting from this part, I created `Branch` objects and add child nodes into them.
            root.branches.Add(new Branch());                        //I replicated the structure of the figure provided in the assignment. It has a depth of 5.
            root.branches.Add(new Branch());

            root.branches[0].branches.Add(new Branch());
            root.branches[1].branches.Add(new Branch());
            root.branches[1].branches.Add(new Branch());
            root.branches[1].branches.Add(new Branch());
            root.branches[1].branches[0].branches.Add(new Branch());
            root.branches[1].branches[1].branches.Add(new Branch());
            root.branches[1].branches[1].branches.Add(new Branch());
            root.branches[1].branches[1].branches[0].branches.Add(new Branch());

            int depth = CalculateDepth(root);                   //Call the method I created and feed the structure into it.
            Console.WriteLine("Depth of structure: " + depth);  //Output the result.
        }

        static int CalculateDepth(Branch branch)    //The method for calculating depth of a `Branch`.
        {
            if (branch.branches.Count == 0)         //Checks if it has any child nodes.
            {
                return 1;
            }
            else
            {
                int maxDepth = 0;                                   //If it has, it loops through the branches list of the current Branch object,
                foreach (Branch subBranch in branch.branches)       //and calling CalculateDepth on each child node. It then takes the maximum depth of all the child nodes,
                {
                    int subDepth = CalculateDepth(subBranch);       //Recursion.
                    if (subDepth > maxDepth)
                    {
                        maxDepth = subDepth;
                    }
                }
                return maxDepth + 1;    //and add 1 for the current Branch object since it is zero-based.
            }
        }
    }
}
