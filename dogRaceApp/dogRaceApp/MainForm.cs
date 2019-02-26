using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace dogRaceApp
{
    public partial class MainForm : Form
    {
        private Greyhound[] GreyHound = new Greyhound[4];
        private Guy[] Guy = new Guy[3];
        private Random random = new Random();
        public int GuyThatBets { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Start();
        }
        public void Start()
        {
            int Start = racer1.Left;
            int Racetrack = raceTrack.Width - racer1.Right;


            GreyHound[0] = new Greyhound() { MypictureBox = racer1, RacetrackLength = Racetrack, StartingPostion = Start };
            GreyHound[1] = new Greyhound() { MypictureBox = racer2, RacetrackLength = Racetrack, StartingPostion = Start };
            GreyHound[2] = new Greyhound() { MypictureBox = racer3, RacetrackLength = Racetrack, StartingPostion = Start };
            GreyHound[3] = new Greyhound() { MypictureBox = racer4, RacetrackLength = Racetrack, StartingPostion = Start };

            Guy[0] = new Guy() { Cash = 50, MyLabel = labelJoesBet, MyRadioButton = radioButtonJoe, Name = "Joe" };
            Guy[1] = new Guy() { Cash = 75, MyLabel = labelBobsBet, MyRadioButton = radioButtonBob, Name = "Bob" };
            Guy[2] = new Guy() { Cash = 45, MyLabel = labelAlsBet, MyRadioButton = radioButtonAl, Name = "Al" };

            for (int i = 0; i < Guy.Length; i++)
            {
                Guy[i].MyRadioButton.Text = string.Format("{0}, Geld: € {1},-", Guy[i].Name, Guy[i].Cash);
                Guy[i].MyLabel.Text = string.Format("{0} hasn't placed a bet", Guy[i].Name);
            }
        }

        private void buttonRace_Click(object sender, EventArgs e)
        {
            LetDogsRun();
        }
        public void LetDogsRun()
        {
            while (true)
            {
                for (int i = 0; i < GreyHound.Length; i++)
                {
                    Thread.Sleep(6);
                    GreyHound[random.Next(0, 4)].Run();
                    if (GreyHound[i].Run())
                    {
                        DeclareWinner(i + 1); //array starts with 0
                        return;
                    }
                }
            }
        }

        public void DeclareWinner(int Winner)
        {
            MessageBox.Show("Dog " + Winner + " is the Winner!");
            for (int i = 0; i < 3; i++)
            {
                Guy[i].Collect(Winner);
                Guy[i].UpdateLabels();
                ResetDogsPosition();
                ResetBets();

            }
        }
        
        public void ResetDogsPosition()
        {
            for (int i = 0; i < 4; i++)
            {
                GreyHound[i].TakeStartingPosition();
            }
        }

        public void ResetBets()
        {
            for (int i = 0; i < 3; i++)
            {
                labelJoesBet.Text = "Joe hasn't placed a bet";
                labelBobsBet.Text = "Bob hasn't placed a bet";
                labelAlsBet.Text = "Al hasn't placed a bet";
            }
        }

        private void buttonBets_Click(object sender, EventArgs e)
        {
            int amount = (int)numericUpDownBets.Value;
            int dog = (int)numericUpDownDog.Value;
            Guy[GuyThatBets].PlaceBet(amount, dog);
            Guy[GuyThatBets].UpdateLabels();
        }

        private void radioButtonJoe_CheckedChanged(object sender, EventArgs e)
        {
            GuyThatBets = 0;
            labelSelectedBettor.Text = Guy[GuyThatBets].Name;
        }

        private void radioButtonBob_CheckedChanged(object sender, EventArgs e)
        {
            GuyThatBets = 1;
            labelSelectedBettor.Text = Guy[GuyThatBets].Name;
        }

        private void radioButtonAl_CheckedChanged(object sender, EventArgs e)
        {
            GuyThatBets = 2;
            labelSelectedBettor.Text = Guy[GuyThatBets].Name;
        }
    }
}
