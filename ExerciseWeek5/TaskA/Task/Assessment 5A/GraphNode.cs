using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_5A
{
    class GraphNode<T> where T : IComparable
    {
        private T id;
        private LinkedList<T> adjList;

        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();
        }

        public T ID
        {
            set { id = value; }
            get { return id; }
        }

        public void AddEdge(GraphNode<T> n)
        {
            adjList.AddLast(n.id);
        }

        public LinkedList<T> GetAdjacent()
        {
            return adjList;
        }
    }
}
