using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week16_Santa_Clause_is_Coming
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipeSpeed = 6;
        int score = 0;
        int backroundSpeed = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tree_Click(object sender, EventArgs e)
        {

        }

        private void snowflake_Click(object sender, EventArgs e)
        {

        }

        private void moon_Click(object sender, EventArgs e)
        {

        }

        private void house_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            santa.Top += gravity;
            snowflake.Left -= pipeSpeed;
            tree.Left -= pipeSpeed;
            moon.Left -= backroundSpeed;
            house.Left -= backroundSpeed;
            label1.Text = $"score: {score}";

            if (snowflake.Left < -140)
            {
                snowflake.Left = 650;
            }
            if (tree.Left < -90)
            {
                tree.Left = 620;
                score++;
            }
            if (moon.Left < -100)
            {
                moon.Left = 800;
            }
            if (house.Left < -140)
            {
                house.Left = 750;
            }
            if (santa.Top < -25)
            {
                gameOver();
            }
            if (santa.Bounds.IntersectsWith(snowflake.Bounds) || santa.Bounds.IntersectsWith(tree.Bounds) || santa.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }
        }

        private void Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void gameOver()
        {
            timer1.Stop();
            label1.Text = $"Game Over";
            playAgain.Visible = true;
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }

}
