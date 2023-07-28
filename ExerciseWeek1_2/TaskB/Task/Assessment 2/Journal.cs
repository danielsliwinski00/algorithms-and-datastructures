using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    public class Journal: IComparable
    {
        protected string jrnAuthor;
        protected string jrnTitle;
        protected string jrnJRNTitle;
        protected string jrnYear;

        public int CompareTo(object obj)
        {
            Journal other = (Journal)obj;
            return jrnAuthor.CompareTo(other.jrnAuthor);

        }
        public Journal(string author, string title, string jrntitle, string year)
        {
            this.jrnAuthor = author;
            this.jrnTitle = title;
            this.jrnJRNTitle = jrntitle;
            this.jrnYear = year;
        }

        public override string ToString()
        {
            return "[Author: " + jrnAuthor + ", Title: " + jrnTitle + ", Journal Title: " + jrnJRNTitle + ", Publication Year: " + jrnYear + "] ";
        }

        public string Author
        {
            get { return jrnAuthor; }
            set { jrnAuthor = value; }
        }
        public string Title
        {
            get { return jrnTitle; }
            set { jrnTitle = value; }
        }
        public string JRNTitle
        {
            get { return jrnJRNTitle; }
            set { jrnJRNTitle = value; }
        }
        public string Year {
            get {return jrnYear; }
            set {jrnYear = value; }
        }
    }
}
