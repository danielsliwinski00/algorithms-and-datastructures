using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4B
{
    public class Activity : IComparable
    {
        public string desc;
        public DateTime start;
        public DateTime end;
        public TimeSpan duration;

        public Activity(string desc, DateTime start, DateTime end) //constructor with two argument
        {
            this.desc = desc;
            this.start = start;
            this.end = end;
        }

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }
        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }

        public void Duration()
        {
                duration = End - Start;
        }

        public override string ToString() //for display
        {
            string starttime = Start.ToString("HH:mm");
            string endtime = End.ToString("HH:mm");
            Duration();

            return "[ Activity: '" + Desc + "', Start Time: " + starttime + ", Finish time: " + endtime + ", Duration: " + duration.TotalHours.ToString("N2") + " hours" + "/"+ duration.TotalMinutes + " minutes" + " ] ";
        }

        static public void InsertSortGen(Activity[] n) //generic insertion sort
        {
            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] != null)
                {
                    Activity value = n[i];
                    int j = i;

                    for (; j > 0 && value.CompareTo(n[j - 1]) < 0; j--)   //using *CompareTo* because its generic 
                    {
                        n[j] = n[j - 1];
                    }
                    n[j] = value;
                }
            }
        }

        public int CompareTo(Object obj)    //for IComparable
        {
            Activity other = (Activity)obj;
            return End.CompareTo(other.End);
        }
    }
}
