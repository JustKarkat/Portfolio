namespace CSharpAssignment1
{
    partial class frmAddMultiply
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
            this.lblValueA = new System.Windows.Forms.Label();
            this.lblValueB = new System.Windows.Forms.Label();
            this.lblValueC = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btnResult1 = new System.Windows.Forms.Button();
            this.btnResult2 = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValueA
            // 
            this.lblValueA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblValueA.AutoSize = true;
            this.lblValueA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueA.Location = new System.Drawing.Point(141, 101);
            this.lblValueA.Name = "lblValueA";
            this.lblValueA.Size = new System.Drawing.Size(69, 20);
            this.lblValueA.TabIndex = 0;
            this.lblValueA.Text = "Value A:";
            // 
            // lblValueB
            // 
            this.lblValueB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblValueB.AutoSize = true;
            this.lblValueB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueB.Location = new System.Drawing.Point(397, 101);
            this.lblValueB.Name = "lblValueB";
            this.lblValueB.Size = new System.Drawing.Size(69, 20);
            this.lblValueB.TabIndex = 1;
            this.lblValueB.Text = "Value B:";
            // 
            // lblValueC
            // 
            this.lblValueC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblValueC.AutoSize = true;
            this.lblValueC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueC.Location = new System.Drawing.Point(643, 101);
            this.lblValueC.Name = "lblValueC";
            this.lblValueC.Size = new System.Drawing.Size(69, 20);
            this.lblValueC.TabIndex = 2;
            this.lblValueC.Text = "Value C:";
            // 
            // txt1
            // 
            this.txt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(216, 98);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(121, 26);
            this.txt1.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(472, 98);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(121, 26);
            this.txt2.TabIndex = 4;
            // 
            // txt3
            // 
            this.txt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(718, 98);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(121, 26);
            this.txt3.TabIndex = 5;
            // 
            // btnResult1
            // 
            this.btnResult1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnResult1.BackColor = System.Drawing.Color.Yellow;
            this.btnResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult1.Location = new System.Drawing.Point(175, 186);
            this.btnResult1.Name = "btnResult1";
            this.btnResult1.Size = new System.Drawing.Size(198, 71);
            this.btnResult1.TabIndex = 6;
            this.btnResult1.Text = "A + (B * C)";
            this.btnResult1.UseVisualStyleBackColor = false;
            this.btnResult1.Click += new System.EventHandler(this.btnResult1_Click);
            // 
            // btnResult2
            // 
            this.btnResult2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnResult2.BackColor = System.Drawing.Color.DarkOrange;
            this.btnResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult2.Location = new System.Drawing.Point(175, 272);
            this.btnResult2.Name = "btnResult2";
            this.btnResult2.Size = new System.Drawing.Size(198, 71);
            this.btnResult2.TabIndex = 7;
            this.btnResult2.Text = "(A + B) * C";
            this.btnResult2.UseVisualStyleBackColor = false;
            this.btnResult2.Click += new System.EventHandler(this.btnResult2_Click);
            // 
            // txt4
            // 
            this.txt4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt4.Location = new System.Drawing.Point(404, 206);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(382, 32);
            this.txt4.TabIndex = 8;
            // 
            // txt5
            // 
            this.txt5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt5.Location = new System.Drawing.Point(404, 292);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(382, 32);
            this.txt5.TabIndex = 9;
            // 
            // frmAddMultiply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.btnResult2);
            this.Controls.Add(this.btnResult1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblValueC);
            this.Controls.Add(this.lblValueB);
            this.Controls.Add(this.lblValueA);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmAddMultiply";
            this.Text = "Addition and Multiplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValueA;
        private System.Windows.Forms.Label lblValueB;
        private System.Windows.Forms.Label lblValueC;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btnResult1;
        private System.Windows.Forms.Button btnResult2;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
    }
}

