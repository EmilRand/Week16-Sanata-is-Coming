namespace Week16_Santa_Clause_is_Coming
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
            this.house = new System.Windows.Forms.PictureBox();
            this.moon = new System.Windows.Forms.PictureBox();
            this.santa = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.snowflake = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playAgain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.house)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).BeginInit();
            this.SuspendLayout();
            // 
            // house
            // 
            this.house.Image = ((System.Drawing.Image)(resources.GetObject("house.Image")));
            this.house.Location = new System.Drawing.Point(0, 474);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(304, 354);
            this.house.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.house.TabIndex = 0;
            this.house.TabStop = false;
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(0, 0);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(456, 301);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 1;
            this.moon.TabStop = false;
            // 
            // santa
            // 
            this.santa.Image = ((System.Drawing.Image)(resources.GetObject("santa.Image")));
            this.santa.Location = new System.Drawing.Point(357, 680);
            this.santa.Name = "santa";
            this.santa.Size = new System.Drawing.Size(360, 148);
            this.santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santa.TabIndex = 2;
            this.santa.TabStop = false;
            // 
            // tree
            // 
            this.tree.Image = ((System.Drawing.Image)(resources.GetObject("tree.Image")));
            this.tree.Location = new System.Drawing.Point(1533, 474);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(208, 350);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree.TabIndex = 3;
            this.tree.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 823);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(2039, 115);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // snowflake
            // 
            this.snowflake.Image = ((System.Drawing.Image)(resources.GetObject("snowflake.Image")));
            this.snowflake.Location = new System.Drawing.Point(1045, 71);
            this.snowflake.Name = "snowflake";
            this.snowflake.Size = new System.Drawing.Size(174, 143);
            this.snowflake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowflake.TabIndex = 5;
            this.snowflake.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.SystemColors.Window;
            this.playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.playAgain.Location = new System.Drawing.Point(867, 367);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(375, 133);
            this.playAgain.TabIndex = 6;
            this.playAgain.Text = "Play Again?";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.UseWaitCursor = true;
            this.playAgain.Click += new System.EventHandler(this.timer1_Tick);
            this.playAgain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keydown);
            this.playAgain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyup);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vineta BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1830, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2039, 988);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.snowflake);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.santa);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.house);
            this.Name = "Form1";
            this.Text = "background";
            ((System.ComponentModel.ISupportInitialize)(this.house)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox house;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox santa;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox snowflake;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Label label1;
    }
}

