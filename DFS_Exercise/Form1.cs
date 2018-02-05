using System;
using System.Net;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DFS_Exercise
{
    public partial class MainForm : Form
    {
        Random randomBreakTime = new Random();      // Random break time to allow breaks between 3-5 mins and 15-30 mins.
        int timeLeft;                               // Time left in seconds.
        int breakNum = 0;                           // Number of breaks taken so far.
        string timeRemaining;                       // Time remaining in string form for the stopwatch label.
        string hostname = Dns.GetHostName();        // Get the hostname to be passed as an ID with the break status.
        bool breakTime = false;                     // Boolean to determine whether or not it's break time.
        UDPNet.UDPNet udp;                          // Object for sending/receiving via UDP.

        public MainForm()
        {
            InitializeComponent();
            FormClosing += MainForm_FormClosing;
        }

        public MainForm(UDPNet.UDPNet UdpInject) : this()
        {
            udp = UdpInject;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            udp.start();
        }

        // Timer ticks every 1000 ms.
        private void timer1_Tick(object sender, EventArgs e)
        {
            // While the timer is running:
            if (timeLeft > 0)
            {
                timeLeft -= 1;

                if (timeLeft % 60 >= 10)
                    timeRemaining = (timeLeft / 60).ToString() + ":" + (timeLeft % 60).ToString();
                else
                    timeRemaining = (timeLeft / 60).ToString() + ":0" + (timeLeft % 60).ToString();

                pomodoro.Text = timeRemaining;
                udp.send(breakTime, hostname);
            }
            // If the timer has hit zero:
            else
            {
                if (breakNum < 4 && breakTime == false)
                {
                    breakTime = true;
                    timeLeft = randomBreakTime.Next(180, 300);  // Random break between 3 and 5 minutes.
                    MessageBox.Show("Time for a break!", "Times up!");
                    breakLabel.Text = "You should be taking a break!";
                }
                else if (breakTime == false)
                {
                    breakTime = true;
                    timeLeft = randomBreakTime.Next(900, 1800); // Random break between 15 and 30 minutes.
                    MessageBox.Show("Time for a break!", "Times up!");
                    breakLabel.Text = "You should be taking a break!";
                }
                else
                {
                    timeLeft = 1500;
                    breakTime = false;
                    MessageBox.Show("Time to get back to work!", "Time to work!");
                    breakLabel.Text = "You should be working!";
                }
                udp.send(breakTime, hostname);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timeLeft = 1500;    // 25 minutes in seconds is 1500.
            timer1.Start();
            startButton.Text = "Reset";
            breakLabel.Text = "You should be working!";
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                pauseButton.Text = "Resume";
            }
            else
            {
                timer1.Start();
                pauseButton.Text = "Pause";
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Text = "Start";
            timeLeft = 1500;            // Set the clock to 25mins.
            pomodoro.Text = "25:00";
            timer1.Stop();
        }

        private void statusListButton_Click(object sender, EventArgs e)
        {
            StatusConnections statusList = new StatusConnections(udp);
            statusList.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            udp.send(true, "Timer Closed");
        }
    }
}