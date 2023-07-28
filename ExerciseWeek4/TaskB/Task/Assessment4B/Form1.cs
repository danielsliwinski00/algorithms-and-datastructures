using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment4B
{
    public partial class Form1 : Form
    {
        /*List<Activity> activitylist = new List<Activity>();
        List<Activity> optimised = new List<Activity>();*/

        Activity[] activitylist = new Activity[20];
        Activity[] optimised = new Activity[20];
        int k = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtActive.Text == "" && txtStart.Text == "" && txtEnd.Text == "")
            {
                return;
            }
            else
            {
                string stime = txtStart.Text;
                string etime = txtEnd.Text;

                if (stime.Contains("24"))
                {
                    stime = "00";
                }
                if (!stime.Contains(":"))
                {
                    stime = stime + ":00";
                }
                if (!etime.Contains(":"))
                {
                    etime = etime + ":00";
                }
                if (stime.Contains("."))
                {
                    stime = stime.Replace(".", ":");
                }
                if (etime.Contains("."))
                {
                    etime = etime.Replace(".", ":");
                }

                Activity x = new Activity( txtActive.Text, Convert.ToDateTime(stime), Convert.ToDateTime(etime));
                activitylist[k] = x;
                lstDisplay.Items.Add(x.ToString());
                k++;
            }

            txtActive.Text = "";
            txtStart.Text = "";
            txtEnd.Text = "";
        }

        private void btnOptimise_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            Activity.InsertSortGen(activitylist);
            optimised[0] = activitylist[0];
            lstDisplay.Items.Add(activitylist[0].ToString());

            int j = 0;
            for (int i = 1; i < activitylist.Length; i++)
            {
                if (activitylist[i] != null)
                {
                    if (optimised[j].End <= activitylist[i].Start)
                    {
                        lstDisplay.Items.Add(activitylist[i].ToString());
                        optimised[++j] = activitylist[i];
                    }

                }
            }
        }

        private void txtActive_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtStart_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtEnd_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
        }
        private void lblDisplay_Click(object sender, EventArgs e)
        {
        }
        private void rchDisplay_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
