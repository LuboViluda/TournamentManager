namespace TournamentManager
{
    partial class AddTeamsForm
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
            this.buttonNextTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.textBox1PlayerName = new System.Windows.Forms.TextBox();
            this.textBox2PlayerName = new System.Windows.Forms.TextBox();
            this.buttonCloseAddTeamsForm = new System.Windows.Forms.Button();
            this.labelCapacityTeams = new System.Windows.Forms.Label();
            this.labelBasketInfo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // buttonNextTeam
            // 
            this.buttonNextTeam.Location = new System.Drawing.Point(144, 198);
            this.buttonNextTeam.Name = "buttonNextTeam";
            this.buttonNextTeam.Size = new System.Drawing.Size(118, 39);
            this.buttonNextTeam.TabIndex = 4;
            this.buttonNextTeam.Text = "NextTeam";
            this.buttonNextTeam.UseVisualStyleBackColor = true;
            this.buttonNextTeam.Click += new System.EventHandler(this.buttonNextTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "First player name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Second player name";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.t.Location = new System.Drawing.Point(200, 9);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(62, 17);
            this.t.TabIndex = 6;
            this.t.Text = "Capacity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(289, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 4;
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(12, 66);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(183, 20);
            this.textBoxTeamName.TabIndex = 1;
            // 
            // textBox1PlayerName
            // 
            this.textBox1PlayerName.Location = new System.Drawing.Point(13, 109);
            this.textBox1PlayerName.Name = "textBox1PlayerName";
            this.textBox1PlayerName.Size = new System.Drawing.Size(151, 20);
            this.textBox1PlayerName.TabIndex = 2;
            // 
            // textBox2PlayerName
            // 
            this.textBox2PlayerName.Location = new System.Drawing.Point(12, 152);
            this.textBox2PlayerName.Name = "textBox2PlayerName";
            this.textBox2PlayerName.Size = new System.Drawing.Size(151, 20);
            this.textBox2PlayerName.TabIndex = 3;
            // 
            // buttonCloseAddTeamsForm
            // 
            this.buttonCloseAddTeamsForm.Location = new System.Drawing.Point(12, 198);
            this.buttonCloseAddTeamsForm.Name = "buttonCloseAddTeamsForm";
            this.buttonCloseAddTeamsForm.Size = new System.Drawing.Size(108, 39);
            this.buttonCloseAddTeamsForm.TabIndex = 5;
            this.buttonCloseAddTeamsForm.Text = "Close";
            this.buttonCloseAddTeamsForm.UseVisualStyleBackColor = true;
            this.buttonCloseAddTeamsForm.Click += new System.EventHandler(this.buttonCloseAddTeamsForm_Click);
            // 
            // labelCapacityTeams
            // 
            this.labelCapacityTeams.AutoSize = true;
            this.labelCapacityTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCapacityTeams.Location = new System.Drawing.Point(226, 31);
            this.labelCapacityTeams.Name = "labelCapacityTeams";
            this.labelCapacityTeams.Size = new System.Drawing.Size(36, 17);
            this.labelCapacityTeams.TabIndex = 7;
            this.labelCapacityTeams.Text = "0/16";
            // 
            // labelBasketInfo
            // 
            this.labelBasketInfo.AutoSize = true;
            this.labelBasketInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBasketInfo.Location = new System.Drawing.Point(12, 21);
            this.labelBasketInfo.Name = "labelBasketInfo";
            this.labelBasketInfo.Size = new System.Drawing.Size(141, 16);
            this.labelBasketInfo.TabIndex = 8;
            this.labelBasketInfo.Text = " Mens Teams to basket 1/4";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddTeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 258);
            this.ControlBox = false;
            this.Controls.Add(this.labelBasketInfo);
            this.Controls.Add(this.labelCapacityTeams);
            this.Controls.Add(this.buttonCloseAddTeamsForm);
            this.Controls.Add(this.textBox2PlayerName);
            this.Controls.Add(this.textBox1PlayerName);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNextTeam);
            this.Name = "AddTeamsForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "AddTeamsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNextTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.TextBox textBox1PlayerName;
        private System.Windows.Forms.TextBox textBox2PlayerName;
        private System.Windows.Forms.Button buttonCloseAddTeamsForm;
        private System.Windows.Forms.Label labelCapacityTeams;
        private System.Windows.Forms.Label labelBasketInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}