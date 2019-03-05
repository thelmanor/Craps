namespace Craps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.roll_btn = new System.Windows.Forms.Button();
            this.play_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.die1img = new System.Windows.Forms.PictureBox();
            this.die2img = new System.Windows.Forms.PictureBox();
            this.die3img = new System.Windows.Forms.PictureBox();
            this.die4img = new System.Windows.Forms.PictureBox();
            this.die5img = new System.Windows.Forms.PictureBox();
            this.die6img = new System.Windows.Forms.PictureBox();
            this.die1 = new System.Windows.Forms.PictureBox();
            this.die2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.die1img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die3img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die4img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die5img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die6img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2)).BeginInit();
            this.SuspendLayout();
            // 
            // roll_btn
            // 
            this.roll_btn.Location = new System.Drawing.Point(144, 124);
            this.roll_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roll_btn.Name = "roll_btn";
            this.roll_btn.Size = new System.Drawing.Size(113, 19);
            this.roll_btn.TabIndex = 2;
            this.roll_btn.Text = "Roll Dice";
            this.roll_btn.UseVisualStyleBackColor = true;
            this.roll_btn.Click += new System.EventHandler(this.roll_btn_Click);
            // 
            // play_btn
            // 
            this.play_btn.Location = new System.Drawing.Point(295, 124);
            this.play_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(89, 19);
            this.play_btn.TabIndex = 3;
            this.play_btn.Text = "Play Again";
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(243, 171);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(56, 19);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // die1img
            // 
            this.die1img.Image = ((System.Drawing.Image)(resources.GetObject("die1img.Image")));
            this.die1img.Location = new System.Drawing.Point(11, 10);
            this.die1img.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.die1img.Name = "die1img";
            this.die1img.Size = new System.Drawing.Size(77, 81);
            this.die1img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.die1img.TabIndex = 5;
            this.die1img.TabStop = false;
            this.die1img.Visible = false;
            // 
            // die2img
            // 
            this.die2img.Image = ((System.Drawing.Image)(resources.GetObject("die2img.Image")));
            this.die2img.Location = new System.Drawing.Point(100, 10);
            this.die2img.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.die2img.Name = "die2img";
            this.die2img.Size = new System.Drawing.Size(75, 81);
            this.die2img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die2img.TabIndex = 6;
            this.die2img.TabStop = false;
            this.die2img.Visible = false;
            // 
            // die3img
            // 
            this.die3img.Image = ((System.Drawing.Image)(resources.GetObject("die3img.Image")));
            this.die3img.Location = new System.Drawing.Point(194, 10);
            this.die3img.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.die3img.Name = "die3img";
            this.die3img.Size = new System.Drawing.Size(75, 81);
            this.die3img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die3img.TabIndex = 7;
            this.die3img.TabStop = false;
            this.die3img.Visible = false;
            // 
            // die4img
            // 
            this.die4img.Image = ((System.Drawing.Image)(resources.GetObject("die4img.Image")));
            this.die4img.Location = new System.Drawing.Point(286, 10);
            this.die4img.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.die4img.Name = "die4img";
            this.die4img.Size = new System.Drawing.Size(75, 81);
            this.die4img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die4img.TabIndex = 8;
            this.die4img.TabStop = false;
            this.die4img.Visible = false;
            // 
            // die5img
            // 
            this.die5img.Image = ((System.Drawing.Image)(resources.GetObject("die5img.Image")));
            this.die5img.Location = new System.Drawing.Point(381, 10);
            this.die5img.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.die5img.Name = "die5img";
            this.die5img.Size = new System.Drawing.Size(75, 81);
            this.die5img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die5img.TabIndex = 9;
            this.die5img.TabStop = false;
            this.die5img.Visible = false;
            // 
            // die6img
            // 
            this.die6img.Image = ((System.Drawing.Image)(resources.GetObject("die6img.Image")));
            this.die6img.Location = new System.Drawing.Point(482, 10);
            this.die6img.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.die6img.Name = "die6img";
            this.die6img.Size = new System.Drawing.Size(75, 81);
            this.die6img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die6img.TabIndex = 10;
            this.die6img.TabStop = false;
            this.die6img.Visible = false;
            // 
            // die1
            // 
            this.die1.Location = new System.Drawing.Point(113, 235);
            this.die1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(75, 68);
            this.die1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die1.TabIndex = 11;
            this.die1.TabStop = false;
            // 
            // die2
            // 
            this.die2.Location = new System.Drawing.Point(321, 235);
            this.die2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(75, 68);
            this.die2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die2.TabIndex = 12;
            this.die2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.die2);
            this.Controls.Add(this.die1);
            this.Controls.Add(this.die6img);
            this.Controls.Add(this.die5img);
            this.Controls.Add(this.die4img);
            this.Controls.Add(this.die3img);
            this.Controls.Add(this.die2img);
            this.Controls.Add(this.die1img);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.roll_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.die1img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die3img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die4img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die5img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die6img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button roll_btn;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox die1img;
        private System.Windows.Forms.PictureBox die2img;
        private System.Windows.Forms.PictureBox die3img;
        private System.Windows.Forms.PictureBox die4img;
        private System.Windows.Forms.PictureBox die5img;
        private System.Windows.Forms.PictureBox die6img;
        private System.Windows.Forms.PictureBox die1;
        private System.Windows.Forms.PictureBox die2;
    }
}

