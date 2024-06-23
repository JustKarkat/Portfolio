namespace CSHAssignment9
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
            this.listCountries = new System.Windows.Forms.ListBox();
            this.lblCountries = new System.Windows.Forms.Label();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.btnRemoveCountry = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblLargest = new System.Windows.Forms.Label();
            this.btnLargest = new System.Windows.Forms.Button();
            this.btnCurrentNum = new System.Windows.Forms.Button();
            this.lblNumCountries = new System.Windows.Forms.Label();
            this.groupSortBy = new System.Windows.Forms.GroupBox();
            this.radioSize = new System.Windows.Forms.RadioButton();
            this.radioPopulation = new System.Windows.Forms.RadioButton();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.groupSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCountries
            // 
            this.listCountries.FormattingEnabled = true;
            this.listCountries.Location = new System.Drawing.Point(34, 57);
            this.listCountries.Name = "listCountries";
            this.listCountries.Size = new System.Drawing.Size(237, 303);
            this.listCountries.TabIndex = 0;
            // 
            // lblCountries
            // 
            this.lblCountries.AutoSize = true;
            this.lblCountries.Location = new System.Drawing.Point(31, 41);
            this.lblCountries.Name = "lblCountries";
            this.lblCountries.Size = new System.Drawing.Size(51, 13);
            this.lblCountries.TabIndex = 1;
            this.lblCountries.Text = "Countries";
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Location = new System.Drawing.Point(34, 366);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(108, 72);
            this.btnAddCountry.TabIndex = 2;
            this.btnAddCountry.Text = "Add Country";
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnRemoveCountry
            // 
            this.btnRemoveCountry.Location = new System.Drawing.Point(148, 366);
            this.btnRemoveCountry.Name = "btnRemoveCountry";
            this.btnRemoveCountry.Size = new System.Drawing.Size(123, 45);
            this.btnRemoveCountry.TabIndex = 3;
            this.btnRemoveCountry.Text = "Remove Country";
            this.btnRemoveCountry.UseVisualStyleBackColor = true;
            this.btnRemoveCountry.Click += new System.EventHandler(this.btnRemoveCountry_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(291, 366);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(138, 72);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(29, 9);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(133, 25);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "CountryName";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(300, 57);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(129, 13);
            this.lblDisplay.TabIndex = 6;
            this.lblDisplay.Text = "Display all Info for Country";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(280, 73);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(171, 20);
            this.txtDisplay.TabIndex = 7;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(457, 71);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 9;
            this.btnDisplay.Text = "Enter";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblLargest
            // 
            this.lblLargest.AutoSize = true;
            this.lblLargest.Location = new System.Drawing.Point(289, 118);
            this.lblLargest.Name = "lblLargest";
            this.lblLargest.Size = new System.Drawing.Size(149, 13);
            this.lblLargest.TabIndex = 10;
            this.lblLargest.Text = "Display info for largest Country";
            // 
            // btnLargest
            // 
            this.btnLargest.Location = new System.Drawing.Point(457, 113);
            this.btnLargest.Name = "btnLargest";
            this.btnLargest.Size = new System.Drawing.Size(75, 23);
            this.btnLargest.TabIndex = 11;
            this.btnLargest.Text = "Enter";
            this.btnLargest.UseVisualStyleBackColor = true;
            this.btnLargest.Click += new System.EventHandler(this.btnLargest_Click);
            // 
            // btnCurrentNum
            // 
            this.btnCurrentNum.Location = new System.Drawing.Point(457, 159);
            this.btnCurrentNum.Name = "btnCurrentNum";
            this.btnCurrentNum.Size = new System.Drawing.Size(75, 23);
            this.btnCurrentNum.TabIndex = 13;
            this.btnCurrentNum.Text = "Enter";
            this.btnCurrentNum.UseVisualStyleBackColor = true;
            this.btnCurrentNum.Click += new System.EventHandler(this.btnCurrentNum_Click);
            // 
            // lblNumCountries
            // 
            this.lblNumCountries.AutoSize = true;
            this.lblNumCountries.Location = new System.Drawing.Point(277, 164);
            this.lblNumCountries.Name = "lblNumCountries";
            this.lblNumCountries.Size = new System.Drawing.Size(174, 13);
            this.lblNumCountries.TabIndex = 12;
            this.lblNumCountries.Text = "Display current number of Countries";
            // 
            // groupSortBy
            // 
            this.groupSortBy.Controls.Add(this.radioSize);
            this.groupSortBy.Controls.Add(this.radioPopulation);
            this.groupSortBy.Controls.Add(this.radioName);
            this.groupSortBy.Location = new System.Drawing.Point(292, 212);
            this.groupSortBy.Name = "groupSortBy";
            this.groupSortBy.Size = new System.Drawing.Size(240, 148);
            this.groupSortBy.TabIndex = 14;
            this.groupSortBy.TabStop = false;
            this.groupSortBy.Text = "SortBy";
            // 
            // radioSize
            // 
            this.radioSize.AutoSize = true;
            this.radioSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSize.Location = new System.Drawing.Point(11, 80);
            this.radioSize.Name = "radioSize";
            this.radioSize.Size = new System.Drawing.Size(53, 21);
            this.radioSize.TabIndex = 2;
            this.radioSize.TabStop = true;
            this.radioSize.Text = "Size";
            this.radioSize.UseVisualStyleBackColor = true;
            // 
            // radioPopulation
            // 
            this.radioPopulation.AutoSize = true;
            this.radioPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPopulation.Location = new System.Drawing.Point(11, 57);
            this.radioPopulation.Name = "radioPopulation";
            this.radioPopulation.Size = new System.Drawing.Size(93, 21);
            this.radioPopulation.TabIndex = 1;
            this.radioPopulation.TabStop = true;
            this.radioPopulation.Text = "Population";
            this.radioPopulation.UseVisualStyleBackColor = true;
            // 
            // radioName
            // 
            this.radioName.AutoSize = true;
            this.radioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioName.Location = new System.Drawing.Point(11, 34);
            this.radioName.Name = "radioName";
            this.radioName.Size = new System.Drawing.Size(63, 21);
            this.radioName.TabIndex = 0;
            this.radioName.TabStop = true;
            this.radioName.Text = "Name";
            this.radioName.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(435, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 72);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(148, 417);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(123, 20);
            this.txtRemove.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupSortBy);
            this.Controls.Add(this.btnCurrentNum);
            this.Controls.Add(this.lblNumCountries);
            this.Controls.Add(this.btnLargest);
            this.Controls.Add(this.lblLargest);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRemoveCountry);
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.lblCountries);
            this.Controls.Add(this.listCountries);
            this.MaximumSize = new System.Drawing.Size(574, 489);
            this.MinimumSize = new System.Drawing.Size(574, 489);
            this.Name = "Form1";
            this.Text = "Company Classes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupSortBy.ResumeLayout(false);
            this.groupSortBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCountries;
        private System.Windows.Forms.Label lblCountries;
        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.Button btnRemoveCountry;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblLargest;
        private System.Windows.Forms.Button btnLargest;
        private System.Windows.Forms.Button btnCurrentNum;
        private System.Windows.Forms.Label lblNumCountries;
        private System.Windows.Forms.GroupBox groupSortBy;
        private System.Windows.Forms.RadioButton radioSize;
        private System.Windows.Forms.RadioButton radioPopulation;
        private System.Windows.Forms.RadioButton radioName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtRemove;
    }
}

