using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingMario
{
    public partial class Form1 : Form
    {

        // coded for MOO ICT Flappy Bird Tutorial

        // Variables start here

        int pipeSpeed = 5; // default pipe speed defined with an integer
        int gravity = 0; // default gravity speed defined with an integer
        int score = 0; // default score integer set to 0
        // variable ends

        Player player;
        Enemy enemy;
        Judge judge;

        public Form1()
        {
            InitializeComponent();

            player = new Player(mario);
            judge = new Judge(scoreTable);

            enemy = new Enemy(obstacle, judge);
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                player.Jump();
            }
        }

        private void endGame()
        {
            // this is the game end function, this function will when the bird touches the ground or the pipes
            gameTimer.Stop(); // stop the main timer
            judge.endGame(); // show the game over text on the score text, += is used to add the new string of text next to the score instead of overriding it
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            player.Update();
            enemy.Update();
            judge.Update();

            if (CollisionDetector.DetectCollision(player, enemy))
            {
                endGame();
            }
        }
    }

    public class GameObject
    {
        public PictureBox pictureBox;
        protected int speed;

        public GameObject(PictureBox pictureBox, int speed)
        {
            this.pictureBox = pictureBox;
            this.speed = speed;
        }

        public virtual void Update()
        {
            pictureBox.Left -= speed;
            if (pictureBox.Left < -pictureBox.Width)
            {
                pictureBox.Left = pictureBox.Parent.Width;
            }
        }

        public void speedUp()
        {
            speed++;
        }
    }

    public class Player : GameObject
    {
        PictureBox picture;
        private int gravity = 10;
        public Player(PictureBox pictureBox) : base(pictureBox, 0)
        {
            picture = pictureBox;
        }

        public override void Update()
        {
            base.Update();

            if (pictureBox.Top >= 550)
            {
                gravity = 0;
                pictureBox.Top -= 2;
            }

            if (pictureBox.Top <= 300)
            {
                gravity = 5;
            }

            pictureBox.Top += gravity;
        }

        public void Jump()
        {
            if (pictureBox.Top >= 500)
            {
                gravity = -10;
            }
        }
    }

    public class Enemy : GameObject
    {
        private const int PIPE_GAP = 120;
        PictureBox picture;
        Judge judge;
        public int Position;
        private int speed = 8;
        public Enemy(PictureBox pictureBox, Judge j) : base(pictureBox, 8)
        {
            picture = pictureBox;
            judge = j;
        }
       
    public override void Update()
    {
        base.Update();
            Position = picture.Left;
            if (picture.Left <= -60)
            {
                picture.Left = 800;
                judge.addScore();

                if(judge.getScore() % 5 == 0) //przyspiesza co 5 punktów
                    this.speedUp();

                Random random = new Random();
                int randomNumber = random.Next(1, 3);

                if (randomNumber == 1)
                    pictureBox.Image = JumpingMario.Properties.Resources.mushroom;
                else if (randomNumber == 2)
                    pictureBox.Image = JumpingMario.Properties.Resources.mushroom1;
                else if (randomNumber == 3)
                    pictureBox.Image = JumpingMario.Properties.Resources.mushroom2;
            }

           
        }
    }

    public class Judge
    {
        private int score = 0;
        Label scoreTable;

        public Judge(Label label)
        {
            scoreTable = label;
        }

        public void Update()
        {
            scoreTable.Text = "Wynik: " + score;
        }

        public void addScore()
        {
            score += 1;
        }
        public void endGame()
        {
            scoreTable.Text = "Koniec gry! Twój wynik: " + score;
        }

        public int getScore()
        {
            return score;
        }
    }

    public static class CollisionDetector
    {
        public static bool DetectCollision(GameObject object1, GameObject object2)
        {
            return object1.pictureBox.Bounds.IntersectsWith(object2.pictureBox.Bounds);
        }
    }

}
