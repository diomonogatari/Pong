using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Pong;

namespace Pong
{
    class Paddle
    {
        PictureBox paddle;
        public bool moving = false;
        public bool? goingUp = null;

        public Paddle(PictureBox Paddle)
        {
            paddle = Paddle;
        }
        public void Move(int speed)
        {
            if (moving)
            {
                switch (goingUp)
                {
                    case true:
                        paddle.Location = new Point(paddle.Location.X, paddle.Location.Y - speed);
                        break;
                    case false:
                        paddle.Location = new Point(paddle.Location.X, paddle.Location.Y + speed);
                        break;
                }
            }
            //find direction
            //move that direction
        }
    }
}
