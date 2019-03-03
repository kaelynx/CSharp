using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowlingGame
{
    public partial class Form1 : Form
    {
        BowlingGame game = new BowlingGame();
        private int Counter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e) {}
        
        private void PlayButtonClicked(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = false;
            GamePlay();
        }

        private void Button2Clicked(object sender, EventArgs e)
        {
            game.StopGame();
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button2.Enabled = false;
            Counter = 0;
            button1.Text = "Play Game";
            label5.Text = "";
            label3.Text = "";
            label4.Text = "";
            label7.Text = "";
            game = new BowlingGame();
        }

        private void CheatButtonClicked(object sender, EventArgs e)
        {
            /*mainly here to show bonus on last roll*/
            button1.Enabled = false;
            button4.Enabled = false;
            game.InitiateCheatMode();
            GamePlay();
      
        }

        private void GutterBallClicked(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            game.InitiateLoseMode();
            GamePlay();
        }

        private void GamePlay()
        {
            if (!game.GameOver())
            {
                game.RollBall();
                ++Counter;
                button1.Text = "Roll Again";
                label5.Text = game.ThrowResults();
                label3.Text = (game.CurrentScore()).ToString();
                label4.Text = (game.TotalScore()).ToString();
                label7.Text = Counter.ToString();
                if (game.GameOver())
                {
                    button2.Enabled = true;
                    button1.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
            }
        }
    }
}
