namespace CSharpAssignment10
{
    partial class FlightInfo
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
            this.lblFlight = new System.Windows.Forms.Label();
            this.listPassengers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Location = new System.Drawing.Point(113, 19);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(53, 13);
            this.lblFlight.TabIndex = 1;
            this.lblFlight.Text = "Flight Info";
            // 
            // listPassengers
            // 
            this.listPassengers.FormattingEnabled = true;
            this.listPassengers.Location = new System.Drawing.Point(12, 49);
            this.listPassengers.Name = "listPassengers";
            this.listPassengers.Size = new System.Drawing.Size(267, 420);
            this.listPassengers.TabIndex = 2;
            // 
            // FlightInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 480);
            this.Controls.Add(this.listPassengers);
            this.Controls.Add(this.lblFlight);
            this.MaximumSize = new System.Drawing.Size(307, 519);
            this.MinimumSize = new System.Drawing.Size(307, 519);
            this.Name = "FlightInfo";
            this.Text = "FlightInfo";
            this.Load += new System.EventHandler(this.FlightInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.ListBox listPassengers;
    }
}