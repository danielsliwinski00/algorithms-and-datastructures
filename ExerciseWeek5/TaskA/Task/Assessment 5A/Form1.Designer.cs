
namespace Assessment_5A
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNode = new System.Windows.Forms.TextBox();
            this.btnNode = new System.Windows.Forms.Button();
            this.txtEdgeF = new System.Windows.Forms.TextBox();
            this.txtEdgeT = new System.Windows.Forms.TextBox();
            this.btnEdge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdjF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdjT = new System.Windows.Forms.TextBox();
            this.btnAdj = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Node: ";
            // 
            // txtNode
            // 
            this.txtNode.Location = new System.Drawing.Point(79, 57);
            this.txtNode.Name = "txtNode";
            this.txtNode.Size = new System.Drawing.Size(195, 20);
            this.txtNode.TabIndex = 1;
            this.txtNode.TextChanged += new System.EventHandler(this.txtNode_TextChanged);
            // 
            // btnNode
            // 
            this.btnNode.Location = new System.Drawing.Point(132, 121);
            this.btnNode.Name = "btnNode";
            this.btnNode.Size = new System.Drawing.Size(98, 33);
            this.btnNode.TabIndex = 2;
            this.btnNode.Text = "Submit";
            this.btnNode.UseVisualStyleBackColor = true;
            this.btnNode.Click += new System.EventHandler(this.btnNode_Click);
            // 
            // txtEdgeF
            // 
            this.txtEdgeF.Location = new System.Drawing.Point(80, 203);
            this.txtEdgeF.Name = "txtEdgeF";
            this.txtEdgeF.Size = new System.Drawing.Size(86, 20);
            this.txtEdgeF.TabIndex = 3;
            this.txtEdgeF.TextChanged += new System.EventHandler(this.txtEdgeF_TextChanged);
            // 
            // txtEdgeT
            // 
            this.txtEdgeT.Location = new System.Drawing.Point(193, 203);
            this.txtEdgeT.Name = "txtEdgeT";
            this.txtEdgeT.Size = new System.Drawing.Size(82, 20);
            this.txtEdgeT.TabIndex = 4;
            this.txtEdgeT.TextChanged += new System.EventHandler(this.txtEdgeT_TextChanged);
            // 
            // btnEdge
            // 
            this.btnEdge.Location = new System.Drawing.Point(132, 251);
            this.btnEdge.Name = "btnEdge";
            this.btnEdge.Size = new System.Drawing.Size(98, 34);
            this.btnEdge.TabIndex = 5;
            this.btnEdge.Text = "Submit";
            this.btnEdge.UseVisualStyleBackColor = true;
            this.btnEdge.Click += new System.EventHandler(this.btnEdge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add Edge between Nodes:";
            // 
            // txtAdjF
            // 
            this.txtAdjF.Location = new System.Drawing.Point(80, 333);
            this.txtAdjF.Name = "txtAdjF";
            this.txtAdjF.Size = new System.Drawing.Size(86, 20);
            this.txtAdjF.TabIndex = 7;
            this.txtAdjF.TextChanged += new System.EventHandler(this.txtAdjF_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Are these Nodes Adjacent?:";
            // 
            // txtAdjT
            // 
            this.txtAdjT.Location = new System.Drawing.Point(193, 333);
            this.txtAdjT.Name = "txtAdjT";
            this.txtAdjT.Size = new System.Drawing.Size(82, 20);
            this.txtAdjT.TabIndex = 9;
            this.txtAdjT.TextChanged += new System.EventHandler(this.txtAdjT_TextChanged);
            // 
            // btnAdj
            // 
            this.btnAdj.Location = new System.Drawing.Point(132, 371);
            this.btnAdj.Name = "btnAdj";
            this.btnAdj.Size = new System.Drawing.Size(98, 31);
            this.btnAdj.TabIndex = 10;
            this.btnAdj.Text = "Submit";
            this.btnAdj.UseVisualStyleBackColor = true;
            this.btnAdj.Click += new System.EventHandler(this.btnAdj_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(80, 450);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(195, 20);
            this.txtOutput.TabIndex = 11;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Result:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "To:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Count:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(132, 83);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(98, 20);
            this.txtCount.TabIndex = 16;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 497);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnAdj);
            this.Controls.Add(this.txtAdjT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdjF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEdge);
            this.Controls.Add(this.txtEdgeT);
            this.Controls.Add(this.txtEdgeF);
            this.Controls.Add(this.btnNode);
            this.Controls.Add(this.txtNode);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNode;
        private System.Windows.Forms.Button btnNode;
        private System.Windows.Forms.TextBox txtEdgeF;
        private System.Windows.Forms.TextBox txtEdgeT;
        private System.Windows.Forms.Button btnEdge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdjF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdjT;
        private System.Windows.Forms.Button btnAdj;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCount;
    }
}

