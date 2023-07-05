using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionare
{
    public partial class Form1 : Form
    {
        int helpCount = 0;
        bool secondChane = false;
        List<Question> questions = new List<Question>();
        private Random rnd = new Random();
        int level = 0;
        Question currentQuestion;
        private void startGame()
        {
            btn5050.Enabled = true;
            zalHelp.Enabled = true;
            friendCall.Enabled = true;
            changeQ.Enabled = true;
            twoChances.Enabled = true;
            level = 0;
            NextStep();
        }

        private void NextStep()
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB,
btnAnswerC, btnAnswerD };

            foreach (Button btn in btns)
                btn.Enabled = true;

            level++;
            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - level;
        }

        private Question GetQuestion(int level)
        {
            var questionsWithLevel = questions.Where(q => q.Level == level).ToList();
            return questionsWithLevel[rnd.Next(questionsWithLevel.Count)];
        }

        private void ShowQuestion(Question q)
        {
            lblQuestion.Text = q.Text;
            btnAnswerA.Text = q.Answers[0];
            btnAnswerB.Text = q.Answers[1];
            btnAnswerC.Text = q.Answers[2];
            btnAnswerD.Text = q.Answers[3];
        }

        private void ReadFile()
        {
            string path = @"Вопросы.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    questions.Add(new Question(line.Split('\t')));
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            ReadFile();
            startGame();

        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
            {
                NextStep();
                secondChane = false;
            }
            else
            {
                if (secondChane)
                {
                    button.Enabled = false;
                    secondChane = false;
                }
                else
                {
                    MessageBox.Show("Неверный ответ!");
                    startGame();
                }
            }
        }

        private void bntFiftyFifty_Click(object sender, EventArgs e)
        {
            helpCount++;
            if (helpCount == 4)
            {
                changeQ.Enabled = false;
                btn5050.Enabled = false;
                friendCall.Enabled = false;
                twoChances.Enabled = false;
                zalHelp.Enabled = false;
            }
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB,
                btnAnswerC, btnAnswerD };

            int count = 0;
            while (count < 2)
            {
                int n = rnd.Next(4);
                int answer = int.Parse(btns[n].Tag.ToString());

                if (answer != currentQuestion.RightAnswer && btns[n].Enabled)
                {
                    btns[n].Enabled = false;
                    count++;
                }
            }
            btn5050.Enabled = false;
        }

        private void zalHelp_Click(object sender, EventArgs e)
        {
            helpCount++;
            if (helpCount == 4)
            {
                changeQ.Enabled = false;
                btn5050.Enabled = false;
                friendCall.Enabled = false;
                twoChances.Enabled = false;
                zalHelp.Enabled = false;
            }

            Button[] btns = new Button[] { btnAnswerA, btnAnswerB,
                btnAnswerC, btnAnswerD };
            int answerPerc = rnd.Next(50 / (int)Math.Pow(1.2, currentQuestion.Level - 1), 100 / (int)Math.Pow(1.2, currentQuestion.Level - 1));
            int[] otherPerc = new int[3];
            int otherPerc1 = rnd.Next(0, 100 - answerPerc);
            int otherPerc2 = rnd.Next(0, 100 - answerPerc - otherPerc1);
            int otherPerc3 = 100 - answerPerc - otherPerc1 - otherPerc2;
            otherPerc[0] = otherPerc1;
            otherPerc[1] = otherPerc2;
            otherPerc[2] = otherPerc3;
            int count = 0;
            foreach (var x in btns)
            {
                int n = rnd.Next(4);
                int answer = int.Parse(x.Tag.ToString());

                if (answer == currentQuestion.RightAnswer)
                {
                    x.Text = x.Text + $" {answerPerc}%";
                }
                else
                {
                    x.Text = x.Text + $" {otherPerc[count]}%";
                    count++;
                }
            }
            zalHelp.Enabled = false;
        }

        private void friendCall_Click(object sender, EventArgs e)
        {
            helpCount++;
            if (helpCount == 4)
            {
                changeQ.Enabled = false;
                btn5050.Enabled = false;
                friendCall.Enabled = false;
                twoChances.Enabled = false;
                zalHelp.Enabled = false;
            }
            Timer f = new Timer();
            f.ShowDialog();
            friendCall.Enabled = false;
        }

        private void twoChances_Click(object sender, EventArgs e)
        {
            helpCount++;
            if (helpCount == 4)
            {
                changeQ.Enabled = false;
                btn5050.Enabled = false;
                friendCall.Enabled = false;
                twoChances.Enabled = false;
                zalHelp.Enabled = false;
            }
            secondChane = true;
            twoChances.Enabled = false;
        }

        private void changeQ_Click(object sender, EventArgs e)
        {
            helpCount++;
            if (helpCount == 4)
            {
                changeQ.Enabled = false;
                btn5050.Enabled = false;
                friendCall.Enabled = false;
                twoChances.Enabled = false;
                zalHelp.Enabled = false;
            }
            changeQ.Enabled = false;
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB,
btnAnswerC, btnAnswerD };

            foreach (Button btn in btns)
                btn.Enabled = true;
            Question oldq = currentQuestion;
            while (oldq.Text == currentQuestion.Text)
            {
                currentQuestion = GetQuestion(level);
            }
            ShowQuestion(currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - level;
        }
    }
}
