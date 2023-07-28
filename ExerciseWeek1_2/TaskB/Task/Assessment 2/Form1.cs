using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2
{
    public partial class Form1 : Form
    {
        JournalList<Journal> journals = new JournalList<Journal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Journal x = new Journal(txtAuthor.Text, txtTitle.Text, txtJrnTitle.Text, txtYear.Text);
            journals.Add(x);
            lstDisplay.Items.Add(x.ToString());
            txtAuthor.Text = "";
            txtTitle.Text = "";
            txtJrnTitle.Text = "";
            txtYear.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            journals = null;
            lstDisplay.Items.Clear();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            for (int i = 0; i < journals.Count(); i++)
            {
                lstDisplay.Items.Add(journals.Display());
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {/*
            lstDisplay.Items.Clear();

            for(int i = 0; i < journals.Count(); i++)
            {
                lstDisplay.Items.Add(journals.ToString());
            }*/

        }
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
        }       
        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtJrnTitle_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
