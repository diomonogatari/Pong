using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        public static int moveSpeed = 3;
        private Point ballCenter = new Point(363, 208);
        public static int leftOfWorld, topOfWorld = 0, botOfWorld = 437, rightOfWorld = 725;
        public static Paddle player1;
        public static Paddle player2;
        Ball ball;
        public Form1()
        {
            InitializeComponent();
            player1 = new Paddle(picPaddle1, lblPlayer1);
            player2 = new Paddle(picPaddle2, lblPLayer2);
            ball = new Ball(picBall, player1, player2);
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            checkBallScoreCollisions();
            player1.Move(moveSpeed);
            player2.Move(moveSpeed);
            ball.Move();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            checkKeysPressed(e, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            checkKeysPressed(e, false);
        }
        private void checkKeysPressed(KeyEventArgs e, bool isDown)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    player1.moving = isDown;
                    player1.goingUp = true;
                    break;
                case Keys.W:
                    player2.moving = isDown;
                    player2.goingUp = true;
                    break;

                case Keys.Down:
                    player1.moving = isDown;
                    player1.goingUp = false;
                    break;
                case Keys.S:
                    player2.moving = isDown;
                    player2.goingUp = false;
                    break;
                case Keys.F12:
                    centerBall(ball);
                    break;
                case Keys.Escape:
                    Application.Exit();
                    break;
                case Keys.F5:
                    Application.Restart();
                    break;

            }
        }
        private void checkBallScoreCollisions()
        {
            if (ball.picBall.Location.X == Form1.leftOfWorld)
            {
                player2.Score++;
                player2.label.Text = player2.Score.ToString();
                centerBall(ball);
            }
            else if (ball.picBall.Location.X == Form1.rightOfWorld)
            {
                player1.Score++;
                player1.label.Text = player1.Score.ToString();
                centerBall(ball);
            }
        }
        private void centerBall(Ball Ball)
        {
            Ball.picBall.Location = ballCenter;
            Ball.generateSpeeds();
        }
    }
}
