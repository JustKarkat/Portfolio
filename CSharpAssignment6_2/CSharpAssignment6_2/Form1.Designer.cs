namespace CSharpAssignment6_2
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
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNewSport = new System.Windows.Forms.TextBox();
            this.lblNewSport = new System.Windows.Forms.Label();
            this.lblSportPartic = new System.Windows.Forms.Label();
            this.numNewSportParticipants = new System.Windows.Forms.NumericUpDown();
            this.lblSportName = new System.Windows.Forms.Label();
            this.txtRemSportName = new System.Windows.Forms.TextBox();
            this.btnAddSport = new System.Windows.Forms.Button();
            this.btnSpecSport = new System.Windows.Forms.Button();
            this.btnRemSport = new System.Windows.Forms.Button();
            this.lblSpecSport = new System.Windows.Forms.Label();
            this.txtSpecificSport = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHighestParticipant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNewSportParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(132, 163);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(375, 54);
            this.btnListAll.TabIndex = 0;
            this.btnListAll.Text = "List All Sports And Participants";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Location = new System.Drawing.Point(15, 154);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNewSport
            // 
            this.txtNewSport.Location = new System.Drawing.Point(69, 16);
            this.txtNewSport.Name = "txtNewSport";
            this.txtNewSport.Size = new System.Drawing.Size(129, 20);
            this.txtNewSport.TabIndex = 3;
            // 
            // lblNewSport
            // 
            this.lblNewSport.AutoSize = true;
            this.lblNewSport.Location = new System.Drawing.Point(6, 19);
            this.lblNewSport.Name = "lblNewSport";
            this.lblNewSport.Size = new System.Drawing.Size(57, 13);
            this.lblNewSport.TabIndex = 4;
            this.lblNewSport.Text = "New Sport";
            // 
            // lblSportPartic
            // 
            this.lblSportPartic.AutoSize = true;
            this.lblSportPartic.Location = new System.Drawing.Point(6, 46);
            this.lblSportPartic.Name = "lblSportPartic";
            this.lblSportPartic.Size = new System.Drawing.Size(114, 13);
            this.lblSportPartic.TabIndex = 5;
            this.lblSportPartic.Text = "Number of Participants";
            // 
            // numNewSportParticipants
            // 
            this.numNewSportParticipants.Location = new System.Drawing.Point(122, 42);
            this.numNewSportParticipants.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNewSportParticipants.Name = "numNewSportParticipants";
            this.numNewSportParticipants.Size = new System.Drawing.Size(76, 20);
            this.numNewSportParticipants.TabIndex = 6;
            // 
            // lblSportName
            // 
            this.lblSportName.AutoSize = true;
            this.lblSportName.Location = new System.Drawing.Point(6, 121);
            this.lblSportName.Name = "lblSportName";
            this.lblSportName.Size = new System.Drawing.Size(63, 13);
            this.lblSportName.TabIndex = 9;
            this.lblSportName.Text = "Sport Name";
            // 
            // txtRemSportName
            // 
            this.txtRemSportName.Location = new System.Drawing.Point(75, 118);
            this.txtRemSportName.Name = "txtRemSportName";
            this.txtRemSportName.Size = new System.Drawing.Size(129, 20);
            this.txtRemSportName.TabIndex = 8;
            // 
            // btnAddSport
            // 
            this.btnAddSport.Location = new System.Drawing.Point(204, 16);
            this.btnAddSport.Name = "btnAddSport";
            this.btnAddSport.Size = new System.Drawing.Size(103, 46);
            this.btnAddSport.TabIndex = 13;
            this.btnAddSport.Text = "Add a New Sport";
            this.btnAddSport.UseVisualStyleBackColor = true;
            this.btnAddSport.Click += new System.EventHandler(this.btnAddSport_Click);
            // 
            // btnSpecSport
            // 
            this.btnSpecSport.Location = new System.Drawing.Point(238, 88);
            this.btnSpecSport.Name = "btnSpecSport";
            this.btnSpecSport.Size = new System.Drawing.Size(283, 24);
            this.btnSpecSport.TabIndex = 14;
            this.btnSpecSport.Text = "List Specific Sport Info";
            this.btnSpecSport.UseVisualStyleBackColor = true;
            this.btnSpecSport.Click += new System.EventHandler(this.btnSpecSport_Click);
            // 
            // btnRemSport
            // 
            this.btnRemSport.Location = new System.Drawing.Point(9, 91);
            this.btnRemSport.Name = "btnRemSport";
            this.btnRemSport.Size = new System.Drawing.Size(195, 21);
            this.btnRemSport.TabIndex = 15;
            this.btnRemSport.Text = "Remove a Sport";
            this.btnRemSport.UseVisualStyleBackColor = true;
            this.btnRemSport.Click += new System.EventHandler(this.btnRemSport_Click);
            // 
            // lblSpecSport
            // 
            this.lblSpecSport.AutoSize = true;
            this.lblSpecSport.Location = new System.Drawing.Point(235, 121);
            this.lblSpecSport.Name = "lblSpecSport";
            this.lblSpecSport.Size = new System.Drawing.Size(63, 13);
            this.lblSpecSport.TabIndex = 17;
            this.lblSpecSport.Text = "Sport Name";
            // 
            // txtSpecificSport
            // 
            this.txtSpecificSport.Location = new System.Drawing.Point(304, 118);
            this.txtSpecificSport.Name = "txtSpecificSport";
            this.txtSpecificSport.Size = new System.Drawing.Size(217, 20);
            this.txtSpecificSport.TabIndex = 16;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PeachPuff;
            this.btnClear.Location = new System.Drawing.Point(15, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 39);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHighestParticipant
            // 
            this.btnHighestParticipant.Location = new System.Drawing.Point(313, 12);
            this.btnHighestParticipant.Name = "btnHighestParticipant";
            this.btnHighestParticipant.Size = new System.Drawing.Size(194, 54);
            this.btnHighestParticipant.TabIndex = 20;
            this.btnHighestParticipant.Text = "Highest Participants";
            this.btnHighestParticipant.UseVisualStyleBackColor = true;
            this.btnHighestParticipant.Click += new System.EventHandler(this.btnHighestParticipant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 238);
            this.Controls.Add(this.btnHighestParticipant);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSpecSport);
            this.Controls.Add(this.txtSpecificSport);
            this.Controls.Add(this.btnRemSport);
            this.Controls.Add(this.btnSpecSport);
            this.Controls.Add(this.btnAddSport);
            this.Controls.Add(this.lblSportName);
            this.Controls.Add(this.txtRemSportName);
            this.Controls.Add(this.numNewSportParticipants);
            this.Controls.Add(this.lblSportPartic);
            this.Controls.Add(this.lblNewSport);
            this.Controls.Add(this.txtNewSport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnListAll);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(549, 277);
            this.MinimumSize = new System.Drawing.Size(549, 277);
            this.Name = "Form1";
            this.Text = "Sport Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNewSportParticipants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNewSport;
        private System.Windows.Forms.Label lblNewSport;
        private System.Windows.Forms.Label lblSportPartic;
        private System.Windows.Forms.NumericUpDown numNewSportParticipants;
        private System.Windows.Forms.Label lblSportName;
        private System.Windows.Forms.TextBox txtRemSportName;
        private System.Windows.Forms.Button btnAddSport;
        private System.Windows.Forms.Button btnSpecSport;
        private System.Windows.Forms.Button btnRemSport;
        private System.Windows.Forms.Label lblSpecSport;
        private System.Windows.Forms.TextBox txtSpecificSport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHighestParticipant;
    }
}

