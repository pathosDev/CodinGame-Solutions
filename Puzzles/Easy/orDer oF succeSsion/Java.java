/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: orDer oF succeSsion          */
/* Difficulty: Easy                     */
/* Date solved: 05.03.2019              */
/*                                      */
/****************************************/

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.Scanner;

public class Solution
{
    private static Scanner scanner = new Scanner(System.in);
    
    public static void main(String[] args)
    {
        //Read inputs.
        int n = Integer.parseInt(scanner.nextLine());
        Royal royalLeader = readRoyal();
            
        for (int i = 0; i < n - 1; i++)
        {
            Royal royal = readRoyal();
            royalLeader.addChild(royal);
        }
        
        //Traverse the complete tree.
        for (Royal royal : royalLeader.traverse())
        {
            System.out.println(royal.name);
        }
    }
    
    private static Royal readRoyal()
    {
        String[] parts = scanner.nextLine().split(" ");
        return new Royal(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]);
    }
        
    //Represents a node in the tree.
    private static class Royal
    {
        public String name;
        public String parent;
        public int birth;
        public int death;
        public String religion;
        public boolean isFemale;
        
        private ArrayList<Royal> children;
        
        //Constructor.
        public Royal(String name, String parent, String birth, String death, String religion, String gender)
        {
            this.name = name;
            this.parent = parent;
            this.birth = Integer.parseInt(birth);
            this.death = !death.equals("-") ? Integer.parseInt(death) : -1;
            this.religion = religion;
            this.isFemale = gender.equals("F");
            
            this.children = new ArrayList<Royal>();
        }
        
        //Adds a child to the node or its subnodes.
        public void addChild(Royal child)
        {
            if (child.parent.equals(this.name))
            {
                this.children.add(child);
            }
            else
            {
                for (Royal royal : this.children)
                {
                    royal.addChild(child);
                }
            }
        }
        
        //Traverse the node and its subnodes with the rules given in the statement.
        public ArrayList<Royal> traverse()
        {
            ArrayList<Royal> succession = new ArrayList<Royal>();
            
            //Exclude dead and catholic royals.
            if (this.death == -1 && this.religion.equals("Anglican"))
            {
                succession.add(this);
            }
                
            //Ordering rules.

            Collections.sort(this.children, new Comparator()
            {
                public int compare(Object o1, Object o2) 
                {
                    Boolean x1 = ((Royal)o1).isFemale;
                    Boolean x2 = ((Royal)o2).isFemale;
                    
                    int comp = x1.compareTo(x2);
        
                    if (comp != 0) 
                    {
                       return comp;
                    } 
        
                    Integer x3 = ((Royal)o1).birth;
                    Integer x4 = ((Royal)o2).birth;
                    
                    return x3.compareTo(x4);
                }
            });
            
            //Traverse subnodes.
            for (Royal child : this.children)
            {
                succession.addAll(child.traverse());
            }
                
            return succession;
        }
    }
}