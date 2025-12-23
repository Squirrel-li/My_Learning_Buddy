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
    public partial class Form_pomodoro : AntdUI.Window
    {
        private bool debug = true;

        private int currentSecond = 0;

        private int[] modeSet = {0,  20 * 60, 5 * 60, 10 * 60}; // work, short break, long break
        private int loopTimes = 2;
        private int rate = 1;
        private bool[] autoStart;

        private int currentloop = 0;
        private int currentMode = 0; // 0: idle, 1: work, 2: short break, 3: long break
        private List<DateTime> tableFinish;

        public JsonManager jsonManager = new JsonManager();

        public Form_pomodoro()
        {
            InitializeComponent();
        }
        public Form_pomodoro(bool debug)
        {
            InitializeComponent();
            this.debug = debug;
        }

        private void Form_pomodoro_Load(object sender, EventArgs e)
        {
            initBackColor();
            initPara();
            initPomoTime();
            if (debug)
            {
                debug_init(20);
            }
        }

        void initBackColor()
        {
            pageHeader.BackColor = ThemeColor.BackPrimary;

            progress_pomo.BackColor = ThemeColor.BackPrimary;

            gridPanel_bottomBody.BackColor = ThemeColor.BackPrimary;

            gridPanel_pomoButton.BackColor = ThemeColor.BackPrimary;
            btn_control.DefaultBack = ThemeColor.BackButtonAccent;
            btn_control.ForeColor = ThemeColor.BackInput;

            btn_stop.DefaultBack = ThemeColor.BackPrimary;
            btn_stop.BorderWidth = 2;
            btn_stop.DefaultBorderColor = ThemeColor.BackBorder;
            btn_stop.ForeColor = ThemeColor.TextSecondary;

            gridPanel_set.BackColor = ThemeColor.BackPrimary;
            inputN_shortBreak.BackColor = ThemeColor.BackInput;
            inputN_focus.BackColor = ThemeColor.BackInput;
            inputN_longBreak.BackColor = ThemeColor.BackInput;
            inputN_loopTimes.BackColor = ThemeColor.BackInput;
            /*
            lbl_debug;
            label1;
            label2;
            label3;
            label4;
            label5;*/
        }


        private void debug_init(int rate)
        {
            timer_count.Interval /= rate;
            this.rate = rate;
            lbl_debug.Text = "Debug 模式開啟\n\r";
        }

        private void initPomoTime()
        {
            inputN_focus.Value = modeSet[1] / 60;
            inputN_shortBreak.Value = modeSet[2] / 60;
            inputN_longBreak.Value = modeSet[3] / 60;
            inputN_loopTimes.Value = loopTimes;
            currentloop = 0;
            currentMode = 0;
            currentSecond = modeSet[1];
            progress_pomo.Value = 1f;

            UpdateProgress(this.progress_pomo);
        }

        private void initPara()
        {
            modeSet = jsonManager.Get_modeSet();
            loopTimes = jsonManager.Get_loopTime();
            autoStart = jsonManager.Get_autoStart();
            tableFinish = jsonManager.Get_tableFinish();
        }

        private void timer_count_Tick(object sender, EventArgs e)
        {
            currentSecond -= rate;

            if (currentSecond <= 0)
            {
                btn_control.Text = "開始";
                if (currentMode == 1) // work -> break
                {
                    if (!autoStart[0])
                    {
                        timer_count.Stop();
                    }
                    else
                    {
                        timer_count.Start();
                    }
                    if (currentloop > 0)
                    {
                        currentMode = 2; // short break
                        currentloop--;
                    }
                    else
                    {
                        currentMode = 3; // long break
                        currentloop = loopTimes;
                        tableFinish = jsonManager.Get_tableFinish();
                        tableFinish.Add(DateTime.Now);
                        jsonManager.Save_tableFinish(tableFinish);
                    }
                }
                else if (currentMode == 2)
                {
                    if (!autoStart[1])
                    {
                        timer_count.Stop();
                    }
                    else
                    {
                        timer_count.Start();
                    }
                    currentMode = 1;
                }
                else if (currentMode == 3)
                {
                    if (!autoStart[1])
                    {
                        timer_count.Stop();
                    }
                    else
                    {
                        timer_count.Start();
                    }
                    currentMode = 1;
                }
                else // currentMode 超出範圍
                {
                    currentMode = 0;
                }
                lbl_debug.Text = $"Mode: {currentMode.ToString()}\ncurrentloop: {currentloop.ToString()}";
                currentSecond = modeSet[currentMode];
            }
            UpdateProgress(this.progress_pomo);
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
                btn_control.Text = "暫停";
                btn_stop.Visible = false;
            }
            else // pause
            {
                if (currentMode != 0)
                {
                    timer_count.Stop();
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
            if (currentMode == 1)
            {
                targetProgress.Fill = GetCurrentTimeColor(targetProgress.Value);
            }
            else if (currentMode == 2)
            {
                targetProgress.Fill = ColorTranslator.FromHtml("#93B5C6");
            }
            else if (currentMode == 3)
            {
                targetProgress.Fill = ColorTranslator.FromHtml("#9E94A8");
            }
            int Min = currentSecond / 60;
            int Sec = currentSecond % 60;
            targetProgress.Text = $"{Min.ToString("00")} : {Sec.ToString("00")}";
        }

        private Color GetCurrentTimeColor(double percentage)
        {
            Color colorStart = System.Drawing.ColorTranslator.FromHtml("#9CAF88"); // 100% 抹茶綠
            Color colorMid = System.Drawing.ColorTranslator.FromHtml("#E6C87F"); // 50%  蜂蜜黃
            Color colorEnd = System.Drawing.ColorTranslator.FromHtml("#D67D65"); // 0%   陶瓦紅

            if (percentage >= 0.5)
            {
                float map = (float)((percentage - 0.5) * 2);
                return LerpColor(colorMid, colorStart, map);
            }
            else
            {
                float map = (float)(percentage * 2);
                return LerpColor(colorEnd, colorMid, map);
            }
        }
        private Color LerpColor(Color start, Color end, float amount)
        {
            float sr = start.R, sg = start.G, sb = start.B;
            float er = end.R, eg = end.G, eb = end.B;

            byte r = (byte)(sr + (er - sr) * amount);
            byte g = (byte)(sg + (eg - sg) * amount);
            byte b = (byte)(sb + (eb - sb) * amount);

            return Color.FromArgb(r, g, b);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            initPomoTime();
            btn_stop.Visible = false;
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
                    UpdateProgress(this.progress_pomo);
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
                    UpdateProgress(this.progress_pomo);
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
                    UpdateProgress(this.progress_pomo);
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