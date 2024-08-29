using System.Collections.Generic;
using System;

namespace BinartTreee
{
    internal class Program
    {//احمد هاني احمد الهادي عبدالكريم جمعه
        public static void MainMinMax()
        {
            BTree tree = new BTree();
            tree.Insert(5);
            tree.Insert(19);
            tree.Insert(2);
            tree.Insert(-40);
            tree.Insert(55);
            tree.Insert(90);
            tree.Insert(-11);
            tree.Insert(-8);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(12);
            tree.Insert(9);
            tree.Insert(23);
            tree.Print(5);

            bool max = false;
            if (max)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("by using max value from left");
                tree.DeleteMax(19);
                tree.Print(5);
            }
            else
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("by using min value from right");
                tree.DeleteMin(19);
                tree.Print(5);
            }
        }
    }
    public class BTreeNode
    {
        public int value;
        public BTreeNode Left, Right;

        public BTreeNode(int item)
        {
            value = item;
            Left = Right = null;
        }





        public BTreeNode Get(int value, ref string Path)
        {
            if (value == this.value)
            {
                if (Path.Length > 1)
                    Path = Path.Substring(0, Path.Length - 1);
                return this;
            }
            else if (value < this.value) //Going Left
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
            else //Going Right
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

        public void GetChildren(List<BTreeNode> ret)
        {
            if (Left != null)
            {
                ret.Add(Left);
                Left.GetChildren(ret);
            }

            if (Right != null)
            {
                ret.Add(Right);
                Right.GetChildren(ret);
            }
        }

        #region Print

        public string Suffix
        {
            get
            {
                if (Right != null && Left != null)
                    return " ──┤ ";
                else if (Right != null)
                    return " ──┘ ";
                else if (Left != null)
                    return " ──┐ ";
                else return "";
            }
        }

        #endregion


    }


    class BTree
    {
        public int Count = 0;
        BTreeNode Root;

        public void DeleteMin(int key)
        {
            Root = deleting_Min(Root, key);
            Count--;
        }
        private BTreeNode deleting_Max(BTreeNode root, int data)
        {
            if (root == null)
                return root;
            if (data < root.value)
                root.Left = deleting_Max(root.Left, data);
            else if (data > root.value)
                root.Right = deleting_Max(root.Right, data);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;
                root.value = MaxValue(root.Left);
                root.Left = deleting_Max(root.Left, root.value);
            }
            return root;
        }
        private int MaxValue(BTreeNode root)
        {
            int maxvalue = 0;
            while (root.Right != null)
            {
                maxvalue = root.Right.value;
                root = root.Right;
            }
            return maxvalue;
        }

        public void DeleteMax(int key)
        {
            Root = deleting_Max(Root, key);
            Count--;
        }
        private BTreeNode deleting_Min(BTreeNode root, int data)
        {
            if (root == null)
                return root;
            if (data < root.value)
                root.Left = deleting_Min(root.Left, data);
            else if (data > root.value)
                root.Right = deleting_Min(root.Right, data);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;
                root.value = MinValue(root.Right);
                root.Right = deleting_Min(root.Right, root.value);
            }
            return root;
        }
        private int MinValue(BTreeNode root)
        {
            int minvalue = 0;
            while (root.Left != null)
            {
                minvalue = root.Left.value;
                root = root.Left;
            }
            return minvalue;
        }


        public void Insert(int value)
        {
            Root = insertnode(value, Root);
            Count++;
        }
        private BTreeNode insertnode(int key, BTreeNode myroot)
        {
            if (myroot == null)
            {
                myroot = new BTreeNode(key);
                return myroot;
            }
            if (key < myroot.value)
            {
                myroot.Left = insertnode(key, myroot.Left);
            }
            else if (key > myroot.value)
            {
                myroot.Right = insertnode(key, myroot.Right);
            }
            return myroot;
        }



        public BTreeNode Get(int value, ref string Path)
        {
            return Root.Get(value, ref Path);
        }

        #region Print

        private void Print(BTreeNode node, int depth)
        {
            if (node == null)
            {
                return;
            }

            Print(node.Right, depth + 1);

            Console.WriteLine($"{new string(' ', depth * 4)}{node.value}");

            Print(node.Left, depth + 1);
        }

        private void Print2(BTreeNode node, int depth)
        {
            if (node == null)
            {
                return;
            }

            Print2(node.Right, depth + 1);

            // Print node value
            Console.Write(new string(' ', depth * 6));
            Console.WriteLine(node.value);

            // Print edge to the left child
            if (node.Left != null)
            {
                Console.Write(new string(' ', (depth + 1) * 6 - 2));
                Console.WriteLine("└──");
            }

            Print2(node.Left, depth + 1);
        }

        private void Print3(BTreeNode node, int depth)
        {
            if (node == null)
            {
                return;
            }

            Print3(node.Right, depth + 1);

            // Print node value with proper indentation
            Console.Write(new string(' ', depth * 6));
            Console.WriteLine(node.value);

            // Print edge to the left child, if it exists
            if (node.Left != null)
            {
                // Print proper indentation for the edge
                Console.Write(new string(' ', depth * 6));
                Console.Write("└── ");
                Print3(node.Left, depth + 1);
            }
            else if (node.Right != null)
            {
                // Print empty space for missing left child
                Console.Write(new string(' ', (depth + 1) * 6));
                Console.WriteLine();
            }
            else
            {
                // Print empty space if no child exists
                Console.WriteLine();
            }
        }

        private void Print4(BTreeNode node, int depth)
        {
            if (node == null)
            {
                return;
            }

            Print4(node.Right, depth + 1);

            // Print node value with proper indentation
            Console.Write(new string(' ', depth * 6));
            Console.WriteLine(node.value);

            // Print edge to the left child, if it exists
            if (node.Left != null || node.Right != null)
            {
                // Print proper indentation and edge for the left child
                Console.Write(new string(' ', depth * 6));
                Console.Write(node.Right != null ? "└── " : "├── ");
                Print4(node.Left, depth + 1);
            }
        }

        private void Print5(BTreeNode node, int depth, string prefix = "")
        {
            if (node == null)
            {
                return;
            }

            Print5(node.Right, depth + 1, prefix + (node.Left != null ? " " : " "));

            // Print node value with proper indentation and prefix
            Console.Write(new string(' ', depth * 4));
            Console.WriteLine(prefix + node.value + node.Suffix);

            Print5(node.Left, depth + 1, prefix + (node.Right != null ? " " : " "));
        }

        public void Print(int i = 0)
        {
            if (i == 0)
                Print(Root, 0);
            else if (i == 2)
                Print2(Root, 0);
            else if (i == 3)
                Print3(Root, 0);
            else if (i == 4)
                Print4(Root, 0);
            else if (i == 5)
                Print5(Root, 0);
            else Console.WriteLine("No Implementation!");
        }

        #endregion




    }



}