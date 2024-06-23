namespace CSharpAssignment3_1
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
            this.lblCurPop = new System.Windows.Forms.Label();
            this.lblTarPop = new System.Windows.Forms.Label();
            this.lblGrowRate = new System.Windows.Forms.Label();
            this.txtCurPop = new System.Windows.Forms.TextBox();
            this.txtTarPop = new System.Windows.Forms.TextBox();
            this.txtGrowRate = new System.Windows.Forms.TextBox();
            this.lblYrly = new System.Windows.Forms.Label();
            this.txtYearlyPop = new System.Windows.Forms.RichTextBox();
            this.txtToReach = new System.Windows.Forms.TextBox();
            this.lblYrToReach = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurPop
            // 
            this.lblCurPop.AutoSize = true;
            this.lblCurPop.Location = new System.Drawing.Point(22, 56);
            this.lblCurPop.Name = "lblCurPop";
            this.lblCurPop.Size = new System.Drawing.Size(94, 13);
            this.lblCurPop.TabIndex = 0;
            this.lblCurPop.Text = "Current Population";
            // 
            // lblTarPop
            // 
            this.lblTarPop.AutoSize = true;
            this.lblTarPop.Location = new System.Drawing.Point(25, 101);
            this.lblTarPop.Name = "lblTarPop";
            this.lblTarPop.Size = new System.Drawing.Size(91, 13);
            this.lblTarPop.TabIndex = 1;
            this.lblTarPop.Text = "Target Population";
            // 
            // lblGrowRate
            // 
            this.lblGrowRate.AutoSize = true;
            this.lblGrowRate.Location = new System.Drawing.Point(22, 146);
            this.lblGrowRate.Name = "lblGrowRate";
            this.lblGrowRate.Size = new System.Drawing.Size(67, 13);
            this.lblGrowRate.TabIndex = 2;
            this.lblGrowRate.Text = "Growth Rate";
            // 
            // txtCurPop
            // 
            this.txtCurPop.Location = new System.Drawing.Point(146, 49);
            this.txtCurPop.Name = "txtCurPop";
            this.txtCurPop.Size = new System.Drawing.Size(146, 20);
            this.txtCurPop.TabIndex = 3;
            // 
            // txtTarPop
            // 
            this.txtTarPop.Location = new System.Drawing.Point(146, 98);
            this.txtTarPop.Name = "txtTarPop";
            this.txtTarPop.Size = new System.Drawing.Size(146, 20);
            this.txtTarPop.TabIndex = 4;
            // 
            // txtGrowRate
            // 
            this.txtGrowRate.Location = new System.Drawing.Point(146, 143);
            this.txtGrowRate.Name = "txtGrowRate";
            this.txtGrowRate.Size = new System.Drawing.Size(146, 20);
            this.txtGrowRate.TabIndex = 5;
            // 
            // lblYrly
            // 
            this.lblYrly.AutoSize = true;
            this.lblYrly.Location = new System.Drawing.Point(407, 9);
            this.lblYrly.Name = "lblYrly";
            this.lblYrly.Size = new System.Drawing.Size(89, 13);
            this.lblYrly.TabIndex = 6;
            this.lblYrly.Text = "Yearly Population";
            // 
            // txtYearlyPop
            // 
            this.txtYearlyPop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtYearlyPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearlyPop.Location = new System.Drawing.Point(368, 49);
            this.txtYearlyPop.Name = "txtYearlyPop";
            this.txtYearlyPop.ReadOnly = true;
            this.txtYearlyPop.Size = new System.Drawing.Size(183, 114);
            this.txtYearlyPop.TabIndex = 7;
            this.txtYearlyPop.Text = "";
            // 
            // txtToReach
            // 
            this.txtToReach.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtToReach.Location = new System.Drawing.Point(368, 217);
            this.txtToReach.Name = "txtToReach";
            this.txtToReach.ReadOnly = true;
            this.txtToReach.Size = new System.Drawing.Size(168, 20);
            this.txtToReach.TabIndex = 8;
            // 
            // lblYrToReach
            // 
            this.lblYrToReach.AutoSize = true;
            this.lblYrToReach.Location = new System.Drawing.Point(233, 217);
            this.lblYrToReach.Name = "lblYrToReach";
            this.lblYrToReach.Size = new System.Drawing.Size(119, 13);
            this.lblYrToReach.TabIndex = 9;
            this.lblYrToReach.Text = "Years To Reach Target";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.LightCoral;
            this.btnCalc.Location = new System.Drawing.Point(24, 191);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(122, 46);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGreen;
            this.btnClear.Location = new System.Drawing.Point(24, 254);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 46);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gold;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(394, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 46);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 317);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblYrToReach);
            this.Controls.Add(this.txtToReach);
            this.Controls.Add(this.txtYearlyPop);
            this.Controls.Add(this.lblYrly);
            this.Controls.Add(this.txtGrowRate);
            this.Controls.Add(this.txtTarPop);
            this.Controls.Add(this.txtCurPop);
            this.Controls.Add(this.lblGrowRate);
            this.Controls.Add(this.lblTarPop);
            this.Controls.Add(this.lblCurPop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(586, 356);
            this.MinimumSize = new System.Drawing.Size(586, 356);
            this.Name = "Form1";
            this.Text = "City Population";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurPop;
        private System.Windows.Forms.Label lblTarPop;
        private System.Windows.Forms.Label lblGrowRate;
        private System.Windows.Forms.TextBox txtCurPop;
        private System.Windows.Forms.TextBox txtTarPop;
        private System.Windows.Forms.TextBox txtGrowRate;
        private System.Windows.Forms.Label lblYrly;
        private System.Windows.Forms.RichTextBox txtYearlyPop;
        private System.Windows.Forms.TextBox txtToReach;
        private System.Windows.Forms.Label lblYrToReach;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

