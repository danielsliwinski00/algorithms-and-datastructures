using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    public class JournalList<T> where T: IComparable
    {
        private List<T> list = null;

        public void Add(T item)
        {
            list = new List<T>(item, list);
        }

        public void Remove(T item)
        {
            List<T> temp = list;
            JournalList<T> newJournal = new JournalList<T>();

            while (temp != null)
            {
                if (item.CompareTo(temp.Data) != 0)
                {
                    newJournal.Append(temp.Data);
                }
            }
        }    
        public void Append(T item)
        {
            List<T> temp = list;

            if(temp == null)
            {
                list = new List<T>(item);
            }
            else
            {
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new List<T>(item);
            }
        }
        public int Count()
        {
            int count = 0;
            List<T> num = list;

            while (num != null)
            {
                num = num.Next;
                count++;
            }
            return count;
        }

        public void Sort(T Item)
        {
            List<T> temp = list;
            JournalList<T> sortedlist = new JournalList<T>();

            while (temp != null)
            {
                sortedlist.InOrder(temp.Data);
                temp = temp.Next;
            }
            list = sortedlist.list;

        }

        public void InOrder(T item)
        {
            List<T> temp = list;
            JournalList<T> inorder = new JournalList<T>();

            if (temp == null)
            {
                Add(item);
            }
            else
            {
                while (temp != null)
                {
                    if (item.CompareTo(temp.Data) < 0)
                    {
                        inorder.Append(temp.Data);
                    }
                    else if (item.CompareTo(temp.Data) > 0)
                    {
                        inorder.Append(item);
                        inorder.Append(temp.Data);
                    }
                }
                temp = temp.Next;
            }
            list = inorder.list;
        }

        public string Display()
        {
            List<T> temp = list;
            string buffer = "";

            while (temp != null)
            {
                buffer += temp.Data.ToString();
                temp = temp.Next;
            }
            return buffer;
        }
    }
}
