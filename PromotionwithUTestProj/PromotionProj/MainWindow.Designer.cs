namespace PromotionProj
{
    partial class MainWindow
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
            this.lstScenarioA = new System.Windows.Forms.ListBox();
            this.lstScenarioB = new System.Windows.Forms.ListBox();
            this.lstScenarioC = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScenarioA = new System.Windows.Forms.TextBox();
            this.txtScenarioB = new System.Windows.Forms.TextBox();
            this.txtScenarioC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstScenarioA
            // 
            this.lstScenarioA.Enabled = false;
            this.lstScenarioA.FormattingEnabled = true;
            this.lstScenarioA.ItemHeight = 20;
            this.lstScenarioA.Location = new System.Drawing.Point(265, 94);
            this.lstScenarioA.Name = "lstScenarioA";
            this.lstScenarioA.Size = new System.Drawing.Size(105, 124);
            this.lstScenarioA.TabIndex = 1;
            // 
            // lstScenarioB
            // 
            this.lstScenarioB.Enabled = false;
            this.lstScenarioB.FormattingEnabled = true;
            this.lstScenarioB.ItemHeight = 20;
            this.lstScenarioB.Location = new System.Drawing.Point(407, 94);
            this.lstScenarioB.Name = "lstScenarioB";
            this.lstScenarioB.Size = new System.Drawing.Size(105, 124);
            this.lstScenarioB.TabIndex = 2;
            // 
            // lstScenarioC
            // 
            this.lstScenarioC.Enabled = false;
            this.lstScenarioC.FormattingEnabled = true;
            this.lstScenarioC.ItemHeight = 20;
            this.lstScenarioC.Location = new System.Drawing.Point(544, 94);
            this.lstScenarioC.Name = "lstScenarioC";
            this.lstScenarioC.Size = new System.Drawing.Size(105, 124);
            this.lstScenarioC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scenario A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scenario B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Scenario C";
            // 
            // txtScenarioA
            // 
            this.txtScenarioA.Location = new System.Drawing.Point(265, 254);
            this.txtScenarioA.Name = "txtScenarioA";
            this.txtScenarioA.ReadOnly = true;
            this.txtScenarioA.Size = new System.Drawing.Size(100, 26);
            this.txtScenarioA.TabIndex = 10;
            this.txtScenarioA.TabStop = false;
            // 
            // txtScenarioB
            // 
            this.txtScenarioB.Location = new System.Drawing.Point(407, 254);
            this.txtScenarioB.Name = "txtScenarioB";
            this.txtScenarioB.ReadOnly = true;
            this.txtScenarioB.Size = new System.Drawing.Size(100, 26);
            this.txtScenarioB.TabIndex = 11;
            this.txtScenarioB.TabStop = false;
            // 
            // txtScenarioC
            // 
            this.txtScenarioC.Location = new System.Drawing.Point(549, 254);
            this.txtScenarioC.Name = "txtScenarioC";
            this.txtScenarioC.ReadOnly = true;
            this.txtScenarioC.Size = new System.Drawing.Size(100, 26);
            this.txtScenarioC.TabIndex = 12;
            this.txtScenarioC.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total :";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtScenarioC);
            this.Controls.Add(this.txtScenarioB);
            this.Controls.Add(this.txtScenarioA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstScenarioC);
            this.Controls.Add(this.lstScenarioB);
            this.Controls.Add(this.lstScenarioA);
            this.Name = "MainWindow";
            this.Text = "Calculate total with Promotion Engine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstScenarioA;
        private System.Windows.Forms.ListBox lstScenarioB;
        private System.Windows.Forms.ListBox lstScenarioC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScenarioA;
        private System.Windows.Forms.TextBox txtScenarioB;
        private System.Windows.Forms.TextBox txtScenarioC;
        private System.Windows.Forms.Label label4;
    }
}

