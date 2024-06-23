namespace CSharpAssignment3_2
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
            this.nummericDays = new System.Windows.Forms.NumericUpDown();
            this.lblNumDays = new System.Windows.Forms.Label();
            this.txtCustomerStatus = new System.Windows.Forms.TextBox();
            this.lblCustStatus = new System.Windows.Forms.Label();
            this.tipStatus = new System.Windows.Forms.ToolTip(this.components);
            this.lblExecRoom = new System.Windows.Forms.Label();
            this.txtExecRoom = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblNetCost = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtNetCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nummericDays)).BeginInit();
            this.SuspendLayout();
            // 
            // nummericDays
            // 
            this.nummericDays.Location = new System.Drawing.Point(111, 31);
            this.nummericDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nummericDays.Name = "nummericDays";
            this.nummericDays.Size = new System.Drawing.Size(164, 20);
            this.nummericDays.TabIndex = 0;
            // 
            // lblNumDays
            // 
            this.lblNumDays.AutoSize = true;
            this.lblNumDays.Location = new System.Drawing.Point(20, 33);
            this.lblNumDays.Name = "lblNumDays";
            this.lblNumDays.Size = new System.Drawing.Size(83, 13);
            this.lblNumDays.TabIndex = 1;
            this.lblNumDays.Text = "Number of Days";
            // 
            // txtCustomerStatus
            // 
            this.txtCustomerStatus.Location = new System.Drawing.Point(111, 70);
            this.txtCustomerStatus.Name = "txtCustomerStatus";
            this.txtCustomerStatus.Size = new System.Drawing.Size(164, 20);
            this.txtCustomerStatus.TabIndex = 2;
            // 
            // lblCustStatus
            // 
            this.lblCustStatus.AutoSize = true;
            this.lblCustStatus.Location = new System.Drawing.Point(20, 73);
            this.lblCustStatus.Name = "lblCustStatus";
            this.lblCustStatus.Size = new System.Drawing.Size(84, 13);
            this.lblCustStatus.TabIndex = 3;
            this.lblCustStatus.Text = "Customer Status";
            this.tipStatus.SetToolTip(this.lblCustStatus, "G for Gold, P for Platinum, R for Regular");
            // 
            // tipStatus
            // 
            this.tipStatus.ToolTipTitle = "Customer Status";
            // 
            // lblExecRoom
            // 
            this.lblExecRoom.AutoSize = true;
            this.lblExecRoom.Location = new System.Drawing.Point(20, 114);
            this.lblExecRoom.Name = "lblExecRoom";
            this.lblExecRoom.Size = new System.Drawing.Size(85, 13);
            this.lblExecRoom.TabIndex = 5;
            this.lblExecRoom.Text = "Executive Room";
            this.tipStatus.SetToolTip(this.lblExecRoom, "Y = Yes, N = No");
            // 
            // txtExecRoom
            // 
            this.txtExecRoom.Location = new System.Drawing.Point(111, 111);
            this.txtExecRoom.Name = "txtExecRoom";
            this.txtExecRoom.Size = new System.Drawing.Size(164, 20);
            this.txtExecRoom.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.Location = new System.Drawing.Point(23, 158);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 32);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Location = new System.Drawing.Point(23, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(152, 158);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(123, 78);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblNetCost
            // 
            this.lblNetCost.AutoSize = true;
            this.lblNetCost.Location = new System.Drawing.Point(378, 168);
            this.lblNetCost.Name = "lblNetCost";
            this.lblNetCost.Size = new System.Drawing.Size(48, 13);
            this.lblNetCost.TabIndex = 11;
            this.lblNetCost.Text = "Net Cost";
            this.tipStatus.SetToolTip(this.lblNetCost, "Actual Cost after Discounts.");
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(349, 99);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(108, 13);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "Ammount Discounted";
            this.tipStatus.SetToolTip(this.lblDiscount, "Ammount discounted by status.");
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(371, 38);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total Cost";
            this.tipStatus.SetToolTip(this.lblTotal, "Total cost of stay.");
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(321, 66);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(164, 20);
            this.txtTotalCost.TabIndex = 12;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(321, 129);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(164, 20);
            this.txtDiscount.TabIndex = 13;
            // 
            // txtNetCost
            // 
            this.txtNetCost.Location = new System.Drawing.Point(321, 188);
            this.txtNetCost.Name = "txtNetCost";
            this.txtNetCost.ReadOnly = true;
            this.txtNetCost.Size = new System.Drawing.Size(164, 20);
            this.txtNetCost.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 248);
            this.Controls.Add(this.txtNetCost);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblNetCost);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblExecRoom);
            this.Controls.Add(this.txtExecRoom);
            this.Controls.Add(this.lblCustStatus);
            this.Controls.Add(this.txtCustomerStatus);
            this.Controls.Add(this.lblNumDays);
            this.Controls.Add(this.nummericDays);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(549, 287);
            this.MinimumSize = new System.Drawing.Size(549, 287);
            this.Name = "Form1";
            this.Text = "HotelBooking";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nummericDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nummericDays;
        private System.Windows.Forms.Label lblNumDays;
        private System.Windows.Forms.TextBox txtCustomerStatus;
        private System.Windows.Forms.ToolTip tipStatus;
        private System.Windows.Forms.Label lblCustStatus;
        private System.Windows.Forms.Label lblExecRoom;
        private System.Windows.Forms.TextBox txtExecRoom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblNetCost;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtNetCost;
    }
}

