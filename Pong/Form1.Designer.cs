namespace Pong
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.picPaddle2 = new System.Windows.Forms.PictureBox();
            this.picPaddle1 = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 10;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // picPaddle2
            // 
            this.picPaddle2.Image = ((System.Drawing.Image)(resources.GetObject("picPaddle2.Image")));
            this.picPaddle2.Location = new System.Drawing.Point(12, 157);
            this.picPaddle2.Name = "picPaddle2";
            this.picPaddle2.Size = new System.Drawing.Size(20, 100);
            this.picPaddle2.TabIndex = 0;
            this.picPaddle2.TabStop = false;
            // 
            // picPaddle1
            // 
            this.picPaddle1.Image = ((System.Drawing.Image)(resources.GetObject("picPaddle1.Image")));
            this.picPaddle1.Location = new System.Drawing.Point(714, 157);
            this.picPaddle1.Name = "picPaddle1";
            this.picPaddle1.Size = new System.Drawing.Size(20, 100);
            this.picPaddle1.TabIndex = 1;
            this.picPaddle1.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(365, 200);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(20, 20);
            this.picBall.TabIndex = 2;
            this.picBall.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(746, 436);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picPaddle1);
            this.Controls.Add(this.picPaddle2);
            this.Name = "Form1";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.PictureBox picPaddle2;
        private System.Windows.Forms.PictureBox picPaddle1;
        private System.Windows.Forms.PictureBox picBall;
    }
}

