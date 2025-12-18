using AntdUI;
using project.Component;
using project.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class From_settings : AntdUI.Window
    {
        private String[] setName = new string[] {"全域設定", "待辦事項設定", "番茄鐘設定" };
        private JsonManager jsonManager = new JsonManager();

        private int[] modeSet = { 0, 20 * 60, 5 * 60, 10 * 60 }; // work, short break, long break
        private int loopTimes = 2;
        private bool[] autoStart;

        public From_settings()
        {
            InitializeComponent();
            initPara();
        }

        private void From_settings_Load(object sender, EventArgs e)
        {
            backColorSet.SetPanelBackItemColor(panel1, Color.FromArgb(255, 230, 230, 230));
            backColorSet.SetPanelBackItemColor(panel2, Color.FromArgb(255, 230, 230, 230));
        }

        private void initPara()
        {
            this.modeSet = jsonManager.Get_modeSet();
            this.loopTimes = jsonManager.Get_loopTime();

            inputN_focus.Value = modeSet[1] / 60;
            inputN_shortBreak.Value = modeSet[2] / 60;
            inputN_longBreak.Value = modeSet[3] / 60; 
            inputN_loopTimes.Value = loopTimes;
            autoStart = jsonManager.Get_autoStart();
            switch_autoFocus.Checked = autoStart[0];
            switch_autoBreak.Checked = autoStart[1];
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tabs1.SelectedIndex == 2)
            {
                jsonManager.Save_modeSet(new int[] { 0, (int)inputN_focus.Value * 60, (int)inputN_shortBreak.Value * 60, (int)inputN_longBreak.Value * 60 });
                jsonManager.Save_loopTime((int)inputN_loopTimes.Value);
                autoStart = new bool[] { switch_autoFocus.Checked, switch_autoBreak.Checked };
                jsonManager.Save_autoStart(autoStart);
            }
        }
    }
}
