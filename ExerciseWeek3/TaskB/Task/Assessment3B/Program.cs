using System;
using System.IO;
using System.Collections.Generic;

namespace Assessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            readFile("textfile.txt");
        }
        static void readFile(string fileName)
        {
            AVLTree<string> tree = new AVLTree<string>();
            List<wordStore> repeat = new List<wordStore>();

            const int MAX_FILE_LINES = 50000;   //read code given in assessment
            string[] AllLines = new string[MAX_FILE_LINES];

            //reads from bin/DEBUG subdirectory of project directory
            AllLines = File.ReadAllLines(fileName);

            foreach (string line in AllLines)
            {
                //split words using space , . ?
                string[] words = line.Split(' ', ',', '.', '?', ';', ':', '!');
                foreach (string word in words)
                {
                    if (word != "")
                    {
                        Console.Write(word.ToLower());
                        tree.Insert(word.ToLower());
                        
                    }
                }
            }

            int treeHeight = tree.Height(tree.root);
            int treeCount = tree.Count(tree.root);
            Console.Write(" Height: " + treeHeight);
            Console.Write(" Count: " + treeCount);
        }

        class Node<T> where T : IComparable
        {
            public T data;
            public Node<T> left, right;
            private int balanceFactor = 0;
            public int BalanceFactor
            {
                set { balanceFactor = value; }
                get { return balanceFactor; }
            }

            public Node(T item)
            {
                data = item;
                left = null;
                right = null;
            }
            public T Data
            {
                set { data = value; }
                get { return data; }
            }
        }
        class BSTree<T> where T : IComparable
        {
            public Node<T> root;
            public BSTree()
            {
                root = null;
            }
            public BSTree(Node<T> tree)
            {
                this.root = tree;
            }
            public int Height(Node<T> tree)
            {
                if (tree == null)
                {
                    return 0;
                }
                else
                {
                    int leftHeight;
                    int rightHeight;
                    leftHeight = Height(tree.left);
                    rightHeight = Height(tree.right);

                    if (leftHeight > rightHeight)
                    {
                        return leftHeight + 1;
                    }
                    else
                    {
                        return rightHeight + 1;
                    }
                }
            }
            public int Count(Node<T> tree)
            {
                if (tree == null)
                {
                    return 0;
                }
                else
                {
                    return (Count(tree.left) + Count(tree.right) + 1);
                }
            }
            public void Insert(T item)
            {
                insert(item, ref root);
            }
            private void insert(T item, ref Node<T> tree)
            {
                if (tree == null)
                {
                    tree = new Node<T>(item);
                }
                else if (item.CompareTo(tree.Data) < 0)
                {
                    insert(item, ref tree.left);
                }
                else if (item.CompareTo(tree.Data) > 0)
                {
                    insert(item, ref tree.right);
                }
            }
        }
        class AVLTree<T> : BSTree<T> where T : IComparable
        {
            public new void Insert(T item)
            {
                insert(item, ref root);
            }

            private void insert(T item, ref Node<T> tree)
            {
                if (tree == null)
                {
                    tree = new Node<T>(item);
                }
                else if (item.CompareTo(tree.Data) < 0)
                {
                    insert(item, ref tree.left);
                }
                else if (item.CompareTo(tree.Data) > 0)
                {
                    insert(item, ref tree.right);
                }

                tree.BalanceFactor = Height(tree.left) - Height(tree.right);

                if (tree.BalanceFactor <= -2)
                {
                    rotateLeft(ref tree);
                }
                if (tree.BalanceFactor >= 2)
                {
                    rotateRight(ref tree);
                }
            }
            private void rotateLeft(ref Node<T> tree)
            {
                if (tree.right.BalanceFactor > 0)   //double rotate
                {
                    rotateRight(ref tree.right);
                }
            }
            private void rotateRight(ref Node<T> tree)
            {
                if (tree.left.BalanceFactor < 0)    //double rotate
                {
                    rotateLeft(ref tree.left);
                }
            }
        }

        class wordStore
        {
            public string storeword { get; set; }
            public int occur { get; set; }

            /*public wordStore()
            {
            }

            public wordStore(string store, int occ)
            {
                storeword = store;
                occur = occ;
            }*/
            public override string ToString()
            {
                 return " "+ storeword + " [" + occur +"]";
            }
        }
    }
}

