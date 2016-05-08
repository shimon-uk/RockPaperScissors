namespace UI.WIN
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
            this.GameType = new System.Windows.Forms.ComboBox();
            this.GameSeries = new System.Windows.Forms.ComboBox();
            this.GenerateGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Label();
            this.GameBox = new System.Windows.Forms.GroupBox();
            this.GameOptionBox = new System.Windows.Forms.GroupBox();
            this.GameOptions = new System.Windows.Forms.ListBox();
            this.Play = new System.Windows.Forms.Button();
            this.ScoresPanel = new System.Windows.Forms.Panel();
            this.Player2Scores = new System.Windows.Forms.Label();
            this.Player1Scores = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GameBox.SuspendLayout();
            this.GameOptionBox.SuspendLayout();
            this.ScoresPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameType
            // 
            this.GameType.FormattingEnabled = true;
            this.GameType.Location = new System.Drawing.Point(105, 64);
            this.GameType.Name = "GameType";
            this.GameType.Size = new System.Drawing.Size(121, 24);
            this.GameType.TabIndex = 0;
            // 
            // GameSeries
            // 
            this.GameSeries.FormattingEnabled = true;
            this.GameSeries.Location = new System.Drawing.Point(326, 64);
            this.GameSeries.Name = "GameSeries";
            this.GameSeries.Size = new System.Drawing.Size(121, 24);
            this.GameSeries.TabIndex = 1;
            // 
            // GenerateGame
            // 
            this.GenerateGame.Location = new System.Drawing.Point(539, 41);
            this.GenerateGame.Name = "GenerateGame";
            this.GenerateGame.Size = new System.Drawing.Size(119, 47);
            this.GenerateGame.TabIndex = 2;
            this.GenerateGame.Text = "GenerateGame";
            this.GenerateGame.UseVisualStyleBackColor = true;
            this.GenerateGame.Click += new System.EventHandler(this.GenerateGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Game Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Game Series";
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Results.Location = new System.Drawing.Point(103, 331);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(115, 36);
            this.Results.TabIndex = 8;
            this.Results.Text = "Results";
            // 
            // GameBox
            // 
            this.GameBox.Controls.Add(this.ScoresPanel);
            this.GameBox.Controls.Add(this.GameOptionBox);
            this.GameBox.Controls.Add(this.Play);
            this.GameBox.Location = new System.Drawing.Point(105, 105);
            this.GameBox.Name = "GameBox";
            this.GameBox.Size = new System.Drawing.Size(829, 199);
            this.GameBox.TabIndex = 14;
            this.GameBox.TabStop = false;
            this.GameBox.Text = "groupBox1";
            // 
            // GameOptionBox
            // 
            this.GameOptionBox.Controls.Add(this.GameOptions);
            this.GameOptionBox.Location = new System.Drawing.Point(28, 51);
            this.GameOptionBox.Name = "GameOptionBox";
            this.GameOptionBox.Size = new System.Drawing.Size(175, 125);
            this.GameOptionBox.TabIndex = 16;
            this.GameOptionBox.TabStop = false;
            this.GameOptionBox.Text = "Player 1 Game Options";
            this.GameOptionBox.Visible = false;
            // 
            // GameOptions
            // 
            this.GameOptions.FormattingEnabled = true;
            this.GameOptions.ItemHeight = 16;
            this.GameOptions.Location = new System.Drawing.Point(39, 28);
            this.GameOptions.Name = "GameOptions";
            this.GameOptions.Size = new System.Drawing.Size(120, 84);
            this.GameOptions.TabIndex = 8;
            // 
            // Play
            // 
            this.Play.Enabled = false;
            this.Play.Location = new System.Drawing.Point(256, 60);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(205, 103);
            this.Play.TabIndex = 14;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // ScoresPanel
            // 
            this.ScoresPanel.Controls.Add(this.Player2Scores);
            this.ScoresPanel.Controls.Add(this.Player1Scores);
            this.ScoresPanel.Controls.Add(this.label5);
            this.ScoresPanel.Location = new System.Drawing.Point(494, 51);
            this.ScoresPanel.Name = "ScoresPanel";
            this.ScoresPanel.Size = new System.Drawing.Size(277, 125);
            this.ScoresPanel.TabIndex = 17;
            // 
            // Player2Scores
            // 
            this.Player2Scores.AutoSize = true;
            this.Player2Scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Scores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Player2Scores.Location = new System.Drawing.Point(53, 72);
            this.Player2Scores.Name = "Player2Scores";
            this.Player2Scores.Size = new System.Drawing.Size(56, 18);
            this.Player2Scores.TabIndex = 21;
            this.Player2Scores.Text = "Scores";
            // 
            // Player1Scores
            // 
            this.Player1Scores.AutoSize = true;
            this.Player1Scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Scores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Player1Scores.Location = new System.Drawing.Point(50, 38);
            this.Player1Scores.Name = "Player1Scores";
            this.Player1Scores.Size = new System.Drawing.Size(56, 18);
            this.Player1Scores.TabIndex = 20;
            this.Player1Scores.Text = "Scores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Game Set Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 466);
            this.Controls.Add(this.GameBox);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateGame);
            this.Controls.Add(this.GameSeries);
            this.Controls.Add(this.GameType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GameBox.ResumeLayout(false);
            this.GameOptionBox.ResumeLayout(false);
            this.ScoresPanel.ResumeLayout(false);
            this.ScoresPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GameType;
        private System.Windows.Forms.ComboBox GameSeries;
        private System.Windows.Forms.Button GenerateGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.GroupBox GameBox;
        private System.Windows.Forms.GroupBox GameOptionBox;
        private System.Windows.Forms.ListBox GameOptions;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Panel ScoresPanel;
        private System.Windows.Forms.Label Player2Scores;
        private System.Windows.Forms.Label Player1Scores;
        private System.Windows.Forms.Label label5;
    }
}

