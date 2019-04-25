using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class binarytree
    {
        private node Root;
        public int Height;
        public int Count;

        public void Print()
        {
            BinaryTreePrinter.printNode(Root);
        }
        private int CountRecursive(node r)
        {
            throw new NotImplementedException();
        }

        public void insert(char val)
        {
            if (Root == null)
            {
                Root = new node(val);
            }
            else
            {
                insert(Root, val);
            }
           
        }
        private void insert(node cur,char val)
        {
            if (val >= cur.Value && cur.RightChild == null)
            {
                cur.RightChild = new node(val);
                return;
            }
            else if (val < cur.Value && cur.LeftChild == null)
            {
                cur.LeftChild = new node(val);
                return;
            }
            if (val >= cur.Value)
            {
                insert(cur.RightChild, val);
            }
            else if (val < cur.Value)
            {
                insert(cur.LeftChild, val);
            }
        }
        public bool Search(char val)
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                return Search(Root, val);
            }
        }
        private bool Search(node cur, char val)
        {
            
            if (val > cur.Value && cur.RightChild != null)
            {
                return Search(cur.RightChild, val);
             
            }
            else if (val < cur.Value && cur.LeftChild != null)
            {
                return Search(cur.LeftChild, val);
               
            }


            if (val == cur.Value)
            {
                return true;
            }
            else
            {
                return false;
            }

          
        }

        //remove
        public void Remove(char val)
        {
            if (Root == null)
            {
                Root = new node(val);
            }
            else
            {
                Remove(Root, val);
            }

        }
        private node Remove(node cur, char val)
        {
           
            if (cur == null) return cur;
            if (val < cur.Value)
                cur.LeftChild = Remove(cur.LeftChild, val);
            else if (val > cur.Value)
                cur.RightChild = Remove(cur.RightChild, val);
            else
            {
                if (cur.LeftChild == null)
                    return cur.RightChild;
                else if (cur.RightChild == null)
                    return cur.LeftChild;
                cur.Value = minValue(cur.RightChild);
                cur.RightChild = Remove(cur.RightChild, cur.Value);
            }
            return cur;
        }
        public char minValue(node root)
        {
            char minv = root.Value;
            while (root.LeftChild != null)
            {
                minv = root.LeftChild.Value;
                root = root.LeftChild;
            }
            return minv;
        }



        public void balance()
        {

        }

        public void PreOrderPrint()
        {
            PreOrderPrint(Root);
        }
        private void PreOrderPrint(node c)
        {
            if (c != null)
            {
                Console.Write(c.Value + " ");
                PreOrderPrint(c.LeftChild);
                PreOrderPrint(c.RightChild);
                
               
            }
        }
        public void InOrderPrint()
        {
            InOrderPrint(Root);
        }
        private void InOrderPrint(node c)
        {
            if(c != null)
            {
                InOrderPrint(c.LeftChild);
                Console.Write(c.Value + " ");
                InOrderPrint(c.RightChild);
            }
        }
        public void PostOrderPrint() 
        {
            PostOrderPrint(Root);
        }
        private void PostOrderPrint(node c)
        {
            if (c != null)
            {
                PostOrderPrint(c.LeftChild);
                PostOrderPrint(c.RightChild);
             
                
                Console.Write(Root.Value + " ");
            }
        }


    }


}
