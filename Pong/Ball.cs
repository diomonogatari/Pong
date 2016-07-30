using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Pong
{
    class Ball
    {
        public PictureBox picBall;
        int speedX, speedY;
        Random speedGenerator = new Random();
        Paddle one, two;


        public Ball(PictureBox Ball, Paddle PlayerOne, Paddle PlayerTwo)
        {
            picBall = Ball;
            generateSpeeds();
            one = PlayerOne;
            two = PlayerTwo;

        }
        public void Move()
        {
            checkTopBottomCollisions();
            checkPaddleCollision();
            picBall.Location = new Point(Math.Max(Form1.leftOfWorld,
                Math.Min(Form1.rightOfWorld,picBall.Location.X + speedX)),
                Math.Max(Form1.topOfWorld,
                Math.Min(Form1.botOfWorld - picBall.Height,picBall.Location.Y + speedY)));
        }
        private void checkTopBottomCollisions()
        {
            if(picBall.Location.Y == Form1.topOfWorld || picBall.Location.Y == Form1.botOfWorld - picBall.Height)//if touches left side
            {
                speedY = speedY * -1;
            }
        }
        public void generateSpeeds()
        {
            do
            {
                speedX = speedGenerator.Next(-4, 4);
                speedY = speedGenerator.Next(-4, 4);
            } while (Math.Abs(speedY) >= -1 && Math.Abs(speedY) <= 1 || Math.Abs(speedX) >= -1 && Math.Abs(speedX) <= 1);
        }
        private void checkPaddleCollision()
        {
            if(one.paddle.Bounds.IntersectsWith(picBall.Bounds) || two.paddle.Bounds.IntersectsWith(picBall.Bounds)) { 
                speedX *= -1;
                if (speedX < 0)
                    speedX--;
                else
                    speedX++;

            }
                
        }
    }
}
