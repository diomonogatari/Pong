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
            this.lblPLayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 13;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // picPaddle2
            // 
            this.picPaddle2.Image = ((System.Drawing.Image)(resources.GetObject("picPaddle2.Image")));
            this.picPaddle2.Location = new System.Drawing.Point(12, 168);
            this.picPaddle2.Name = "picPaddle2";
            this.picPaddle2.Size = new System.Drawing.Size(20, 100);
            this.picPaddle2.TabIndex = 0;
            this.picPaddle2.TabStop = false;
            // 
            // picPaddle1
            // 
            this.picPaddle1.Image = ((System.Drawing.Image)(resources.GetObject("picPaddle1.Image")));
            this.picPaddle1.Location = new System.Drawing.Point(714, 168);
            this.picPaddle1.Name = "picPaddle1";
            this.picPaddle1.Size = new System.Drawing.Size(20, 100);
            this.picPaddle1.TabIndex = 1;
            this.picPaddle1.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(363, 208);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(20, 20);
            this.picBall.TabIndex = 2;
            this.picBall.TabStop = false;
            // 
            // lblPLayer2
            // 
            this.lblPLayer2.AutoSize = true;
            this.lblPLayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLayer2.ForeColor = System.Drawing.Color.Snow;
            this.lblPLayer2.Location = new System.Drawing.Point(334, 13);
            this.lblPLayer2.Name = "lblPLayer2";
            this.lblPLayer2.Size = new System.Drawing.Size(18, 20);
            this.lblPLayer2.TabIndex = 3;
            this.lblPLayer2.Text = "0";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.Snow;
            this.lblPlayer1.Location = new System.Drawing.Point(394, 13);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(18, 20);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(746, 436);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblPLayer2);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.PictureBox picPaddle2;
        private System.Windows.Forms.PictureBox picPaddle1;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Label lblPLayer2;
        private System.Windows.Forms.Label lblPlayer1;
    }
}

