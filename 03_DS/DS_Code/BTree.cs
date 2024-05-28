using System;

namespace ProgrammingBasics_DS
{
    internal class BTreeNode
    {
        public BTreeNode(int value) { this.value = value; }
        public int value = 0;
        public BTreeNode Right=null, Left = null;
        
        public void Insert(int value, ref string Path)
        {
            if (value <= this.value)//Going Left
            {
                Path += "Left,";
                if (this.Left == null)
                {
                    if (Path.Length > 1)
                        Path = Path.Substring(0, Path.Length - 1);
                    this.Left = new BTreeNode(value);
                }
                else
                    this.Left.Insert(value, ref Path);

            }
            else//Going Right
            {
                Path += "Right,";
                if (this.Right == null)
                {
                    if (Path.Length > 1)
                        Path = Path.Substring(0, Path.Length - 1);
                    this.Right = new BTreeNode(value);
                }
                else
                    this.Right.Insert(value, ref Path);

            }
        }
        public BTreeNode Get(int value, ref string Path)
        {

            if (value == this.value)
            {
                if (Path.Length > 1)
                    Path = Path.Substring(0, Path.Length - 1);
                return this;
            }
            else if (value < this.value)//Going Left
            {
                if (this.Left == null)
                {
                    Path = "Not Found";
                    return null;
                }
                else
                {
                    Path += "Left,";
                    return this.Left.Get(value, ref Path);
                }
            }
            else//Going Right
            {
                if (this.Right == null)
                {
                    Path = "Not Found";
                    return null;
                }
                else
                {
                    Path += "Right,";
                    return this.Right.Get(value, ref Path);
                }
            }
        }
        /*
        public void Insert2(BTreeNode node)
        {
            BTreeNode Direction = null;
            if (node.value <= value)
                Direction = this.Left;
            else
                Direction = this.Right;
            
                if (Direction == null)
                    this.Right = new BTreeNode(node.value);
                else
                    this.Right.Insert(node);
            
        }*/
    }
    internal class BTree
    {
        public BTreeNode Root;
        //    public BTree() { }
        public void Insert(int value,ref string Path) {
            if (Root == null)
                Root = new BTreeNode(value);
            else
                Root.Insert(value,ref Path);
        }
        public void Remove(BTreeNode node) { }
        public BTreeNode Get(int value, ref string Path)
        {
            return Root.Get(value, ref Path);
        }
        public static void Main_BTree() {
            int[] vert = new int[] {8,6,5,7,12,10,11,1,0,2 };
            BTree t= new BTree();
            for (int i = 0; i < vert.Length; i++)
            {
                string Path = "Root,";
                t.Insert(vert[i],ref Path);
                Console.WriteLine($"Inserting item[{i + 1}]= {vert[i]} the Path is {Path}");
            }
            for (int i = vert.Length-1;i>=0 ; i--)
            {
                string Path = "Root,";
                t.Get(vert[i], ref Path);
                Console.WriteLine($"Getting item[{i + 1}]= {vert[i]} the Path is {Path}");
            }

        }    
    }
}
/* 
 * Educational Code
 * Dr. Amr Mausad @ 2024
 * http://amrmausad.com
 */