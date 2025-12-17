using AntdUI;
using project.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace project
{
    public partial class Form_pomodoro : Form
    {
        private bool debug = true;

        private int currentSecond = 0;

        private int[] modeSet = {0,  20 * 60, 5 * 60, 10 * 60}; // work, short break, long break
        private int loopTimes = 2;
        private int rate = 1;

        private int currentloop = 0;
        private int currentMode = 0; // 0: idle, 1: work, 2: short break, 3: long break

        public JsonManager jsonManager = new JsonManager();

        public Form_pomodoro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initPara();
            initPomoTime();
            if (debug)
            {
                debug_init(20);
            }
        }

        void debug_init(int rate)
        {
            timer_count.Interval /= rate;
            this.rate = rate;
            lbl_debug.Visible = true;
            lbl_debug.Text = "Debug 模式開啟\n\r";
        }

        private void initPomoTime()
        {
            inputN_focus.Value = modeSet[1] / 60;
            inputN_longBreak.Value = modeSet[2] / 60;
            inputN_shortBreak.Value = modeSet[3] / 60;
            inputN_loopTimes.Value = loopTimes;
            currentloop = 0;
            currentMode = 0;
            currentSecond = modeSet[1];
            progress1.Value = 1f;

            UpdateProgress(this.progress1);
        }

        private void initPara()
        {
            this.modeSet = jsonManager.Get_modeSet();
            loopTimes = jsonManager.Get_loopTime();
        }

        private void timer_count_Tick(object sender, EventArgs e)
        {
            currentSecond -= rate;
            UpdateProgress(this.progress1);

            if (currentSecond <= 0)
            {
                timer_count.Stop();
                timer_count.Enabled = false;
                btn_control.Text = "開始";
                if (currentMode == 1) // work -> break
                {
                    if (currentloop > 0)
                    {
                        currentMode = 2; // short break
                        currentloop--;
                    }
                    else
                    {
                        currentMode = 3; // long break
                        currentloop = loopTimes;
                    }
                }
                else if (currentMode == 2)
                {
                    currentMode = 1;
                }
                else if (currentMode == 3)
                {
                    currentMode = 1;
                }
                else // currentMode 超出範圍
                {
                    currentMode = 0;
                }
                lbl_debug.Text = $"Mode: {currentMode.ToString()}\ncurrentloop: {currentloop.ToString()}";
                currentSecond = modeSet[currentMode];
            }
        }

        private void btn_control_Click(object sender, EventArgs e)
        {

            if (!timer_count.Enabled) // start
            {
                if (currentMode == 0) // idle -> work
                {
                    currentMode = 1;
                    currentSecond = modeSet[currentMode];
                    currentloop = loopTimes;
                }
                timer_count.Start();
                timer_count.Enabled = true;
                btn_control.Text = "暫停";
                btn_stop.Visible = false;
            }
            else // pause
            {
                if (currentMode != 0)
                {
                    timer_count.Stop();
                    timer_count.Enabled = false;
                    btn_control.Text = "開始";
                    btn_stop.Visible = true;
                }
            }
        }

        private void UpdateProgress(AntdUI.Progress targetProgress)
        {
            if (currentMode == 0)
            {
                targetProgress.Value = (float)currentSecond / (float)modeSet[1];
            }
            else
            {
                targetProgress.Value = (float)currentSecond / (float)modeSet[currentMode];
            }
            if (targetProgress.Value < 0.50f)
            {
                targetProgress.Fill = Interpolate(Color.LightGreen, Color.LightSalmon, targetProgress.Value / 0.50f);
            }
            else
            {
                targetProgress.Fill = Interpolate(Color.LightSalmon, Color.LightSeaGreen, (targetProgress.Value - 0.50f) / 0.50f);
            }
            int Min = currentSecond / 60;
            int Sec = currentSecond % 60;
            targetProgress.Text = $"{Min.ToString("00")} : {Sec.ToString("00")}";
        }

        private Color Interpolate(Color c1, Color c2, float t)
        {
            return Color.FromArgb(
                (int)(c1.R + (c2.R - c1.R) * t),
                (int)(c1.G + (c2.G - c1.G) * t),
                (int)(c1.B + (c2.B - c1.B) * t)
            );
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            initPomoTime();
        }

        private void inputN_focus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int min = Convert.ToInt32(inputN_focus.Value);
                modeSet[1] = min * 60;
                if (currentMode == 0 || currentMode == 1)
                {
                    currentSecond = modeSet[1];
                    UpdateProgress(this.progress1);
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
                jsonManager.Save_modeSet(this.modeSet);
            }
        }

        private void inputN_shortBreak_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int min = Convert.ToInt32(inputN_shortBreak.Value);
                modeSet[2] = min * 60;
                if (currentMode == 2)
                {
                    currentSecond = modeSet[2];
                    UpdateProgress(this.progress1);
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
                jsonManager.Save_modeSet(this.modeSet);
            }
        }

        private void inputN_longBreak_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int min = Convert.ToInt32(inputN_longBreak.Value);
                modeSet[3] = min * 60;
                if (currentMode == 3)
                {
                    currentSecond = modeSet[3];
                    UpdateProgress(this.progress1);
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
                jsonManager.Save_modeSet(this.modeSet);
            }
        }

        private void inputN_loopTimes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int times = Convert.ToInt32(inputN_loopTimes.Value);
                loopTimes = times;
                e.Handled = true;
                e.SuppressKeyPress = true;
                jsonManager.Save_loopTime(loopTimes);
            }
        }
    }
}