using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_1
{
    public partial class Form1 : Form
    {
        private Queue q = new Queue();  //create new queue called q
        public Form1()
        {
            InitializeComponent();
            taskDisplay.Text = "" + q.Peek().ToString();
            taskCount.Text = "Count: " + q.NumItems();
        }

        private void btnEnq_Click(object sender, EventArgs e)
        {
                Task taskEntry = new Task(taskEnter.Text);      //taskenter text gets added as a task
                q.Enqueue(taskEntry);                         //enqueues a task 
                taskDisplay.Text = q.Peek().ToString();       //displays the new peek task after enqueuing the new task
                taskEnter.Text = "";                            //resets textbox
                taskCount.Text = "Count: " + q.NumItems();    //updates number of items after enqueuing  
        }

        private void btnDeq_Click(object sender, EventArgs e)
        {
            q.Dequeue();                                 //dequeues a task
            taskCount.Text = "Count:" + q.NumItems();    //updates number of items after dequeuing
            taskDisplay.Text = "" + q.Peek().ToString(); //displays the new peek task after dequeuing the previous
        }

        private void taskEnter_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
