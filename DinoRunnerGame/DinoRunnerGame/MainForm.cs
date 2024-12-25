namespace DinoRunnerGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        PictureBox cloud;
        List<PictureBox> clouds = new List<PictureBox>();
        List<PictureBox> removeClouds = new List<PictureBox>();
        PictureBox picWood;
        PictureBox picSpike;
        PictureBox picBird;
        List<PictureBox> obstacle;
        List<PictureBox> removeobstacle = new List<PictureBox>();
        List<PictureBox> birdsAnim = new List<PictureBox>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.KeyDown += KeyDownControl;
            this.KeyUp += KeyUpControl;
            cloud = new PictureBox();
            obstacle = new List<PictureBox>();
            pnlCollision.SendToBack();
            pnlCollision.BackColor = Color.Transparent;
        }

        private void KeyUpControl(object? sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Down) && canJump)
            {
                tmrDinoAnim.Start();
                pnlCollision.Size = new Size(35, 101);
                pnlCollision.Location = new Point(108, 428);
            }
        }

        int jumpPower = 22;
        int gravity = 8;
        int jumpTime = 12;
        int obstacleSpeed = 10;

        bool canJump = true;
        private void KeyDownControl(object? sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space || e.KeyCode == Keys.Up) && canJump)
            {
                tmrDinoAnim.Stop();
                tmrDinoJump.Start();
                picDino.BackgroundImage = Properties.Resources.DinoJump;
                canJump = false;
            }
            else if ((e.KeyCode == Keys.Down) && canJump)
            {
                tmrDinoAnim.Stop();
                pnlCollision.Size = new Size(35, 53);
                pnlCollision.Location = new Point(111, 474);
                picDino.BackgroundImage = Properties.Resources.DinoCrouch;
            }
        }

        private void tmrDinoJump_Tick(object sender, EventArgs e)
        {
            if (jumpTime > 0)
            {
                picDino.Location = new Point(picDino.Location.X, picDino.Location.Y - jumpPower);
                pnlCollision.Location = new Point(pnlCollision.Location.X, pnlCollision.Location.Y - jumpPower);
            }
            else
            {
                jumpTime = 12;
                tmrDinoJump.Stop();
                tmrDinoFall.Start();
            }
            jumpTime--;

        }

        private void tmrDinoFall_Tick(object sender, EventArgs e)
        {
            picDino.Location = new Point(picDino.Location.X, picDino.Location.Y + gravity);
            pnlCollision.Location = new Point(pnlCollision.Location.X, pnlCollision.Location.Y + gravity);

            if (picDino.Location.Y >= 426)
            {
                tmrDinoFall.Stop();
                tmrDinoAnim.Start();
                canJump = true;
            }
        }

        int dinoAnim = 1;
        private void tmrDinoAnim_Tick(object sender, EventArgs e)
        {
            picDino.BackColor = Color.Transparent;
            switch (dinoAnim)
            {
                case 1:
                    picDino.BackgroundImage = Properties.Resources.DinoRun1;
                    break;
                case 2:
                    picDino.BackgroundImage = Properties.Resources.DinoRun2;
                    break;
                case 3:
                    picDino.BackgroundImage = Properties.Resources.DinoRun3;
                    break;
                case 4:
                    picDino.BackgroundImage = Properties.Resources.DinoRun4;
                    break;
                case 5:
                    picDino.BackgroundImage = Properties.Resources.DinoRun5;
                    break;
                case 6:
                    picDino.BackgroundImage = Properties.Resources.DinoRun6;
                    dinoAnim = 1;
                    break;
            }
            dinoAnim++;
        }

        private void tmrCloud_Tick(object sender, EventArgs e)
        {
            tmrCloud.Interval = 5800;
            cloud = new PictureBox();
            cloud.BackgroundImage = Properties.Resources.Cloud;
            cloud.Size = new Size(260, 100);
            cloud.Location = new Point(850, 10);
            cloud.BackColor = Color.Transparent;
            cloud.BackgroundImageLayout = ImageLayout.Zoom;
            this.Controls.Add(cloud);
            clouds.Add(cloud);
        }

        private void tmrCloudSlide_Tick(object sender, EventArgs e)
        {
            foreach (var cloud in clouds)
            {
                cloud.Location = new Point(cloud.Location.X - 8, cloud.Location.Y);

                if (cloud.Location.X < -120)
                {
                    removeClouds.Add(cloud);
                }
            }
            foreach (var cloud in removeClouds)
            {
                this.Controls.Remove(cloud);
                clouds.Remove(cloud);
            }
            removeClouds.Clear();
        }

        int randomObstacle;
        private void tmrObstacle_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tmrObstacle.Interval = rnd.Next(1240, 2350);

            randomObstacle = rnd.Next(1, 4);

            if (randomObstacle == 1)
            {
                picWood = new PictureBox();
                picWood.Size = new Size(61, 128);
                picWood.Location = new Point(1000, 410);
                picWood.BackgroundImageLayout = ImageLayout.Center;
                picWood.BackgroundImage = Properties.Resources.Wood;
                obstacle.Add(picWood);
                this.Controls.Add(picWood);
            }
            else if (randomObstacle == 2)
            {
                picSpike = new PictureBox();
                picSpike.Size = new Size(136, 76);
                picSpike.Location = new Point(1000, 456);
                picSpike.BackgroundImageLayout = ImageLayout.Stretch;
                picSpike.BackgroundImage = Properties.Resources.Spike;
                obstacle.Add(picSpike);
                this.Controls.Add(picSpike);
            }
            else if (randomObstacle == 3)
            {
                picBird = new PictureBox();
                picBird.Size = new Size(72, 72);
                picBird.Location = new Point(1000, 383);
                picBird.BackgroundImageLayout = ImageLayout.Zoom;
                obstacle.Add(picBird);
                birdsAnim.Add(picBird);
                this.Controls.Add(picBird);
            }
        }

        private void tmrSlideObstacle_Tick(object sender, EventArgs e)
        {
            foreach (var item in obstacle)
            {
                item.Location = new Point(item.Location.X - obstacleSpeed, item.Location.Y);
                if (pnlCollision.Bounds.IntersectsWith(item.Bounds))
                {
                    tmrSlideObstacle.Stop();
                    GameOver();
                }
                if (item.Location.X < -120)
                {
                    removeobstacle.Add(item);
                }
            }

            foreach (var obstacleItem in removeobstacle)
            {
                this.Controls.Remove(obstacleItem);
                obstacle.Remove(obstacleItem);
            }
            removeobstacle.Clear();

        }

        int birdAnim = 1;

        private void tmrBirdAnim_Tick(object sender, EventArgs e)
        {
            foreach (var item in birdsAnim)
            {
                item.BringToFront();
                switch (birdAnim)
                {
                    case 1:
                        item.BackgroundImage = Properties.Resources.Bird1;
                        break;
                    case 2:
                        item.BackgroundImage = Properties.Resources.Bird2;
                        break;
                    case 3:
                        item.BackgroundImage = Properties.Resources.Bird3;
                        birdAnim = 0;
                        break;
                }
                birdAnim++;
            }
        }
        private void GameOver()
        {
            GameOverForm gameOver = new GameOverForm();
            gameOver.Show();
            this.Hide();
        }

        int score = 0;

        private void tmrScore_Tick(object sender, EventArgs e)
        {
            lblScore.Text = score.ToString();
            score++;
        }
    }
}
