namespace CSharpAssignment10
{
    partial class mainForm
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
            this.lblPassName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAirline = new System.Windows.Forms.Label();
            this.groupReserve = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFlight = new System.Windows.Forms.Label();
            this.btnListFlights = new System.Windows.Forms.Button();
            this.groupListFlight = new System.Windows.Forms.GroupBox();
            this.radioDomest = new System.Windows.Forms.RadioButton();
            this.radioInt = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.lblFlights = new System.Windows.Forms.Label();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.btnShowFlight = new System.Windows.Forms.Button();
            this.lblShowInfo = new System.Windows.Forms.Label();
            this.listFlights = new System.Windows.Forms.ListBox();
            this.groupReserve.SuspendLayout();
            this.groupListFlight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassName
            // 
            this.lblPassName.AutoSize = true;
            this.lblPassName.Location = new System.Drawing.Point(14, 29);
            this.lblPassName.Name = "lblPassName";
            this.lblPassName.Size = new System.Drawing.Size(35, 13);
            this.lblPassName.TabIndex = 0;
            this.lblPassName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(313, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblAirline
            // 
            this.lblAirline.AutoSize = true;
            this.lblAirline.Location = new System.Drawing.Point(23, 9);
            this.lblAirline.Name = "lblAirline";
            this.lblAirline.Size = new System.Drawing.Size(68, 13);
            this.lblAirline.TabIndex = 3;
            this.lblAirline.Text = "[placeholder]";
            // 
            // groupReserve
            // 
            this.groupReserve.Controls.Add(this.btnAdd);
            this.groupReserve.Controls.Add(this.btnClear);
            this.groupReserve.Controls.Add(this.lblFlight);
            this.groupReserve.Controls.Add(this.lblPassName);
            this.groupReserve.Controls.Add(this.txtName);
            this.groupReserve.Location = new System.Drawing.Point(26, 35);
            this.groupReserve.Name = "groupReserve";
            this.groupReserve.Size = new System.Drawing.Size(352, 180);
            this.groupReserve.TabIndex = 5;
            this.groupReserve.TabStop = false;
            this.groupReserve.Text = "Make Reservation";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(162, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 45);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnClear.Location = new System.Drawing.Point(17, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 45);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Location = new System.Drawing.Point(14, 83);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(32, 13);
            this.lblFlight.TabIndex = 5;
            this.lblFlight.Text = "Flight";
            // 
            // btnListFlights
            // 
            this.btnListFlights.Location = new System.Drawing.Point(26, 236);
            this.btnListFlights.Name = "btnListFlights";
            this.btnListFlights.Size = new System.Drawing.Size(179, 118);
            this.btnListFlights.TabIndex = 6;
            this.btnListFlights.Text = "ListFlights";
            this.btnListFlights.UseVisualStyleBackColor = true;
            this.btnListFlights.Click += new System.EventHandler(this.btnListFlights_Click);
            // 
            // groupListFlight
            // 
            this.groupListFlight.Controls.Add(this.radioDomest);
            this.groupListFlight.Controls.Add(this.radioInt);
            this.groupListFlight.Controls.Add(this.radioAll);
            this.groupListFlight.Location = new System.Drawing.Point(216, 230);
            this.groupListFlight.Name = "groupListFlight";
            this.groupListFlight.Size = new System.Drawing.Size(162, 124);
            this.groupListFlight.TabIndex = 7;
            this.groupListFlight.TabStop = false;
            this.groupListFlight.Text = "Which flights?";
            // 
            // radioDomest
            // 
            this.radioDomest.AutoSize = true;
            this.radioDomest.Location = new System.Drawing.Point(37, 80);
            this.radioDomest.Name = "radioDomest";
            this.radioDomest.Size = new System.Drawing.Size(69, 17);
            this.radioDomest.TabIndex = 2;
            this.radioDomest.TabStop = true;
            this.radioDomest.Text = "Domestic";
            this.radioDomest.UseVisualStyleBackColor = true;
            // 
            // radioInt
            // 
            this.radioInt.AutoSize = true;
            this.radioInt.Location = new System.Drawing.Point(37, 57);
            this.radioInt.Name = "radioInt";
            this.radioInt.Size = new System.Drawing.Size(83, 17);
            this.radioInt.TabIndex = 1;
            this.radioInt.TabStop = true;
            this.radioInt.Text = "International";
            this.radioInt.UseVisualStyleBackColor = true;
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(37, 31);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(69, 17);
            this.radioAll.TabIndex = 0;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All Flights";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // lblFlights
            // 
            this.lblFlights.AutoSize = true;
            this.lblFlights.Location = new System.Drawing.Point(554, 9);
            this.lblFlights.Name = "lblFlights";
            this.lblFlights.Size = new System.Drawing.Size(37, 13);
            this.lblFlights.TabIndex = 9;
            this.lblFlights.Text = "Flights";
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.Location = new System.Drawing.Point(705, 9);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.Size = new System.Drawing.Size(0, 13);
            this.lblPassengers.TabIndex = 11;
            // 
            // btnShowFlight
            // 
            this.btnShowFlight.Location = new System.Drawing.Point(26, 397);
            this.btnShowFlight.Name = "btnShowFlight";
            this.btnShowFlight.Size = new System.Drawing.Size(346, 82);
            this.btnShowFlight.TabIndex = 12;
            this.btnShowFlight.Text = "Show Flight Info";
            this.btnShowFlight.UseVisualStyleBackColor = true;
            this.btnShowFlight.Click += new System.EventHandler(this.btnShowFlight_Click);
            // 
            // lblShowInfo
            // 
            this.lblShowInfo.AutoSize = true;
            this.lblShowInfo.Location = new System.Drawing.Point(141, 371);
            this.lblShowInfo.MaximumSize = new System.Drawing.Size(115, 13);
            this.lblShowInfo.MinimumSize = new System.Drawing.Size(115, 13);
            this.lblShowInfo.Name = "lblShowInfo";
            this.lblShowInfo.Size = new System.Drawing.Size(115, 13);
            this.lblShowInfo.TabIndex = 15;
            this.lblShowInfo.Text = "Choose Flight To Right";
            // 
            // listFlights
            // 
            this.listFlights.FormattingEnabled = true;
            this.listFlights.Location = new System.Drawing.Point(384, 33);
            this.listFlights.Name = "listFlights";
            this.listFlights.Size = new System.Drawing.Size(363, 446);
            this.listFlights.TabIndex = 16;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 493);
            this.Controls.Add(this.listFlights);
            this.Controls.Add(this.lblShowInfo);
            this.Controls.Add(this.btnShowFlight);
            this.Controls.Add(this.lblPassengers);
            this.Controls.Add(this.lblFlights);
            this.Controls.Add(this.groupListFlight);
            this.Controls.Add(this.btnListFlights);
            this.Controls.Add(this.groupReserve);
            this.Controls.Add(this.lblAirline);
            this.Name = "mainForm";
            this.Text = "Airlines";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupReserve.ResumeLayout(false);
            this.groupReserve.PerformLayout();
            this.groupListFlight.ResumeLayout(false);
            this.groupListFlight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAirline;
        private System.Windows.Forms.GroupBox groupReserve;
        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnListFlights;
        private System.Windows.Forms.GroupBox groupListFlight;
        private System.Windows.Forms.RadioButton radioDomest;
        private System.Windows.Forms.RadioButton radioInt;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.Label lblFlights;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.Button btnShowFlight;
        private System.Windows.Forms.Label lblShowInfo;
        private System.Windows.Forms.ListBox listFlights;
    }
}

