using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int guessedNumber = 0;
        public int turnsCount = 0;
        public int compNum = 50;
        public int mult = 25;
        public bool isPlayerWin = false;

        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            guessedNumber = rnd.Next(1, 100);
            turnsCount = 7;
            lblTurnsCount.Text = $"Քայլերի քանակ: {turnsCount}";
        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            lblcomNum.Text = $"Իմ թիվն է {compNum}";
            if (turnsCount > 1 || playerNum.Value == guessedNumber || compNum == guessedNumber)
            {
                if (playerNum.Value == guessedNumber && compNum == guessedNumber)
                {
                    lblcomNum.Hide();
                    btnAnswer.Hide();
                    lblTurnsCount.Hide();
                    playerNum.Hide();
                    lblAnswer.Text = $"Ոչ Ոքի: Մտապահված թիվը {guessedNumber}-ն էր!";
                }
                else
                {
                    if (playerNum.Value > guessedNumber)
                        lblAnswer.Text = "Ձեր թիվը ՄԵԾ է մտապահվածից...";
                    else if (playerNum.Value < guessedNumber)
                        lblAnswer.Text = "Ձեր թիվը ՓՈՔՐ է մտապահվածից...";
                    else
                    {
                        lblAnswer.Text = "Դուք գուշակեցիք!";
                        btnAnswer.Hide();
                        lblTurnsCount.Hide();
                        isPlayerWin = true;
                    }
                    if (!isPlayerWin)
                    {
                        if (compNum < guessedNumber)
                            compNum += mult;
                        else if (compNum > guessedNumber)
                            compNum -= mult;
                        else
                        {
                            lblcomNum.Text = $"Ես Հաղթեցի";
                            btnAnswer.Hide();
                            lblTurnsCount.Hide();
                            playerNum.Hide();
                            lblAnswer.Text = $"Դուք պարտվեցիք:Համակարգիչը հաղթեց, մտապահված թիվը {guessedNumber}-ն էր!";
                        }
                        if (mult / 2 >= 1)
                            mult /= 2;
                    }
                    turnsCount--;
                }
            }
            else
            {
                btnAnswer.Hide();
                lblTurnsCount.Hide();
                lblAnswer.Text = $"Դուք պարտվեցիք: Մտապահված թիվը {guessedNumber}-ն էր!";
            }
            lblTurnsCount.Text = $"Քայլերի քանակ: {turnsCount}";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTurnsCount_Click(object sender, EventArgs e)
        {

        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}