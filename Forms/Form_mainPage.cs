using AntdUI;
using project.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace project
{
    public partial class Form_mainPage : Form
    {
        private readonly Dictionary<Color, Image> _colorIconCache = new Dictionary<Color, Image>();
        // Tables
        List<String> tableSubject = new List<String>();
        List<String> tableClassification = new List<String>();
        List<String> tableFLPanelText = new List<String>();
        List<ToDoTask> tableToDoTask = new List<ToDoTask>();

        // Color Table
        List<ColorItem> tableColor = new List<ColorItem>();
        ushort panelNum = 5;

        public JsonManager jsonManager = new JsonManager();

        private bool debug = true;


        private class ColorItem
        {
            public Color Color { get; }
            public string Label { get; }
            public string hexColorCodes { get; }
            public ColorItem(String hexColorCodes, string label)
            {
                this.hexColorCodes = hexColorCodes;
                Color = ColorTranslator.FromHtml(hexColorCodes);
                Label = label;
            }
            public override string ToString()
            {
                return hexColorCodes;
            }
        }

        public Form_mainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (debug)
            {
                lbl_debug.Visible = true;
                lbl_debug.Text = "Debug 模式開啟\n\r";
                lbl_tabModfiyMes.Text = "tabModfiyMes";
                lbl_tabToDoMes.Text = "tabToDoMes";
            }
            else
            {
                lbl_tabModfiyMes.Text = "";
                lbl_tabToDoMes.Text = "";
            }

            // Init Tables and combobox data
            InitTables();

            // Init panel data
            ushort panelNum = 5;
            InitFLPanel(panelNum);

            // Load TO-DO Task data
            loadToDoTask();

            initSelectColor();
            select_subject.SelectedIndex = 0;
            select_classification.SelectedIndex = 0;
        }

        private void InitTables()
        {
            this.tableSubject = jsonManager.Get_table_subject();
            this.tableClassification = jsonManager.Get_tableClassification();
            this.tableFLPanelText = jsonManager.Get_tableFLPanelText();
            if (this.tableFLPanelText.Count == 0)
            {
                this.tableFLPanelText = new List<String> { "今日活動", "明日活動", "久遠以後" };
            }


            this.tableColor = new List<ColorItem>
            {
                new ColorItem("#FFADAD", "柔粉紅"), // Soft Red
                new ColorItem("#FFD6A5", "蜜桃橘"), // Peach
                new ColorItem("#FDFFB6", "淡檸檬"), // Pale Yellow
                new ColorItem("#CAFFBF", "茶綠"), // Tea Green
                new ColorItem("#9BF6FF", "淡青"), // Cyan
                new ColorItem("#A0C4FF", "嬰兒藍"), // Baby Blue
                new ColorItem("#BDB2FF", "淡紫"), // Lavender
                new ColorItem("#FFC6FF", "淡粉紫") // Pink
            };

            initSelectIndex(this.select_subject, tableSubject);
            initSelectIndex(this.select_classification, tableClassification);
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

        private void initSelectIndex(AntdUI.Select selectInput, List<String> table)
        {
            selectInput.Items.Clear();
            foreach (String classification in table) 
            {
                AddSelectIndex(selectInput, classification);
            }
        }

        private void initSelectColor()
        {
            select_selectColor.Items.Clear();
            foreach (var colorItem in tableColor)
            {
                // 將 ColorItem 直接作為 SelectItem 的 Tag，並僅設置 Text 與 Value
                select_selectColor.Items.Add(new AntdUI.SelectItem(
                    colorItem.Label, // Text
                    colorItem.Color  // Value
                )
                {
                    Icon = GetColorDotIcon(colorItem.Color),
                    Tag = colorItem
                });
            }
            select_selectColor.SelectedIndex = 0;
        }


        private void loadToDoTask()
        {
            this.tableToDoTask = jsonManager.Get_tableToDoTask();

            foreach (var toDoTask in this.tableToDoTask)
            {
                FL_Panel targetPanel = null;
                int dayDiff = (toDoTask.deadline.Date - DateTime.Today).Days;
                if (!toDoTask.finish)
                {
                    if (0 > dayDiff)
                    {
                        targetPanel = find_pnaelinlanel(this.flpanel_calendar, "FL_0") ?? throw new Exception("cant find panel");
                        toDoTask.add_to_panel(targetPanel);
                    }
                    else if (panelNum - 1 > dayDiff && dayDiff >= 0)
                    {
                        targetPanel = find_pnaelinlanel(this.flpanel_calendar, $"FL_{dayDiff}") ?? throw new Exception("cant find panel");
                        toDoTask.add_to_panel(targetPanel);
                    }
                    else if (dayDiff >= panelNum - 1)
                    {
                        targetPanel = find_pnaelinlanel(this.flpanel_calendar, $"FL_{panelNum - 1}") ?? throw new Exception("cant find panel");
                        toDoTask.add_to_panel(targetPanel);
                    }
                }
            }
        }

        public void AddSelectIndex(AntdUI.Select SelectInput, String index)
        {
            SelectInput.BeginInvoke((MethodInvoker)delegate
            {
                SelectInput.Items.Add(index);
            });
        }

        private void cb_color_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            // 取出 ColorItem
            var item = select_selectColor.Items[e.Index] as ColorItem;
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
            if (select_subject.Text == String.Empty || select_classification.Text == String.Empty)
            {
                lbl_tabToDoMes.Text = "請填入要新增的內容";
            }
            else
            {
                if (!select_subject.Items.Contains(select_subject.Text))
                {
                    AddSelectIndex(select_subject, select_subject.Text);
                    tableSubject.Add(select_subject.Text);
                    lbl_debug.Text += "select_subject：\n";
                    foreach (var item in select_subject.Items)
                    {
                        lbl_debug.Text += item.ToString() + "\n";
                    }
                    this.jsonManager.Save_table_subject(tableSubject);
                }
                if (!select_classification.Items.Contains(select_classification.Text))
                {
                    AddSelectIndex(select_classification, select_classification.Text);
                    tableSubject.Add(select_classification.Text);
                    lbl_debug.Text += "select_classification：\n";
                    foreach (var item in select_classification.Items)
                    {
                        lbl_debug.Text += item.ToString() + "\n";
                    }
                    this.jsonManager.Save_tableClassification(tableClassification);
                }

                String subject = select_subject.Text;
                String classification = select_classification.Text;
                String taskDescribe = input_taskDescribe.Text;

                // use the DateTimePicker value
                DateTime dateTime;
                if (dateTimeP_select.Value == null)
                {
                    dateTime = DateTime.Now;
                }
                else
                {
                    dateTime = dateTimeP_select.Value?? throw new Exception("dateTimeP_select.Value is null");
                }

                // 取得選到的 Color
                String selectColor = "";
                selectColor = select_selectColor.SelectedValue.ToString();

                // create new toDoTask
                ToDoTask new_toDoTask = new ToDoTask(subject, classification, taskDescribe, dateTime, selectColor);

                jsonManager.add_tableToDoTask(new_toDoTask);

                // add to table
                lbl_debug.Text = "";
                int dayDiff = (dateTime.Date - DateTime.Today).Days;
                if (!new_toDoTask.finish)
                {
                    FL_Panel targetPanel;
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
                select_subject.Items.Clear();
                select_classification.Items.Clear();
                foreach (var item in tableSubject)
                {
                    select_subject.Items.Add(item);
                }
                foreach (var item in tableClassification)
                {
                    select_classification.Items.Add(item);
                }
            }
            else if (tc_modifySet.SelectedIndex == 1)
            {
                select_controlSubject.Items.Clear();
                select_controlClass.Items.Clear();
                foreach (var item in tableSubject)
                {
                    select_controlSubject.Items.Add(item);
                }
                foreach (var item in tableClassification)
                {
                    select_controlClass.Items.Add(item);
                }
            }
        }

        private void btn_addSubj_Click(object sender, EventArgs e)
        {
            if (select_controlSubject.Text == String.Empty)
            {
                lbl_tabModfiyMes.Text = "請填入要新增的內容";
            }
            if (!select_controlSubject.Items.Contains(select_controlSubject.Text))
            {
                select_controlSubject.Items.Add(select_controlSubject.Text);
                tableSubject.Add(select_controlSubject.Text);
                this.jsonManager.Save_table_subject(tableSubject);
            }
        }

        private void btn_delSubj_Click(object sender, EventArgs e)
        {
            if (select_controlSubject.SelectedValue == null)
            {
                lbl_tabModfiyMes.Text = "請選擇要刪除的內容";
                return;
            }
            else
            {
                foreach (var Item in select_controlSubject.SelectedValue)
                {
                    tableSubject.Remove(Item.ToString());
                    select_controlSubject.Items.Remove(Item.ToString());
                    this.jsonManager.Save_table_subject(tableSubject);
                    select_controlSubject.Text = String.Empty;
                }
            }
        }

        private void btn_addClass_Click(object sender, EventArgs e)
        {
            if (select_controlClass.Text == String.Empty)
            {
                lbl_tabModfiyMes.Text = "請填入要新增的內容";
            }
            if (!select_controlClass.Items.Contains(select_controlClass.Text))
            {
                select_controlClass.Items.Add(select_controlClass.Text);
                tableClassification.Add(select_controlClass.Text);
                this.jsonManager.Save_tableClassification(tableClassification);
            }
        }

        private void btn_delClass_Click(object sender, EventArgs e)
        {
            if (select_controlClass.SelectedValue == null)
            {
                lbl_tabModfiyMes.Text = "請選擇要刪除的內容";
                return;
            }
            else
            {
                foreach (var Item in select_controlClass.SelectedValue)
                {
                    tableClassification.Remove(Item.ToString());
                    select_controlClass.Items.Remove(Item.ToString());
                    this.jsonManager.Save_table_subject(tableClassification);
                    select_controlClass.ClearSelect();
                }
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

        private void cb_controlSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_addSubj_Click(sender, e);
            }
            if (e.KeyCode == Keys.Delete)
            {
                btn_delSubj_Click(sender, e);
            }
        }

        private void cb_controlClass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_addClass_Click(sender, e);
            }
            if (e.KeyCode == Keys.Delete)
            {
                btn_delClass_Click(sender, e);
            }
        }

        private void dateTimeP_select_PrefixClick(object sender, MouseEventArgs e)
        {
            dateTimeP_select.Value = DateTime.Now;
        }

        private void dateTimeP_select_ExpandDropChanged(object sender, BoolEventArgs e)
        {
            if (dateTimeP_select.ExpandDrop)
            {
                dateTimeP_select.Value = DateTime.Now;
            }
        }

        private Image GetColorDotIcon(Color color, int size = 14)
        {
            if (_colorIconCache.TryGetValue(color, out var img))
                return img;

            var bmp = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                var rect = new Rectangle(1, 1, size - 2, size - 2);
                using (var b = new SolidBrush(color))
                    g.FillEllipse(b, rect);

                using (var p = new Pen(Color.FromArgb(160, 0, 0, 0), 1))
                    g.DrawEllipse(p, rect);
            }

            _colorIconCache[color] = bmp;
            return bmp;
        }

        private void select_selectColor_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            select_selectColor.BackColor = ColorTranslator.FromHtml(select_selectColor.SelectedValue.ToString());
        }
    }
}
