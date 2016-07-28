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
        const int moveSpeed = 3;
        Paddle player1;
        Paddle player2;
        Ball ball;
        public Form1()
        {
            InitializeComponent();
            player1 = new Paddle(picPaddle1);
            player2 = new Paddle(picPaddle2);
            ball = new Ball(picBall);
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            player1.Move(moveSpeed);
            player2.Move(moveSpeed);
            
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

            }
        }
    }
}
