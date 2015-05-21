namespace TournamentManager
{
    partial class WarningEmptyTeamAddForm
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
            this.buttonCloseWarning = new System.Windows.Forms.Button();
            this.labelTextWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCloseWarning
            // 
            this.buttonCloseWarning.Location = new System.Drawing.Point(80, 80);
            this.buttonCloseWarning.Name = "buttonCloseWarning";
            this.buttonCloseWarning.Size = new System.Drawing.Size(135, 33);
            this.buttonCloseWarning.TabIndex = 0;
            this.buttonCloseWarning.Text = "OK";
            this.buttonCloseWarning.UseVisualStyleBackColor = true;
            this.buttonCloseWarning.Click += new System.EventHandler(this.buttonCloseWarning_Click);
            // 
            // labelTextWarning
            // 
            this.labelTextWarning.AutoSize = true;
            this.labelTextWarning.Location = new System.Drawing.Point(52, 40);
            this.labelTextWarning.Name = "labelTextWarning";
            this.labelTextWarning.Size = new System.Drawing.Size(0, 13);
            this.labelTextWarning.TabIndex = 1;
            // 
            // WarningEmptyTeamAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 125);
            this.Controls.Add(this.labelTextWarning);
            this.Controls.Add(this.buttonCloseWarning);
            this.Name = "WarningEmptyTeamAddForm";
            this.Text = "Warning ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseWarning;
        private System.Windows.Forms.Label labelTextWarning;
    }
}