namespace DFS_Exercise
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pomodoro = new System.Windows.Forms.Label();
            this.breakLabel = new System.Windows.Forms.Label();
            this.statusListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(21, 185);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(102, 185);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(183, 185);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pomodoro
            // 
            this.pomodoro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pomodoro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pomodoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomodoro.Location = new System.Drawing.Point(102, 32);
            this.pomodoro.Name = "pomodoro";
            this.pomodoro.Size = new System.Drawing.Size(75, 32);
            this.pomodoro.TabIndex = 3;
            this.pomodoro.Text = "25:00";
            this.pomodoro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // breakLabel
            // 
            this.breakLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.breakLabel.Location = new System.Drawing.Point(0, 0);
            this.breakLabel.Name = "breakLabel";
            this.breakLabel.Size = new System.Drawing.Size(284, 23);
            this.breakLabel.TabIndex = 4;
            this.breakLabel.Text = "Click \"Start\" to start the timer!";
            this.breakLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusListButton
            // 
            this.statusListButton.Location = new System.Drawing.Point(102, 226);
            this.statusListButton.Name = "statusListButton";
            this.statusListButton.Size = new System.Drawing.Size(75, 23);
            this.statusListButton.TabIndex = 5;
            this.statusListButton.Text = "Status List";
            this.statusListButton.UseVisualStyleBackColor = true;
            this.statusListButton.Click += new System.EventHandler(this.statusListButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusListButton);
            this.Controls.Add(this.breakLabel);
            this.Controls.Add(this.pomodoro);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Pomodoro Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label pomodoro;
        private System.Windows.Forms.Label breakLabel;
        private System.Windows.Forms.Button statusListButton;
    }
}

