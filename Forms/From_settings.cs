using AntdUI;
using project.Component;
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
    public partial class From_settings : Form
    {
        private String[] setName = new string[] {"全域設定", "待辦事項設定", "番茄鐘設定" };
        private JsonManager jsonManager = new JsonManager();

        private int[] modeSet = { 0, 20 * 60, 5 * 60, 10 * 60 }; // work, short break, long break
        private int loopTimes = 2;

        public From_settings()
        {
            InitializeComponent();
            initPara();
        }

        private void From_settings_Load(object sender, EventArgs e)
        {
            SetPanelBackItemColor(panel1);
            SetPanelBackItemColor(panel2);
        }

        private void initPara()
        {
            this.modeSet = jsonManager.Get_modeSet();
            this.loopTimes = jsonManager.Get_loopTime();

            inputN_focus.Value = modeSet[1] / 60;
            inputN_longBreak.Value = modeSet[2] / 60;
            inputN_shortBreak.Value = modeSet[3] / 60;
            inputN_loopTimes.Value = loopTimes;
        }

        private void SetPanelBackItemColor(AntdUI.Panel panel)
        {
            foreach (Control Item in panel.Controls)
            {
                if (Item is AntdUI.Label)
                {
                    AntdUI.Label item = (AntdUI.Label)Item;
                    item.BackColor = Color.FromArgb(255, 230, 230, 230);
                }
                if (Item is AntdUI.Switch)
                {
                    AntdUI.Switch item = (AntdUI.Switch)Item;
                    item.BackColor = Color.FromArgb(255, 230, 230, 230);
                }
            }
        }
    }
}
