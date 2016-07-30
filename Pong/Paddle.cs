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
    public class Paddle
    {
        public PictureBox paddle;
        public bool moving = false;
        public bool? goingUp = null, wasMovingSameDirection;
        int ticksInSameDirection;
        public Label label;
        //double acceleration = 1.0;

        public int Score { get; set; } = 0;
        public string Name { get; set; }

        public Paddle(PictureBox Paddle, Label Label)
        {
            paddle = Paddle;
            label = Label;
        }
        public void Move(int speed)
        {
            if (moving)//AND not working
            {
                checkDirectionMovement();
                speed = (int)Math.Round(speed * ((float)ticksInSameDirection / 8));
                switch (goingUp)
                {
                    case true:
                        paddle.Location = new Point(paddle.Location.X,
                            Math.Max(Form1.topOfWorld,
                            Math.Min(Form1.botOfWorld - paddle.Height, paddle.Location.Y - speed)));
                        break;
                    case false:
                        paddle.Location = new Point(paddle.Location.X,
                            Math.Max(Form1.topOfWorld,
                            Math.Min(Form1.botOfWorld - paddle.Height, paddle.Location.Y + speed)));
                        break;
                }
            }
        }
        private void checkDirectionMovement()
        {
            if (wasMovingSameDirection.HasValue)
            {
                if (!goingUp.HasValue)
                {
                    wasMovingSameDirection = null;
                    ticksInSameDirection = 0;
                }
                else if (wasMovingSameDirection.Value == goingUp.Value)
                {
                    ticksInSameDirection++;
                }
                else
                {
                    wasMovingSameDirection = goingUp;
                    ticksInSameDirection = 1;
                }
            }
            else if (goingUp.HasValue)
            {
                wasMovingSameDirection = goingUp;
                ticksInSameDirection = 1;
            }
        }
    }
}
