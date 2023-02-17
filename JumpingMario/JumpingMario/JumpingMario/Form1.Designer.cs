namespace JumpingMario
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
            this.scoreTable = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.obstacle = new System.Windows.Forms.PictureBox();
            this.mario = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreTable
            // 
            this.scoreTable.AutoSize = true;
            this.scoreTable.BackColor = System.Drawing.Color.Moccasin;
            this.scoreTable.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTable.Location = new System.Drawing.Point(12, 661);
            this.scoreTable.Name = "scoreTable";
            this.scoreTable.Size = new System.Drawing.Size(126, 37);
            this.scoreTable.TabIndex = 4;
            this.scoreTable.Text = "Wynik: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // obstacle
            // 
            this.obstacle.BackColor = System.Drawing.Color.Red;
            this.obstacle.Image = global::JumpingMario.Properties.Resources.mushroom2;
            this.obstacle.Location = new System.Drawing.Point(551, 513);
            this.obstacle.Name = "obstacle";
            this.obstacle.Size = new System.Drawing.Size(88, 129);
            this.obstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle.TabIndex = 5;
            this.obstacle.TabStop = false;
            // 
            // mario
            // 
            this.mario.Image = global::JumpingMario.Properties.Resources.mario;
            this.mario.Location = new System.Drawing.Point(112, 513);
            this.mario.Name = "mario";
            this.mario.Size = new System.Drawing.Size(93, 114);
            this.mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mario.TabIndex = 2;
            this.mario.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::JumpingMario.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-16, 633);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(655, 126);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(622, 707);
            this.Controls.Add(this.obstacle);
            this.Controls.Add(this.scoreTable);
            this.Controls.Add(this.mario);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game - Moo ICT";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            ((System.ComponentModel.ISupportInitialize)(this.obstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox mario;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreTable;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox obstacle;
    }
}

