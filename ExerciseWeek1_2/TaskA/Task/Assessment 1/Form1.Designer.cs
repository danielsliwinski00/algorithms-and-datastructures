
namespace Assessment_1
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
            this.btnEnq = new System.Windows.Forms.Button();
            this.btnDeq = new System.Windows.Forms.Button();
            this.taskEnter = new System.Windows.Forms.TextBox();
            this.taskDisplay = new System.Windows.Forms.TextBox();
            this.taskCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnq
            // 
            this.btnEnq.Location = new System.Drawing.Point(340, 39);
            this.btnEnq.Name = "btnEnq";
            this.btnEnq.Size = new System.Drawing.Size(100, 40);
            this.btnEnq.TabIndex = 0;
            this.btnEnq.Text = "Submit ";
            this.btnEnq.UseVisualStyleBackColor = true;
            this.btnEnq.Click += new System.EventHandler(this.btnEnq_Click);
            // 
            // btnDeq
            // 
            this.btnDeq.Location = new System.Drawing.Point(340, 155);
            this.btnDeq.Name = "btnDeq";
            this.btnDeq.Size = new System.Drawing.Size(100, 38);
            this.btnDeq.TabIndex = 1;
            this.btnDeq.Text = "Completed";
            this.btnDeq.UseVisualStyleBackColor = true;
            this.btnDeq.Click += new System.EventHandler(this.btnDeq_Click);
            // 
            // taskEnter
            // 
            this.taskEnter.Location = new System.Drawing.Point(42, 50);
            this.taskEnter.Name = "taskEnter";
            this.taskEnter.Size = new System.Drawing.Size(268, 20);
            this.taskEnter.TabIndex = 2;
            this.taskEnter.TextChanged += new System.EventHandler(this.taskEnter_TextChanged);
            // 
            // taskDisplay
            // 
            this.taskDisplay.Location = new System.Drawing.Point(42, 165);
            this.taskDisplay.Name = "taskDisplay";
            this.taskDisplay.ReadOnly = true;
            this.taskDisplay.Size = new System.Drawing.Size(268, 20);
            this.taskDisplay.TabIndex = 3;
            // 
            // taskCount
            // 
            this.taskCount.AutoSize = true;
            this.taskCount.Location = new System.Drawing.Point(348, 113);
            this.taskCount.Name = "taskCount";
            this.taskCount.Size = new System.Drawing.Size(38, 13);
            this.taskCount.TabIndex = 4;
            this.taskCount.Text = "Count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 247);
            this.Controls.Add(this.taskCount);
            this.Controls.Add(this.taskDisplay);
            this.Controls.Add(this.taskEnter);
            this.Controls.Add(this.btnDeq);
            this.Controls.Add(this.btnEnq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnq;
        private System.Windows.Forms.Button btnDeq;
        private System.Windows.Forms.TextBox taskEnter;
        private System.Windows.Forms.TextBox taskDisplay;
        private System.Windows.Forms.Label taskCount;
    }
}

