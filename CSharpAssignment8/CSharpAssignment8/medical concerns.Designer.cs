namespace CSharpAssignment8
{
    partial class medical_concerns
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
            this.lblConcerns = new System.Windows.Forms.Label();
            this.richConcerns = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConcerns
            // 
            this.lblConcerns.AutoSize = true;
            this.lblConcerns.Location = new System.Drawing.Point(24, 20);
            this.lblConcerns.Name = "lblConcerns";
            this.lblConcerns.Size = new System.Drawing.Size(106, 13);
            this.lblConcerns.TabIndex = 0;
            this.lblConcerns.Text = "Enter your Concerns.";
            // 
            // richConcerns
            // 
            this.richConcerns.Location = new System.Drawing.Point(27, 47);
            this.richConcerns.Name = "richConcerns";
            this.richConcerns.Size = new System.Drawing.Size(323, 297);
            this.richConcerns.TabIndex = 1;
            this.richConcerns.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(129, 364);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 56);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Confirm";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.Location = new System.Drawing.Point(247, 364);
            this.btnCancel.MaximumSize = new System.Drawing.Size(103, 56);
            this.btnCancel.MinimumSize = new System.Drawing.Size(103, 56);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 56);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // medical_concerns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 445);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.richConcerns);
            this.Controls.Add(this.lblConcerns);
            this.Name = "medical_concerns";
            this.Text = "Medical Concerns";
            this.Load += new System.EventHandler(this.medical_concerns_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConcerns;
        private System.Windows.Forms.RichTextBox richConcerns;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}