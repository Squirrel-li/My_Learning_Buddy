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
    public partial class Form_mainPage : Form
    {
        List<String> tableSuject = new List<String>();
        List<String> tableClassification = new List<String>();
        List<String> tableFLPanelText = new List<String>();
        // store color + label
        List<ColorItem> tableColor = new List<ColorItem>();
        List<ToDoTask> tableToDoTask = new List<ToDoTask>();
        ushort panelNum = 5;

        // helper for storing color with display label
        private class ColorItem
        {
            public Color Color { get; }
            public string Label { get; }
            public ColorItem(Color color, string label)
            {
                Color = color;
                Label = label;
            }
            public override string ToString()
            {
                return Label;
            }
        }

        public Form_mainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Debug label clear
            this.lbl_debug.Text = "";

            // Init Tables and combobox data
            InitTables();

            // Init panel data
            ushort panelNum = 5;
            InitFLPanel(panelNum);

            // Load TO-DO Task data
            loadToDoTask();

            InitCBox();
        }

        private void InitTables()
        {
            this.tableSuject = new List<String> { "計算機結構", "視窗程式設計" };
            this.tableClassification = new List<String> { "考試", "報告", "作業" };
            this.tableFLPanelText = new List<String> { "今日活動", "明日活動", "久遠以後" };
            this.tableColor = new List<ColorItem>
            {
                new ColorItem(ColorTranslator.FromHtml("#FFADAD"), "柔粉紅"), // Soft Red
                new ColorItem(ColorTranslator.FromHtml("#FFD6A5"), "蜜桃橘"), // Peach
                new ColorItem(ColorTranslator.FromHtml("#FDFFB6"), "淡檸檬"), // Pale Yellow
                new ColorItem(ColorTranslator.FromHtml("#CAFFBF"), "茶綠"), // Tea Green
                new ColorItem(ColorTranslator.FromHtml("#9BF6FF"), "淡青"), // Cyan
                new ColorItem(ColorTranslator.FromHtml("#A0C4FF"), "嬰兒藍"), // Baby Blue
                new ColorItem(ColorTranslator.FromHtml("#BDB2FF"), "淡紫"), // Lavender
                new ColorItem(ColorTranslator.FromHtml("#FFC6FF"), "淡粉紫") // Pink
            };

            initComboBoxIndex(this.cb_subject, tableSuject);
            initComboBoxIndex(this.cb_classification, tableClassification);
        }

        private void InitFLPanel(ushort panelNum)
        {
            for (int i = 0; i < panelNum; i++)
            {
                String titel = "";
                if (i < this.tableFLPanelText.Count - 1)
                {
                    titel = this.tableFLPanelText[i];
                }
                else if (i == this.panelNum - 1)
                {
                    titel = this.tableFLPanelText[this.tableFLPanelText.Count - 1];
                }
                else
                {
                    titel = $"{i}天後";
                }
                FL_Panel newPanel = new FL_Panel(this.flpanel_calendar, $"FL_{i}", $"{titel}", panelNum);
                newPanel.add_to_FLPanel();
                this.lbl_debug.Text += newPanel.Tag + "\n\r";
            }
        }

        private void InitCBox()
        {
            cb_selectColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_selectColor.DrawMode = DrawMode.OwnerDrawFixed;
            cb_selectColor.Items.Clear(); // 確保清空舊選項

            // 將 tableColor 的顏色加入下拉選單（存放 ColorItem）
            foreach (var ci in tableColor)
            {
                cb_selectColor.Items.Add(ci);
            }

            cb_selectColor.SelectedIndex = (cb_selectColor.Items.Count > 0) ? 0 : -1;
        }

        private void initComboBoxIndex(ComboBox cbInput, List<String> table)
        {
            cbInput.Items.Clear();
            foreach (String classification in table) 
            {
                AddComboBoxIndex(cbInput, classification);
            }
            cbInput.SelectedIndex = 1;
        }

        private void loadToDoTask()
        {
            String subject = "subject";
            String classification = "classification";
            String taskDescribe = "taskDescribe";
            DateTime dateTime = DateTime.Now;

            ToDoTask new_toDoTask = new ToDoTask(subject, classification, taskDescribe, dateTime, ColorTranslator.FromHtml("#FFADAD"));
            this.tableToDoTask.Add(new_toDoTask);

            // 先快取所有 FL_Panel，避免每次查找都掃描 Controls
            {
                lbl_debug.Text = "";
                for (int t = 0; t < this.tableToDoTask.Count; t++)
                if (!toDoTask.done)
                {
                    if (0 > dayDiff)
                    {
                        targetPanel = find_pnaelinlanel(this.flpanel_calendar, "FL_0") ?? throw new Exception("cant find panel");
                        new_toDoTask.add_to_panel(targetPanel);
                    }
                    else if (panelNum - 1 > dayDiff && dayDiff >= 0)
                    {
                        targetPanel = find_pnaelinlanel(this.flpanel_calendar, $"FL_{dayDiff}") ?? throw new Exception("cant find panel");
                        new_toDoTask.add_to_panel(targetPanel);
                    }
                    else if (dayDiff >= panelNum - 1)
                    {
                        targetPanel = find_pnaelinlanel(this.flpanel_calendar, $"FL_{panelNum - 1}") ?? throw new Exception("cant find panel");
                        new_toDoTask.add_to_panel(targetPanel);
                    }
                }
            }
        }

        public void AddComboBoxIndex(ComboBox cbInput, String index)
        {
            cbInput.BeginUpdate();
            cbInput.Items.Add(index);
            cbInput.EndUpdate();
        }

        private void cb_color_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            // 取出 ColorItem
            var item = cb_selectColor.Items[e.Index] as ColorItem;
            Color color = (item != null) ? item.Color : Color.Transparent;

            int d = e.Bounds.Height - 6;
            Rectangle circle = new Rectangle(
                e.Bounds.Left + 4,
                e.Bounds.Top + 3,
                d,
                d
            );

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Brush b = new SolidBrush(color))
                e.Graphics.FillEllipse(b, circle);

            using (Pen p = new Pen(Color.Black, 1))
                e.Graphics.DrawEllipse(p, circle);

            // 顯示 label（由 ColorItem 提供）
            string displayText = (item != null) ? item.Label : string.Empty;

            using (Brush tb = new SolidBrush(e.ForeColor))
                e.Graphics.DrawString(
                    displayText,
                    e.Font,
                    tb,
                    e.Bounds.Left + d + 12,
                    e.Bounds.Top + 3
                );

            e.DrawFocusRectangle();
        }

        private void btn_addTask_Click(object sender, EventArgs e)
        {
            if (cb_subject.Text == String.Empty || cb_classification.Text == String.Empty)
            {
                lbl_tabToDoMes.Text = "請填入要新增的內容";
            }
            else
            {
                if (!cb_subject.Items.Contains(cb_subject.Text))
                {
                    cb_subject.Items.Add(cb_subject.Text);
                    tableSuject.Add(cb_subject.Text);
                    lbl_debug.Text += "cb_subject：\n";
                    foreach (var item in cb_subject.Items)
                    {
                        lbl_debug.Text += item.ToString() + "\n";
                    }
                }
                if (!cb_classification.Items.Contains(cb_classification.Text))
                {
                    cb_classification.Items.Add(cb_classification.Text);
                    tableSuject.Add(cb_classification.Text);
                    lbl_debug.Text += "cb_classification：\n";
                    foreach (var item in cb_classification.Items)
                    {
                        lbl_debug.Text += item.ToString() + "\n";
                    }
                }

                String subject = cb_subject.Text;
                String classification = cb_classification.Text;
                String taskDescribe = tb_taskDescribe.Text;

                // use the DateTimePicker value
                DateTime dateTime = this.dateTimeP_select.Value;

                // 取得選到的 Color
                Color selectColor = SystemColors.Control;
                if (cb_selectColor.SelectedItem is ColorItem selectedItem)
                    selectColor = selectedItem.Color;

                // create new toDoTask
                ToDoTask new_toDoTask = new ToDoTask(subject, classification, taskDescribe, dateTime, selectColor);

                // add to table
                lbl_debug.Text = "";
                FL_Panel targetPanel = find_pnaelinlanel(this.flpanel_calendar, "FL_0");
                int dayDiff = (dateTime.Date - DateTime.Today).Days;
                if (!new_toDoTask.done)
                {
                    if (0 > dayDiff)
                    {
                        targetPanel = find_pnaelinlanel(this.flpanel_calendar, "FL_0") ?? throw new Exception("cant find panel");
                        new_toDoTask.add_to_panel(targetPanel);
                    }
                    else if (panelNum - 1 > dayDiff && dayDiff >= 0)
                    {
                        targetPanel = find_pnaelinlanel(this.flpanel_calendar, $"FL_{dayDiff}") ?? throw new Exception("cant find panel");
                        new_toDoTask.add_to_panel(targetPanel);
                    }
                    else if (dayDiff >= panelNum - 1)
                    {
                        targetPanel = find_pnaelinlanel(this.flpanel_calendar, $"FL_{panelNum - 1}") ?? throw new Exception("cant find panel");
                        new_toDoTask.add_to_panel(targetPanel);
                    }
                }
            }
        }

        private FL_Panel find_pnaelinlanel(FlowLayoutPanel sourcePanel, String tag)
        {
            FL_Panel targetPanel = null;
            foreach (Control control in sourcePanel.Controls)
            {
                if (control is FL_Panel fl && control.Tag?.ToString() == tag)
                {
                    targetPanel = fl;
                    break; // 找到就跳出
                }
            }
            if (targetPanel == null)
            {
                MessageBox.Show("找不到標記為 FL_0 的 FL_Panel");
                return null;
            }
            return targetPanel;
        }

        private void tc_modifySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_modifySet.SelectedIndex == 0)
            {
                cb_subject.Items.Clear();
                cb_classification.Items.Clear();
                foreach (var item in tableSuject)
                {
                    cb_subject.Items.Add(item);
                }
                foreach (var item in tableClassification)
                {
                    cb_classification.Items.Add(item);
                }
            }
            else if (tc_modifySet.SelectedIndex == 1)
            {
                cb_controlSubject.Items.Clear();
                cb_controlClass.Items.Clear();
                foreach (var item in tableSuject)
                {
                    cb_controlSubject.Items.Add(item);
                }
                foreach (var item in tableClassification)
                {
                    cb_controlClass.Items.Add(item);
                }
            }
        }

        private void btn_addSubj_Click(object sender, EventArgs e)
        {
            if (cb_controlSubject.Text == String.Empty)
            {
                lbl_tabModfiyMes.Text = "請填入要新增的內容";
            }
            if (!cb_controlSubject.Items.Contains(cb_controlSubject.Text))
            {
                cb_controlSubject.Items.Add(cb_controlSubject.Text);
                tableSuject.Add(cb_controlSubject.Text);
            }
        }

        private void btn_delSubj_Click(object sender, EventArgs e)
        {
            if (cb_controlSubject.Text == String.Empty)
            {
                lbl_tabModfiyMes.Text = "請選擇要刪除的內容";
            }
            if (cb_controlSubject.Items.Contains(cb_controlSubject.Text))
            {
                tableSuject.Remove(cb_controlSubject.Text);
                cb_controlSubject.Items.Remove(cb_controlSubject.Text);
            }
        }

        private void btn_addClass_Click(object sender, EventArgs e)
        {
            if (cb_controlClass.Text == String.Empty)
            {
                lbl_tabModfiyMes.Text = "請填入要新增的內容";
            }
            if (!cb_controlClass.Items.Contains(cb_controlClass.Text))
            {
                cb_controlClass.Items.Add(cb_controlClass.Text);
                tableSuject.Add(cb_controlClass.Text);
            }
        }

        private void btn_delClass_Click(object sender, EventArgs e)
        {
            if (cb_controlClass.Text == String.Empty)
            {
                lbl_tabModfiyMes.Text = "請選擇要刪除的內容";
            }
            if (cb_controlClass.Items.Contains(cb_controlClass.Text))
            {
                tableClassification.Remove(cb_controlClass.Text);
                cb_controlClass.Items.Remove(cb_controlClass.Text);
            }
        }

        private void btn_openPomo_Click(object sender, EventArgs e)
        {
            Form_pomodoro new_form = new Form_pomodoro();
            new_form.ShowDialog();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            From_settings new_form = new From_settings();
            new_form.ShowDialog();
        }
    }
}
