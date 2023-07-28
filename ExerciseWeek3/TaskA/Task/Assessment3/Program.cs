using System;
using System.IO;

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
            BSTree<string> tree = new BSTree<string>();
            int wordcount=0;

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
                        wordcount++;
                        Console.Write(word.ToLower());
                        tree.Insert(word.ToLower());
                    }
                }
            }
            int treeHeight = tree.Height(tree.root);
            int treeCount = tree.Count(tree.root);
            Console.Write( " Height: " + treeHeight );
            Console.Write( " Count: " + treeCount );
            Console.Write(" wordCount: " + wordcount);
        }

        class Node<T> where T : IComparable
        {
            public T data;
            public Node<T> left, right;

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
        class BSTree<T> where T: IComparable
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
                    return 1+(Count(tree.left) + Count(tree.right));
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
    }
}

