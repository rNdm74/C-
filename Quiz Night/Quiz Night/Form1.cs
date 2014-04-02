using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz_Night
{
    public partial class Form1 : Form
    {
        private delegate int ScoreDelegate(int correct, int incorrect);
        private ScoreDelegate scoreCalculator;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scoreCalculator = null;
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            // Get scores
            int correct = (int)nUpDownCorrect.Value;
            int incorrect = (int)nUpDownIncorrect.Value;

            // Determine team
            if (rbAdultTeam.Checked)
                scoreCalculator = new ScoreDelegate(Scorer.AdultScore);
            if (rbChildTeam.Checked)
                scoreCalculator = new ScoreDelegate(Scorer.ChildScore);

            // Set value of team score
            nUpDownTeamScore.Value = scoreCalculator(correct, incorrect);
        }
    }
}
