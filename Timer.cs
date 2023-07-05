using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionare
{
    public partial class Timer : Form
    {
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        int time = 30;
        public Timer()
        {
            InitializeComponent();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1000;
            myTimer.Start();
        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {
            tim.Text = time + " секунд";
            time--;
            if (time < 0)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
