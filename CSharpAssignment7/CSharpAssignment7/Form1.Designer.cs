namespace CSharpAssignment7
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupTravelClass = new System.Windows.Forms.GroupBox();
            this.radioEconomy = new System.Windows.Forms.RadioButton();
            this.radioBusiness = new System.Windows.Forms.RadioButton();
            this.radioFirst = new System.Windows.Forms.RadioButton();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.groupDate = new System.Windows.Forms.GroupBox();
            this.comboDestination = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.richConcerns = new System.Windows.Forms.RichTextBox();
            this.lblMedical = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupTravelClass.SuspendLayout();
            this.groupDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Customer Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 20);
            this.txtName.TabIndex = 1;
            // 
            // groupTravelClass
            // 
            this.groupTravelClass.Controls.Add(this.radioFirst);
            this.groupTravelClass.Controls.Add(this.radioBusiness);
            this.groupTravelClass.Controls.Add(this.radioEconomy);
            this.groupTravelClass.Location = new System.Drawing.Point(28, 51);
            this.groupTravelClass.Name = "groupTravelClass";
            this.groupTravelClass.Size = new System.Drawing.Size(280, 137);
            this.groupTravelClass.TabIndex = 2;
            this.groupTravelClass.TabStop = false;
            this.groupTravelClass.Text = "Travel Class";
            // 
            // radioEconomy
            // 
            this.radioEconomy.AutoSize = true;
            this.radioEconomy.Location = new System.Drawing.Point(85, 19);
            this.radioEconomy.Name = "radioEconomy";
            this.radioEconomy.Size = new System.Drawing.Size(97, 17);
            this.radioEconomy.TabIndex = 0;
            this.radioEconomy.TabStop = true;
            this.radioEconomy.Text = "Economy Class";
            this.radioEconomy.UseVisualStyleBackColor = true;
            // 
            // radioBusiness
            // 
            this.radioBusiness.AutoSize = true;
            this.radioBusiness.Location = new System.Drawing.Point(85, 55);
            this.radioBusiness.Name = "radioBusiness";
            this.radioBusiness.Size = new System.Drawing.Size(95, 17);
            this.radioBusiness.TabIndex = 1;
            this.radioBusiness.TabStop = true;
            this.radioBusiness.Text = "Business Class";
            this.radioBusiness.UseVisualStyleBackColor = true;
            // 
            // radioFirst
            // 
            this.radioFirst.AutoSize = true;
            this.radioFirst.Location = new System.Drawing.Point(85, 89);
            this.radioFirst.Name = "radioFirst";
            this.radioFirst.Size = new System.Drawing.Size(72, 17);
            this.radioFirst.TabIndex = 2;
            this.radioFirst.TabStop = true;
            this.radioFirst.Text = "First Class";
            this.radioFirst.UseVisualStyleBackColor = true;
            // 
            // comboYear
            // 
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(15, 54);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(121, 21);
            this.comboYear.TabIndex = 3;
            this.comboYear.Text = "Select a Year";
            // 
            // comboMonth
            // 
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Location = new System.Drawing.Point(142, 54);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(121, 21);
            this.comboMonth.TabIndex = 4;
            this.comboMonth.Text = "Select a Month";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 38);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(139, 38);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Month";
            // 
            // groupDate
            // 
            this.groupDate.Controls.Add(this.comboMonth);
            this.groupDate.Controls.Add(this.lblMonth);
            this.groupDate.Controls.Add(this.comboYear);
            this.groupDate.Controls.Add(this.lblYear);
            this.groupDate.Location = new System.Drawing.Point(28, 204);
            this.groupDate.Name = "groupDate";
            this.groupDate.Size = new System.Drawing.Size(280, 124);
            this.groupDate.TabIndex = 7;
            this.groupDate.TabStop = false;
            this.groupDate.Text = "Date";
            // 
            // comboDestination
            // 
            this.comboDestination.FormattingEnabled = true;
            this.comboDestination.Location = new System.Drawing.Point(347, 51);
            this.comboDestination.Name = "comboDestination";
            this.comboDestination.Size = new System.Drawing.Size(263, 21);
            this.comboDestination.TabIndex = 8;
            this.comboDestination.Text = "Select your Destination";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(443, 23);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(60, 13);
            this.lblDestination.TabIndex = 9;
            this.lblDestination.Text = "Destination";
            // 
            // richConcerns
            // 
            this.richConcerns.Location = new System.Drawing.Point(347, 106);
            this.richConcerns.Name = "richConcerns";
            this.richConcerns.Size = new System.Drawing.Size(263, 222);
            this.richConcerns.TabIndex = 10;
            this.richConcerns.Text = "";
            // 
            // lblMedical
            // 
            this.lblMedical.AutoSize = true;
            this.lblMedical.Location = new System.Drawing.Point(429, 84);
            this.lblMedical.Name = "lblMedical";
            this.lblMedical.Size = new System.Drawing.Size(92, 13);
            this.lblMedical.TabIndex = 11;
            this.lblMedical.Text = "Medical Concerns";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(28, 345);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(280, 90);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Display and Submit";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Location = new System.Drawing.Point(486, 345);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 90);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PeachPuff;
            this.btnClear.Location = new System.Drawing.Point(347, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 90);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblMedical);
            this.Controls.Add(this.richConcerns);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.comboDestination);
            this.Controls.Add(this.groupDate);
            this.Controls.Add(this.groupTravelClass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximumSize = new System.Drawing.Size(665, 489);
            this.MinimumSize = new System.Drawing.Size(665, 489);
            this.Name = "Form1";
            this.Text = "Travel Arrangements";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupTravelClass.ResumeLayout(false);
            this.groupTravelClass.PerformLayout();
            this.groupDate.ResumeLayout(false);
            this.groupDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupTravelClass;
        private System.Windows.Forms.RadioButton radioFirst;
        private System.Windows.Forms.RadioButton radioBusiness;
        private System.Windows.Forms.RadioButton radioEconomy;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.GroupBox groupDate;
        private System.Windows.Forms.ComboBox comboDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.RichTextBox richConcerns;
        private System.Windows.Forms.Label lblMedical;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
    }
}

