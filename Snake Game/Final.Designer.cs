namespace Snake_Game
{
    partial class Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Final));
            this.label1 = new System.Windows.Forms.Label();
            this.endGame = new System.Windows.Forms.Label();
            this.lbFinalScore = new System.Windows.Forms.Label();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // endGame
            // 
            this.endGame.AutoSize = true;
            this.endGame.Font = new System.Drawing.Font("Commodore 64 Pixeled", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGame.ForeColor = System.Drawing.Color.White;
            this.endGame.Location = new System.Drawing.Point(49, 9);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(190, 24);
            this.endGame.TabIndex = 1;
            this.endGame.Text = "GAME OVER";
            this.endGame.Click += new System.EventHandler(this.endGame_Click);
            // 
            // lbFinalScore
            // 
            this.lbFinalScore.AutoSize = true;
            this.lbFinalScore.Font = new System.Drawing.Font("Commodore 64 Pixeled", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinalScore.ForeColor = System.Drawing.Color.White;
            this.lbFinalScore.Location = new System.Drawing.Point(70, 99);
            this.lbFinalScore.Name = "lbFinalScore";
            this.lbFinalScore.Size = new System.Drawing.Size(137, 20);
            this.lbFinalScore.TabIndex = 2;
            this.lbFinalScore.Text = "SCORE: 0";
            this.lbFinalScore.Click += new System.EventHandler(this.lbFinalScore_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEndGame.Font = new System.Drawing.Font("Commodore 64 Pixeled", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEndGame.Location = new System.Drawing.Point(114, 173);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(52, 20);
            this.btnEndGame.TabIndex = 5;
            this.btnEndGame.Text = "OK";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.lbFinalScore);
            this.Controls.Add(this.endGame);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Final";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label endGame;
        private System.Windows.Forms.Label lbFinalScore;
        private System.Windows.Forms.Button btnEndGame;
    }
}