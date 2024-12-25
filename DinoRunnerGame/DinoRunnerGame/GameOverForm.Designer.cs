namespace DinoRunnerGame
{
    partial class GameOverForm
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            lblScore = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 51.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(187, 25);
            label1.Name = "label1";
            label1.Size = new Size(396, 92);
            label1.TabIndex = 0;
            label1.Text = "Game Over";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(81, 258);
            button1.Name = "button1";
            button1.Size = new Size(277, 79);
            button1.TabIndex = 1;
            button1.Text = "Play Again";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(412, 258);
            button2.Name = "button2";
            button2.Size = new Size(277, 79);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Violet;
            label2.Location = new Point(178, 147);
            label2.Name = "label2";
            label2.Size = new Size(315, 65);
            label2.TabIndex = 0;
            label2.Text = "Your Score is";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.Violet;
            lblScore.Location = new Point(499, 147);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(56, 65);
            lblScore.TabIndex = 0;
            lblScore.Text = "0";
            // 
            // GameOverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(771, 382);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblScore);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GameOverForm";
            Text = "GameOverForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label lblScore;
    }
}