namespace CSharpAssignment2
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtScoopsV = new System.Windows.Forms.TextBox();
            this.txtScoopsC = new System.Windows.Forms.TextBox();
            this.txtPriceV = new System.Windows.Forms.TextBox();
            this.txtPriceC = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtAverageCost = new System.Windows.Forms.TextBox();
            this.txtPercVanil = new System.Windows.Forms.TextBox();
            this.brnClear = new System.Windows.Forms.Button();
            this.brnExit = new System.Windows.Forms.Button();
            this.btnTotalCost = new System.Windows.Forms.Button();
            this.btnAverageCost = new System.Windows.Forms.Button();
            this.btnPercVanil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(33, 66);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(63, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "# of scoops";
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(33, 91);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Unit Price";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(165, 33);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(38, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Vanilla";
            // 
            // lbl4
            // 
            this.lbl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(260, 33);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(55, 13);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Chocolate";
            // 
            // txtScoopsV
            // 
            this.txtScoopsV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtScoopsV.Location = new System.Drawing.Point(133, 59);
            this.txtScoopsV.Name = "txtScoopsV";
            this.txtScoopsV.Size = new System.Drawing.Size(100, 20);
            this.txtScoopsV.TabIndex = 4;
            // 
            // txtScoopsC
            // 
            this.txtScoopsC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtScoopsC.Location = new System.Drawing.Point(239, 59);
            this.txtScoopsC.Name = "txtScoopsC";
            this.txtScoopsC.Size = new System.Drawing.Size(100, 20);
            this.txtScoopsC.TabIndex = 5;
            // 
            // txtPriceV
            // 
            this.txtPriceV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPriceV.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtPriceV.Location = new System.Drawing.Point(133, 88);
            this.txtPriceV.Name = "txtPriceV";
            this.txtPriceV.ReadOnly = true;
            this.txtPriceV.Size = new System.Drawing.Size(100, 20);
            this.txtPriceV.TabIndex = 6;
            // 
            // txtPriceC
            // 
            this.txtPriceC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPriceC.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtPriceC.Location = new System.Drawing.Point(239, 88);
            this.txtPriceC.Name = "txtPriceC";
            this.txtPriceC.ReadOnly = true;
            this.txtPriceC.Size = new System.Drawing.Size(100, 20);
            this.txtPriceC.TabIndex = 7;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTotalCost.Location = new System.Drawing.Point(156, 159);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 8;
            // 
            // txtAverageCost
            // 
            this.txtAverageCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAverageCost.Location = new System.Drawing.Point(156, 207);
            this.txtAverageCost.Name = "txtAverageCost";
            this.txtAverageCost.Size = new System.Drawing.Size(100, 20);
            this.txtAverageCost.TabIndex = 9;
            // 
            // txtPercVanil
            // 
            this.txtPercVanil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPercVanil.Location = new System.Drawing.Point(156, 255);
            this.txtPercVanil.Name = "txtPercVanil";
            this.txtPercVanil.Size = new System.Drawing.Size(100, 20);
            this.txtPercVanil.TabIndex = 10;
            // 
            // brnClear
            // 
            this.brnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.brnClear.Location = new System.Drawing.Point(279, 159);
            this.brnClear.Name = "brnClear";
            this.brnClear.Size = new System.Drawing.Size(107, 42);
            this.brnClear.TabIndex = 14;
            this.brnClear.Text = "Clear";
            this.brnClear.UseVisualStyleBackColor = true;
            this.brnClear.Click += new System.EventHandler(this.brnClear_Click);
            // 
            // brnExit
            // 
            this.brnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.brnExit.Location = new System.Drawing.Point(279, 233);
            this.brnExit.Name = "brnExit";
            this.brnExit.Size = new System.Drawing.Size(107, 42);
            this.brnExit.TabIndex = 15;
            this.brnExit.Text = "Exit";
            this.brnExit.UseVisualStyleBackColor = true;
            this.brnExit.Click += new System.EventHandler(this.brnExit_Click);
            // 
            // btnTotalCost
            // 
            this.btnTotalCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTotalCost.Location = new System.Drawing.Point(28, 147);
            this.btnTotalCost.Name = "btnTotalCost";
            this.btnTotalCost.Size = new System.Drawing.Size(107, 42);
            this.btnTotalCost.TabIndex = 16;
            this.btnTotalCost.Text = "Total Cost";
            this.btnTotalCost.UseVisualStyleBackColor = true;
            this.btnTotalCost.Click += new System.EventHandler(this.btnTotalCost_Click);
            // 
            // btnAverageCost
            // 
            this.btnAverageCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAverageCost.Location = new System.Drawing.Point(28, 195);
            this.btnAverageCost.Name = "btnAverageCost";
            this.btnAverageCost.Size = new System.Drawing.Size(107, 42);
            this.btnAverageCost.TabIndex = 17;
            this.btnAverageCost.Text = "Average Cost";
            this.btnAverageCost.UseVisualStyleBackColor = true;
            this.btnAverageCost.Click += new System.EventHandler(this.btnAverageCost_Click);
            // 
            // btnPercVanil
            // 
            this.btnPercVanil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPercVanil.Location = new System.Drawing.Point(28, 243);
            this.btnPercVanil.Name = "btnPercVanil";
            this.btnPercVanil.Size = new System.Drawing.Size(107, 42);
            this.btnPercVanil.TabIndex = 18;
            this.btnPercVanil.Text = "Percent of Vanilla";
            this.btnPercVanil.UseVisualStyleBackColor = true;
            this.btnPercVanil.Click += new System.EventHandler(this.btnPercVanil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 324);
            this.Controls.Add(this.btnPercVanil);
            this.Controls.Add(this.btnAverageCost);
            this.Controls.Add(this.btnTotalCost);
            this.Controls.Add(this.brnExit);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.txtPercVanil);
            this.Controls.Add(this.txtAverageCost);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.txtPriceC);
            this.Controls.Add(this.txtPriceV);
            this.Controls.Add(this.txtScoopsC);
            this.Controls.Add(this.txtScoopsV);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(442, 363);
            this.MinimumSize = new System.Drawing.Size(442, 363);
            this.Name = "Form1";
            this.Text = "Ice Cream Cost";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtScoopsV;
        private System.Windows.Forms.TextBox txtScoopsC;
        private System.Windows.Forms.TextBox txtPriceV;
        private System.Windows.Forms.TextBox txtPriceC;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtAverageCost;
        private System.Windows.Forms.TextBox txtPercVanil;
        private System.Windows.Forms.Button brnClear;
        private System.Windows.Forms.Button brnExit;
        private System.Windows.Forms.Button btnTotalCost;
        private System.Windows.Forms.Button btnAverageCost;
        private System.Windows.Forms.Button btnPercVanil;
    }
}

