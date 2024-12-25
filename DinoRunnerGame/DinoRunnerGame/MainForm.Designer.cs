namespace DinoRunnerGame
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picGround1 = new PictureBox();
            picGround2 = new PictureBox();
            picGround3 = new PictureBox();
            picDino = new PictureBox();
            tmrDinoAnim = new System.Windows.Forms.Timer(components);
            tmrDinoFall = new System.Windows.Forms.Timer(components);
            tmrDinoJump = new System.Windows.Forms.Timer(components);
            tmrCloud = new System.Windows.Forms.Timer(components);
            tmrCloudSlide = new System.Windows.Forms.Timer(components);
            tmrSlideObstacle = new System.Windows.Forms.Timer(components);
            tmrObstacle = new System.Windows.Forms.Timer(components);
            pnlCollision = new Panel();
            tmrBirdAnim = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lblScore = new Label();
            tmrScore = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picGround1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGround2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGround3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDino).BeginInit();
            SuspendLayout();
            // 
            // picGround1
            // 
            picGround1.BackgroundImage = Properties.Resources.Ground;
            picGround1.BackgroundImageLayout = ImageLayout.Stretch;
            picGround1.Location = new Point(-5, 531);
            picGround1.Name = "picGround1";
            picGround1.Size = new Size(368, 78);
            picGround1.TabIndex = 0;
            picGround1.TabStop = false;
            // 
            // picGround2
            // 
            picGround2.BackgroundImage = Properties.Resources.Ground;
            picGround2.BackgroundImageLayout = ImageLayout.Stretch;
            picGround2.Location = new Point(333, 531);
            picGround2.Name = "picGround2";
            picGround2.Size = new Size(368, 78);
            picGround2.TabIndex = 0;
            picGround2.TabStop = false;
            // 
            // picGround3
            // 
            picGround3.BackgroundImage = Properties.Resources.Ground;
            picGround3.BackgroundImageLayout = ImageLayout.Stretch;
            picGround3.Location = new Point(670, 531);
            picGround3.Name = "picGround3";
            picGround3.Size = new Size(368, 78);
            picGround3.TabIndex = 0;
            picGround3.TabStop = false;
            // 
            // picDino
            // 
            picDino.BackColor = Color.Transparent;
            picDino.BackgroundImage = Properties.Resources.DinoRun1;
            picDino.BackgroundImageLayout = ImageLayout.None;
            picDino.Location = new Point(65, 428);
            picDino.Name = "picDino";
            picDino.Size = new Size(127, 101);
            picDino.TabIndex = 1;
            picDino.TabStop = false;
            // 
            // tmrDinoAnim
            // 
            tmrDinoAnim.Enabled = true;
            tmrDinoAnim.Interval = 75;
            tmrDinoAnim.Tick += tmrDinoAnim_Tick;
            // 
            // tmrDinoFall
            // 
            tmrDinoFall.Interval = 16;
            tmrDinoFall.Tick += tmrDinoFall_Tick;
            // 
            // tmrDinoJump
            // 
            tmrDinoJump.Interval = 14;
            tmrDinoJump.Tick += tmrDinoJump_Tick;
            // 
            // tmrCloud
            // 
            tmrCloud.Enabled = true;
            tmrCloud.Interval = 75;
            tmrCloud.Tick += tmrCloud_Tick;
            // 
            // tmrCloudSlide
            // 
            tmrCloudSlide.Enabled = true;
            tmrCloudSlide.Interval = 50;
            tmrCloudSlide.Tick += tmrCloudSlide_Tick;
            // 
            // tmrSlideObstacle
            // 
            tmrSlideObstacle.Enabled = true;
            tmrSlideObstacle.Interval = 20;
            tmrSlideObstacle.Tick += tmrSlideObstacle_Tick;
            // 
            // tmrObstacle
            // 
            tmrObstacle.Enabled = true;
            tmrObstacle.Interval = 1000;
            tmrObstacle.Tick += tmrObstacle_Tick;
            // 
            // pnlCollision
            // 
            pnlCollision.BackColor = Color.Red;
            pnlCollision.Location = new Point(108, 428);
            pnlCollision.Name = "pnlCollision";
            pnlCollision.Size = new Size(35, 101);
            pnlCollision.TabIndex = 3;
            // 
            // tmrBirdAnim
            // 
            tmrBirdAnim.Enabled = true;
            tmrBirdAnim.Tick += tmrBirdAnim_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 51);
            label1.TabIndex = 4;
            label1.Text = "Score";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.Black;
            lblScore.Location = new Point(122, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(45, 51);
            lblScore.TabIndex = 4;
            lblScore.Text = "0";
            // 
            // tmrScore
            // 
            tmrScore.Enabled = true;
            tmrScore.Interval = 200;
            tmrScore.Tick += tmrScore_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 218, 228);
            ClientSize = new Size(984, 607);
            Controls.Add(lblScore);
            Controls.Add(label1);
            Controls.Add(pnlCollision);
            Controls.Add(picDino);
            Controls.Add(picGround3);
            Controls.Add(picGround2);
            Controls.Add(picGround1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DinoRunnerGame";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)picGround1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGround2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGround3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDino).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picGround1;
        private PictureBox picGround2;
        private PictureBox picGround3;
        private PictureBox picDino;
        private System.Windows.Forms.Timer tmrDinoAnim;
        private System.Windows.Forms.Timer tmrDinoFall;
        private System.Windows.Forms.Timer tmrDinoJump;
        private System.Windows.Forms.Timer tmrCloud;
        private System.Windows.Forms.Timer tmrCloudSlide;
        private System.Windows.Forms.Timer tmrSlideObstacle;
        private System.Windows.Forms.Timer tmrObstacle;
        private Panel pnlCollision;
        private System.Windows.Forms.Timer tmrBirdAnim;
        private Label label1;
        private Label lblScore;
        private System.Windows.Forms.Timer tmrScore;
    }
}
