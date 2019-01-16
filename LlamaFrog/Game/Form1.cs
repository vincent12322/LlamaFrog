using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private double time = 100;
        private bool done = false;
        private int score = 0;
        private int highscore = 0;
        private String currentImage;
        private Image llama1 = Game.Properties.Resources.Llama;
        private Image llama2 = Game.Properties.Resources.Llama2;
        private Image llama3 = Game.Properties.Resources.Llama3;
        private Image llama4 = Game.Properties.Resources.Llama4;
        private Image llama5 = Game.Properties.Resources.Llama5;
        private Image llama6 = Game.Properties.Resources.Llama6;
        private Image frog1 = Game.Properties.Resources.Frog;
        private Image frog2 = Game.Properties.Resources.Frog2;
        private Image frog3 = Game.Properties.Resources.Frog3;
        private Image frog4 = Game.Properties.Resources.Frog4;
        private Image frog5 = Game.Properties.Resources.Frog5;
        private Image frog6 = Game.Properties.Resources.Frog6;

        private int rand = 0;
        int lastRandom;
        private Random random = new Random();

        private void getChoice()
        {
            lastRandom = rand;
            rand = random.Next(1, 12);
            while(rand == lastRandom)
            {
                rand = random.Next(1, 12);
            }
            switch (rand)
            {
                //Llamas
                case 1:
                    pictureBox1.Image = llama1;
                    currentImage = "Llama";
                    break;
                case 2:
                    pictureBox1.Image = llama2;
                    currentImage = "Llama";
                    break;
                case 3:
                    pictureBox1.Image = llama3;
                    currentImage = "Llama";
                    break;
                case 4:
                    pictureBox1.Image = llama4;
                    currentImage = "Llama";
                    break;
                case 5:
                    pictureBox1.Image = llama5;
                    currentImage = "Llama";
                    break;
                case 6:
                    pictureBox1.Image = llama6;
                    currentImage = "Llama";
                    break;
                //Frogs
                case 7:
                    pictureBox1.Image = frog1;
                    currentImage = "Frog";
                    break;
                case 8:
                    pictureBox1.Image = frog2;
                    currentImage = "Frog";
                    break;
                case 9:
                    pictureBox1.Image = frog3;
                    currentImage = "Frog";
                    break;
                case 10:
                    pictureBox1.Image = frog4;
                    currentImage = "Frog";
                    break;
                case 11:
                    pictureBox1.Image = frog5;
                    currentImage = "Frog";
                    break;
                case 12:
                    pictureBox1.Image = frog6;
                    currentImage = "Frog";
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
            scoreBox.Text = score.ToString();
            using (System.IO.StreamReader sr = new System.IO.StreamReader("highscore.txt")) 
            {
                    highscoreBox.Text = sr.ReadLine();
                    highscore = int.Parse(highscoreBox.Text);
            }
            getChoice();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time -= 1;
            }
            else
            {
                Console.Beep();
                if(score > highscore)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter("highscore.txt"))
                    {
                        sw.WriteLine(score);
                        sw.Close();
                    }
                    using (System.IO.StreamReader sr = new System.IO.StreamReader("highscore.txt"))
                    {
                        highscoreBox.Text = sr.ReadLine();
                        highscore = int.Parse(highscoreBox.Text);
                    }
                }
                done = true;
                timer.Stop();
            }
            textBox1.Text = time.ToString();
        }

        private void llamaButton_Click(object sender, EventArgs e)
        {
            if(!done)
            {
                if (currentImage == "Llama")
                {
                    score++;
                    getChoice();
                }
                else
                {
                    score--;
                    rand = random.Next(0, 100);
                    getChoice();
                }
                scoreBox.Text = score.ToString();
            }
        }

        private void frogButton_Click(object sender, EventArgs e)
        {
            if(!done)
            {
                if (currentImage == "Frog")
                {
                    score++;
                    getChoice();
                }
                else
                {
                    score--;
                    getChoice();
                }
                scoreBox.Text = score.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            time = 100;
            score = 0;
            scoreBox.Text = score.ToString();
            done = false;
            timer.Start();
        }
    }
}
