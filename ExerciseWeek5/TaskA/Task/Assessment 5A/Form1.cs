using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_5A
{
    public partial class Form1 : Form
    {
        Graph<int> graph = new Graph<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNode_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";

            if (txtNode.Text != "")
            {
                graph.AddNode( Convert.ToInt32(txtNode.Text) );
                txtCount.Text = graph.NumNodesGraph().ToString();
                txtNode.Text = "";
            }
            else 
            { 
            }
        }

        private void btnEdge_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";

            graph.AddEdge( Convert.ToInt32(txtEdgeF.Text), Convert.ToInt32(txtEdgeT.Text) );
            txtEdgeF.Text = "";
            txtEdgeT.Text = "";
        }

        private void btnAdj_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";

            if (graph.IsEmptyGraph() == false)
            {
                if (graph.IsAdj(graph.GetNodeById(Convert.ToInt32(txtAdjF.Text)), graph.GetNodeById(Convert.ToInt32(txtAdjT.Text))) == true)
                {
                    txtOutput.Text = "The Node: " + txtAdjF.Text + " Is adjacent to: " + txtAdjT.Text;
                }
                else
                {
                    txtOutput.Text = "Nodes are not adjacent";
                }
            }
            else
            {
                txtOutput.Text = "Graph is empty";
            }
        }


        private void txtNode_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtEdgeF_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtEdgeT_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtAdjF_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtAdjT_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtCount_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
