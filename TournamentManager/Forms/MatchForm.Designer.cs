namespace TournamentManager
{
    partial class MatchForm
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.team1NameLabel = new System.Windows.Forms.Label();
            this.team2NameLabel = new System.Windows.Forms.Label();
            this.team1ScoreLabel = new System.Windows.Forms.Label();
            this.team2ScoreLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.periodShowLabel = new System.Windows.Forms.Label();
            this.startTimebutton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.team1Player1ScoreButton = new System.Windows.Forms.Button();
            this.team1Player2ScoreButton = new System.Windows.Forms.Button();
            this.team2Player1ScoreButton = new System.Windows.Forms.Button();
            this.team2Player2ScoreButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.FinishCloseButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.White;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 180F);
            this.timeLabel.Location = new System.Drawing.Point(393, 316);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(582, 274);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "5:00";
            // 
            // team1NameLabel
            // 
            this.team1NameLabel.AutoSize = true;
            this.team1NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.team1NameLabel.Location = new System.Drawing.Point(101, 70);
            this.team1NameLabel.Name = "team1NameLabel";
            this.team1NameLabel.Size = new System.Drawing.Size(164, 46);
            this.team1NameLabel.TabIndex = 1;
            this.team1NameLabel.Text = "TEAM 1";
            // 
            // team2NameLabel
            // 
            this.team2NameLabel.AutoSize = true;
            this.team2NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.team2NameLabel.Location = new System.Drawing.Point(986, 70);
            this.team2NameLabel.Name = "team2NameLabel";
            this.team2NameLabel.Size = new System.Drawing.Size(164, 46);
            this.team2NameLabel.TabIndex = 2;
            this.team2NameLabel.Text = "TEAM 2";
            // 
            // team1ScoreLabel
            // 
            this.team1ScoreLabel.AutoSize = true;
            this.team1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F);
            this.team1ScoreLabel.Location = new System.Drawing.Point(67, 245);
            this.team1ScoreLabel.Name = "team1ScoreLabel";
            this.team1ScoreLabel.Size = new System.Drawing.Size(206, 226);
            this.team1ScoreLabel.TabIndex = 3;
            this.team1ScoreLabel.Text = "0";
            // 
            // team2ScoreLabel
            // 
            this.team2ScoreLabel.AutoSize = true;
            this.team2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F);
            this.team2ScoreLabel.Location = new System.Drawing.Point(1039, 245);
            this.team2ScoreLabel.Name = "team2ScoreLabel";
            this.team2ScoreLabel.Size = new System.Drawing.Size(206, 226);
            this.team2ScoreLabel.TabIndex = 4;
            this.team2ScoreLabel.Text = "0";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.periodLabel.Location = new System.Drawing.Point(529, 8);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(290, 76);
            this.periodLabel.TabIndex = 5;
            this.periodLabel.Text = "PERIOD";
            // 
            // periodShowLabel
            // 
            this.periodShowLabel.AutoSize = true;
            this.periodShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.periodShowLabel.Location = new System.Drawing.Point(650, 84);
            this.periodShowLabel.Name = "periodShowLabel";
            this.periodShowLabel.Size = new System.Drawing.Size(66, 98);
            this.periodShowLabel.TabIndex = 6;
            this.periodShowLabel.Text = "I";
            // 
            // startTimebutton
            // 
            this.startTimebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.startTimebutton.Location = new System.Drawing.Point(393, 227);
            this.startTimebutton.Name = "startTimebutton";
            this.startTimebutton.Size = new System.Drawing.Size(151, 63);
            this.startTimebutton.TabIndex = 7;
            this.startTimebutton.Text = "Start";
            this.startTimebutton.UseVisualStyleBackColor = true;
            this.startTimebutton.Click += new System.EventHandler(this.startTimebutton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.stopButton.Location = new System.Drawing.Point(608, 227);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(151, 63);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // team1Player1ScoreButton
            // 
            this.team1Player1ScoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.team1Player1ScoreButton.Location = new System.Drawing.Point(48, 492);
            this.team1Player1ScoreButton.Name = "team1Player1ScoreButton";
            this.team1Player1ScoreButton.Size = new System.Drawing.Size(225, 73);
            this.team1Player1ScoreButton.TabIndex = 9;
            this.team1Player1ScoreButton.Text = "Player1";
            this.team1Player1ScoreButton.UseVisualStyleBackColor = true;
            this.team1Player1ScoreButton.Click += new System.EventHandler(this.team1Player1ScoreButton_Click);
            // 
            // team1Player2ScoreButton
            // 
            this.team1Player2ScoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.team1Player2ScoreButton.Location = new System.Drawing.Point(48, 597);
            this.team1Player2ScoreButton.Name = "team1Player2ScoreButton";
            this.team1Player2ScoreButton.Size = new System.Drawing.Size(225, 73);
            this.team1Player2ScoreButton.TabIndex = 10;
            this.team1Player2ScoreButton.Text = "Player2";
            this.team1Player2ScoreButton.UseVisualStyleBackColor = true;
            this.team1Player2ScoreButton.Click += new System.EventHandler(this.team1Player2ScoreButton_Click);
            // 
            // team2Player1ScoreButton
            // 
            this.team2Player1ScoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.team2Player1ScoreButton.Location = new System.Drawing.Point(1060, 492);
            this.team2Player1ScoreButton.Name = "team2Player1ScoreButton";
            this.team2Player1ScoreButton.Size = new System.Drawing.Size(225, 73);
            this.team2Player1ScoreButton.TabIndex = 11;
            this.team2Player1ScoreButton.Text = "Player1";
            this.team2Player1ScoreButton.UseVisualStyleBackColor = true;
            this.team2Player1ScoreButton.Click += new System.EventHandler(this.team2Player1ScoreButton_Click);
            // 
            // team2Player2ScoreButton
            // 
            this.team2Player2ScoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.team2Player2ScoreButton.Location = new System.Drawing.Point(1060, 597);
            this.team2Player2ScoreButton.Name = "team2Player2ScoreButton";
            this.team2Player2ScoreButton.Size = new System.Drawing.Size(225, 73);
            this.team2Player2ScoreButton.TabIndex = 12;
            this.team2Player2ScoreButton.Text = "Player2";
            this.team2Player2ScoreButton.UseVisualStyleBackColor = true;
            this.team2Player2ScoreButton.Click += new System.EventHandler(this.team2Player2ScoreButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Red;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(12, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(73, 72);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // FinishCloseButton
            // 
            this.FinishCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.FinishCloseButton.Location = new System.Drawing.Point(824, 227);
            this.FinishCloseButton.Name = "FinishCloseButton";
            this.FinishCloseButton.Size = new System.Drawing.Size(151, 63);
            this.FinishCloseButton.TabIndex = 14;
            this.FinishCloseButton.Text = "Close";
            this.FinishCloseButton.UseVisualStyleBackColor = true;
            this.FinishCloseButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.BackColor = System.Drawing.Color.Red;
            this.undoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.undoButton.ForeColor = System.Drawing.Color.Black;
            this.undoButton.Location = new System.Drawing.Point(12, 104);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(73, 72);
            this.undoButton.TabIndex = 16;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = false;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 723);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.FinishCloseButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.team2Player2ScoreButton);
            this.Controls.Add(this.team2Player1ScoreButton);
            this.Controls.Add(this.team1Player2ScoreButton);
            this.Controls.Add(this.team1Player1ScoreButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startTimebutton);
            this.Controls.Add(this.periodShowLabel);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.team2ScoreLabel);
            this.Controls.Add(this.team1ScoreLabel);
            this.Controls.Add(this.team2NameLabel);
            this.Controls.Add(this.team1NameLabel);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MatchForm";
            this.Text = "MatchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label team1NameLabel;
        private System.Windows.Forms.Label team2NameLabel;
        private System.Windows.Forms.Label team1ScoreLabel;
        private System.Windows.Forms.Label team2ScoreLabel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Label periodShowLabel;
        private System.Windows.Forms.Button startTimebutton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button team1Player1ScoreButton;
        private System.Windows.Forms.Button team1Player2ScoreButton;
        private System.Windows.Forms.Button team2Player1ScoreButton;
        private System.Windows.Forms.Button team2Player2ScoreButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button FinishCloseButton;
        private System.Windows.Forms.Button undoButton;
    }
}