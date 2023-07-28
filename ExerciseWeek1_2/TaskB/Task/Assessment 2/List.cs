using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    class List<T>
    {
        private T data;
        private List<T> next;

        public List(T item)
        {
            data = item;
            next = null;
        }

        public List(T item, List<T> list)
        {
            data = item;
            next = list;
        }
        public T Data
        {
            set { this.data = value; }
            get { return this.data; }
        }
        public List<T> Next
        {
            set { this.next = value; }
            get { return this.next; }
        }
    }
}
