namespace CSharpAssignment5
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
            this.components = new System.ComponentModel.Container();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblOverall = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtOverallScore = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(28, 14);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(36, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "Part A";
            this.toolTip1.SetToolTip(this.lblA, "Score for Part A");
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(28, 40);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(36, 13);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "Part B";
            this.toolTip1.SetToolTip(this.lblB, "Score for Part B");
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(28, 66);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(36, 13);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "Part C";
            this.toolTip1.SetToolTip(this.lblC, "Score for Part C");
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(31, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(126, 78);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.toolTip1.SetToolTip(this.btnCalculate, "Calculates Employees Score, Grade, and Salary.");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(31, 104);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 78);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClear, "Clears all textboxes.");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(441, 235);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 45);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.toolTip1.SetToolTip(this.btnClose, "Close the Program.");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOverall
            // 
            this.lblOverall.AutoSize = true;
            this.lblOverall.Location = new System.Drawing.Point(186, 121);
            this.lblOverall.Name = "lblOverall";
            this.lblOverall.Size = new System.Drawing.Size(71, 13);
            this.lblOverall.TabIndex = 15;
            this.lblOverall.Text = "Overall Score";
            this.toolTip1.SetToolTip(this.lblOverall, "The Overall Score for Employee");
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(181, 181);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(84, 13);
            this.lblGrade.TabIndex = 16;
            this.lblGrade.Text = "Grade Achieved";
            this.toolTip1.SetToolTip(this.lblGrade, "Grade Achieved by Employee (A, B, C, D, or F)");
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(186, 245);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(73, 13);
            this.lblSalary.TabIndex = 17;
            this.lblSalary.Text = "Salary Earned";
            this.toolTip1.SetToolTip(this.lblSalary, "Salary Earned based on Grade");
            // 
            // txtOverallScore
            // 
            this.txtOverallScore.Location = new System.Drawing.Point(289, 118);
            this.txtOverallScore.Name = "txtOverallScore";
            this.txtOverallScore.Size = new System.Drawing.Size(128, 20);
            this.txtOverallScore.TabIndex = 12;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(289, 178);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(128, 20);
            this.txtGrade.TabIndex = 13;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(289, 242);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(128, 20);
            this.txtSalary.TabIndex = 14;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(97, 11);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(128, 20);
            this.txtA.TabIndex = 19;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(97, 37);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(128, 20);
            this.txtB.TabIndex = 20;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(97, 63);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(128, 20);
            this.txtC.TabIndex = 21;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(252, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name:";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(252, 53);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(95, 13);
            this.lblYears.TabIndex = 23;
            this.lblYears.Text = "Years in Company:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(309, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 20);
            this.txtName.TabIndex = 24;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(353, 50);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(168, 20);
            this.txtYears.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblOverall);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtOverallScore);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(549, 331);
            this.MinimumSize = new System.Drawing.Size(549, 331);
            this.Name = "Form1";
            this.Text = "Employee Evaluation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtOverallScore;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblOverall;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtYears;
    }
}

