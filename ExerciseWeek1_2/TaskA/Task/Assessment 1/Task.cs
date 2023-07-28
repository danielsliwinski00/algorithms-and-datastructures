using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    class Task 
    {
        string taskdesc;
        public Task (string taskdescs)
        {
            taskdesc = taskdescs;
        }
        private string TaskDesc { get; set; }
        public string ToString()    //tostring method for returning the string value of taskdesc
        {
            return taskdesc;
        }
    }
}
