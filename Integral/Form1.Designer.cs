namespace Integral
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.push = new System.Windows.Forms.Button();
            this.box_minOX = new System.Windows.Forms.Label();
            this.val_minOX = new System.Windows.Forms.TextBox();
            this.val_maxOX = new System.Windows.Forms.TextBox();
            this.box_maxOX = new System.Windows.Forms.Label();
            this.val_minOY = new System.Windows.Forms.TextBox();
            this.box_minOY = new System.Windows.Forms.Label();
            this.val_maxOY = new System.Windows.Forms.TextBox();
            this.box_maxOY = new System.Windows.Forms.Label();
            this.val_func = new System.Windows.Forms.TextBox();
            this.box_func = new System.Windows.Forms.Label();
            this.box_res = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.val_step = new System.Windows.Forms.TextBox();
            this.box_step = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoSize = true;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(447, 390);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // push
            // 
            this.push.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.push.Location = new System.Drawing.Point(452, 365);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(75, 23);
            this.push.TabIndex = 1;
            this.push.Text = "Push";
            this.push.UseVisualStyleBackColor = true;
            this.push.Click += new System.EventHandler(this.push_Click);
            // 
            // box_minOX
            // 
            this.box_minOX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.box_minOX.AutoSize = true;
            this.box_minOX.Location = new System.Drawing.Point(475, 18);
            this.box_minOX.Name = "box_minOX";
            this.box_minOX.Size = new System.Drawing.Size(50, 15);
            this.box_minOX.TabIndex = 2;
            this.box_minOX.Text = "min OX:";
            // 
            // val_minOX
            // 
            this.val_minOX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.val_minOX.Location = new System.Drawing.Point(456, 36);
            this.val_minOX.Name = "val_minOX";
            this.val_minOX.Size = new System.Drawing.Size(71, 23);
            this.val_minOX.TabIndex = 3;
            // 
            // val_maxOX
            // 
            this.val_maxOX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.val_maxOX.Location = new System.Drawing.Point(456, 80);
            this.val_maxOX.Name = "val_maxOX";
            this.val_maxOX.Size = new System.Drawing.Size(71, 23);
            this.val_maxOX.TabIndex = 5;
            // 
            // box_maxOX
            // 
            this.box_maxOX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.box_maxOX.AutoSize = true;
            this.box_maxOX.Location = new System.Drawing.Point(475, 62);
            this.box_maxOX.Name = "box_maxOX";
            this.box_maxOX.Size = new System.Drawing.Size(52, 15);
            this.box_maxOX.TabIndex = 4;
            this.box_maxOX.Text = "max OX:";
            // 
            // val_minOY
            // 
            this.val_minOY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.val_minOY.Location = new System.Drawing.Point(456, 124);
            this.val_minOY.Name = "val_minOY";
            this.val_minOY.Size = new System.Drawing.Size(71, 23);
            this.val_minOY.TabIndex = 7;
            // 
            // box_minOY
            // 
            this.box_minOY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.box_minOY.AutoSize = true;
            this.box_minOY.Location = new System.Drawing.Point(475, 106);
            this.box_minOY.Name = "box_minOY";
            this.box_minOY.Size = new System.Drawing.Size(50, 15);
            this.box_minOY.TabIndex = 6;
            this.box_minOY.Text = "min OY:";
            // 
            // val_maxOY
            // 
            this.val_maxOY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.val_maxOY.Location = new System.Drawing.Point(456, 168);
            this.val_maxOY.Name = "val_maxOY";
            this.val_maxOY.Size = new System.Drawing.Size(71, 23);
            this.val_maxOY.TabIndex = 9;
            // 
            // box_maxOY
            // 
            this.box_maxOY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.box_maxOY.AutoSize = true;
            this.box_maxOY.Location = new System.Drawing.Point(475, 150);
            this.box_maxOY.Name = "box_maxOY";
            this.box_maxOY.Size = new System.Drawing.Size(52, 15);
            this.box_maxOY.TabIndex = 8;
            this.box_maxOY.Text = "max OY:";
            // 
            // val_func
            // 
            this.val_func.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.val_func.Location = new System.Drawing.Point(456, 212);
            this.val_func.Name = "val_func";
            this.val_func.Size = new System.Drawing.Size(71, 23);
            this.val_func.TabIndex = 11;
            // 
            // box_func
            // 
            this.box_func.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.box_func.AutoSize = true;
            this.box_func.Location = new System.Drawing.Point(475, 194);
            this.box_func.Name = "box_func";
            this.box_func.Size = new System.Drawing.Size(55, 15);
            this.box_func.TabIndex = 10;
            this.box_func.Text = "function:";
            // 
            // box_res
            // 
            this.box_res.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.box_res.AutoSize = true;
            this.box_res.Location = new System.Drawing.Point(473, 310);
            this.box_res.Name = "box_res";
            this.box_res.Size = new System.Drawing.Size(42, 15);
            this.box_res.TabIndex = 12;
            this.box_res.Text = "Result:";
            // 
            // res
            // 
            this.res.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(466, 332);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(57, 15);
            this.res.TabIndex = 13;
            this.res.Text = "unknown";
            // 
            // val_step
            // 
            this.val_step.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.val_step.Location = new System.Drawing.Point(456, 256);
            this.val_step.Name = "val_step";
            this.val_step.Size = new System.Drawing.Size(71, 23);
            this.val_step.TabIndex = 15;
            // 
            // box_step
            // 
            this.box_step.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.box_step.AutoSize = true;
            this.box_step.Location = new System.Drawing.Point(493, 238);
            this.box_step.Name = "box_step";
            this.box_step.Size = new System.Drawing.Size(32, 15);
            this.box_step.TabIndex = 14;
            this.box_step.Text = "step:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 397);
            this.Controls.Add(this.val_step);
            this.Controls.Add(this.box_step);
            this.Controls.Add(this.res);
            this.Controls.Add(this.box_res);
            this.Controls.Add(this.val_func);
            this.Controls.Add(this.box_func);
            this.Controls.Add(this.val_maxOY);
            this.Controls.Add(this.box_maxOY);
            this.Controls.Add(this.val_minOY);
            this.Controls.Add(this.box_minOY);
            this.Controls.Add(this.val_maxOX);
            this.Controls.Add(this.box_maxOX);
            this.Controls.Add(this.val_minOX);
            this.Controls.Add(this.box_minOX);
            this.Controls.Add(this.push);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel mainPanel;
        private Button push;
        private Label box_minOX;
        private TextBox val_minOX;
        private TextBox val_maxOX;
        private Label box_maxOX;
        private TextBox val_minOY;
        private Label box_minOY;
        private TextBox val_maxOY;
        private Label box_maxOY;
        private TextBox val_func;
        private Label box_func;
        private Label box_res;
        private Label res;
        private TextBox val_step;
        private Label box_step;
    }
}