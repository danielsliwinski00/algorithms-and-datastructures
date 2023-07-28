using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_5A
{
    class Graph<T> where T : IComparable
    {
        private LinkedList< GraphNode<T> > nodes;

        public Graph()
        {
            nodes = new LinkedList< GraphNode<T> >();
        }
        public bool IsEmptyGraph()
        {
            if(nodes.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
        public int NumNodesGraph() // returns the total number of nodes present in the graph
        {
            return nodes.Count;
        }

        public void AddNode(T id)
        {
            nodes.AddLast( new GraphNode<T>(id) );
        }

        public GraphNode<T> GetNodeById(T id)
        {
            foreach ( GraphNode<T> n in nodes )
            {
                if ( id.CompareTo(n.ID) == 0 )
                {
                    return n;
                }

            }
            return null;
        }

        public bool IsAdj( GraphNode<T> from, GraphNode<T> to )
        {
                foreach (GraphNode<T> n in nodes)
                {
                    if (n.ID.CompareTo(from.ID) == 0)
                    {
                        if (from.GetAdjacent().Contains(to.ID))
                        {
                            return true;
                        }
                    }
                }
                return false;
        }

        public void AddEdge( T from, T to )
        {
            if (IsEmptyGraph() == false)
            {
                GraphNode<T> a = GetNodeById(from);
                GraphNode<T> b = GetNodeById(to);

                if (a != null && b != null)
                {
                    a.AddEdge(b);
                }
                else
                {
                    Console.Write("Nodes not present");
                }
            }
            else
            {
                Console.Write("Graph is empty");
            }
        }
    }
}

