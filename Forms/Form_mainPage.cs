using AntdUI;
using project.Component;
using project.Forms;
using project.util;
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
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;




namespace project
{
    public partial class Form_mainPage : AntdUI.Window
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

        private static bool debug = false;

        private ushort showPanel;
        private ushort showRangeMode;
        private int[] tableShowRange;

        public Form_mainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initBackColor();
            //this.Resizable = false;
            if (debug)
            {
                lbl_debug.Text = "Debug 模式開啟\n\r";
                lbl_tabModfiyMes.Text = "tabModfiyMes";
            }
            else
            {
                lbl_debug.Text = "";
                lbl_tabModfiyMes.Text = "";
            }

            // Init Tables and combobox data
            InitTables();

            // Init panel data
            showPanel = jsonManager.Get_showPanel();
            showRangeMode = jsonManager.Get_showRangeMode();

            InitCalendarPanel(showPanel);
            // Load TO-DO Task data
            loadToDoTask();

            initSelectColor();
            select_subject.Text = tableSubject[0];
            select_classification.Text = tableClassification[0];

            dateTimeP_select.Value = DateTime.Now;
            //backColorSet.SetPanelBackItemColor(panel_Task);
            //backColorSet.SetPanelBackItemColor(panel_modeify);
        }
        
        void initBackColor()
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = ThemeColor.BackPrimary;
            }
            pageHeader.BackColor = ThemeColor.BackHeader;
            pageHeader.ColorScheme = TAMode.Dark;
            panel_body.Back = ThemeColor.BackBorder;
            
            splitter_sideAndCalendar.SplitterBack = ThemeColor.BackPrimary;
            splitter_addAndButton.SplitterBack = ThemeColor.BackPrimary;

            tabs_modifySet.BackColor = ThemeColor.BackPrimary;

            tb_addToDo.BackColor = ThemeColor.BackPrimary;
            panel_side1.Back = ThemeColor.BackSurface;
            //panel_side1.ShadowColor = ColorTranslator.FromHtml("#423832");
            //panel_side1.ShadowOpacity = 20;
            FLPanel_side1.BackColor = Color.Transparent;
            input_taskDescribe.BackColor = ThemeColor.BackInput;
            select_subject.BackColor = ThemeColor.BackInput;
            select_classification.BackColor = ThemeColor.BackInput;
            tooltip_subject.BackColor = ThemeColor.BackSurface;
            tooltip_class.BackColor = ThemeColor.BackSurface;
            dateTimeP_select.BackColor = ThemeColor.BackInput;
            select_selectColor.BackColor = ThemeColor.BackInput;
            btn_addTask.DefaultBack = ThemeColor.BackButtonAccent;
            btn_addTask.ForeColor = ThemeColor.BackInput;
            panel_sideTabClass.BackColor = ThemeColor.BackSurface;
            panel_sideTabSubject.BackColor = ThemeColor.BackSurface;
            panel_sideTabDeadline.BackColor = ThemeColor.BackSurface;
            panel_sideTabDescript.BackColor = ThemeColor.BackSurface;
            panel_sideTabColor.BackColor = ThemeColor.BackSurface;
            panel_sideTabAddTask.BackColor = ThemeColor.BackSurface;

            tb_addSubjClass.BackColor = ThemeColor.BackPrimary;
            panel_side2.Back = ThemeColor.BackSurface;
            //panel_side2.ShadowColor = ColorTranslator.FromHtml("#423832");
            //panel_side2.ShadowOpacity = 20;
            FLPanel_side2.BackColor = Color.Transparent;
            panel_sideTabSubjectLabel.BackColor = ThemeColor.BackSurface;
            panel_sideTabClassLabel.BackColor = ThemeColor.BackSurface;
            panel_sideTabClassControl.BackColor = ThemeColor.BackSurface;
            panel_sideTabSubjectControl.BackColor = ThemeColor.BackSurface;
            select_controlSubject.BackColor = ThemeColor.BackInput;
            select_controlClass.BackColor = ThemeColor.BackInput;
            btn_addSubj.DefaultBack = ThemeColor.BackButtonAccent;
            btn_addSubj.ForeColor = ThemeColor.BackInput;
            btn_delSubj.DefaultBack = ThemeColor.BackSurface;
            btn_delSubj.BorderWidth = 2;
            btn_delSubj.DefaultBorderColor = ThemeColor.BackBorder;
            btn_delSubj.ForeColor = ThemeColor.TextSecondary;
            btn_addClass.DefaultBack = ThemeColor.BackButtonAccent;
            btn_addClass.ForeColor = ThemeColor.BackInput;
            btn_delClass.DefaultBack = ThemeColor.BackSurface;
            btn_delClass.BorderWidth = 2;
            btn_delClass.DefaultBorderColor = ThemeColor.BackBorder;
            btn_delClass.ForeColor = ThemeColor.TextSecondary;

            gridPanel_funButton.BackColor = ThemeColor.BackPrimary;
            btn_settings.DefaultBack = ThemeColor.BackPrimary;
            btn_settings.DefaultBorderColor = ThemeColor.BackBorder;
            btn_settings.ForeColor = ThemeColor.TextSecondary;
            btn_openPomo.DefaultBack = ThemeColor.BackPrimary;
            btn_openPomo.DefaultBorderColor = ThemeColor.BackBorder;
            btn_openPomo.ForeColor = ThemeColor.TextSecondary;

            gridpanel_calendar.Back = ThemeColor.BackPrimary;/*


            label1;
            label3;
            label2;
            label4;
            label6;
            label9;
            Label10;
            lbl_tabModfiyMes;
            lbl_debug;*/
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
            tableShowRange = new int[] { 7, 30, 60, -1 };
        }

        private void InitCalendarPanel(ushort showPanel)
        {
            String settingsText = "";
            for (int i = 0; i < showPanel; i++)
            {
                settingsText += $"{100/showPanel}% ";
            }
            gridpanel_calendar.Span = settingsText;


            //StackPanel new_stackPanel = new StackPanel();
            for (int i = showPanel - 1; i >= 0; i--)
            {
                //lbl_debug.Text += $"初始化 FL_Panel {i}\n";
                AntdUI.StackPanel task_panel = new AntdUI.StackPanel();
                task_panel.Vertical =true;
                task_panel.AutoScroll = true;
                task_panel.Tag = $"FL_{i}";
                task_panel.BorderStyle = DashStyle.Solid;
                task_panel.BorderWidth = 5;
                task_panel.Dock = DockStyle.Fill;
                task_panel.Back = ThemeColor.BackPrimary;
                task_panel.Radius = 10;
                task_panel.Margin = new Padding(2, 2, 2, 2);
                AntdUI.Label fl_label = new AntdUI.Label();
                if (i < tableFLPanelText.Count - 1)
                {
                    fl_label.Text = tableFLPanelText[i];
                }
                else if (i < showPanel - 1)
                {
                    fl_label.Text = $"{i} 天後";
                }
                else if (i == showPanel - 1)
                {
                    fl_label.Text = "更久以後";
                }
                fl_label.Font = new Font("Microsoft JhengHei", 12, FontStyle.Bold);
                fl_label.Height = 30;
                fl_label.Margin = new Padding(0, 10, 0, 0);
                fl_label.TextAlign = ContentAlignment.MiddleCenter;
                fl_label.Dock = DockStyle.Top;
                fl_label.ForeColor = ThemeColor.TextSecondary;

                AntdUI.Panel ContainerStackPanel = new AntdUI.Panel();
                ContainerStackPanel.Tag = "Container";
                ContainerStackPanel.Margin = new Padding(0, 0, 0, 0);
                ContainerStackPanel.Padding = new Padding(0, 0, 0, 0);
                ContainerStackPanel.Radius = 20;
                ContainerStackPanel.Back = ThemeColor.BackPrimary;
                ContainerStackPanel.BackColor = ThemeColor.BackPrimary;

                gridpanel_calendar.Controls.Add(ContainerStackPanel);

                ContainerStackPanel.Controls.Add(task_panel);
                ContainerStackPanel.Controls.Add(fl_label);
            }
        }

        private void initSelectIndex(AntdUI.Select selectInput, List<String> table)
        {
            selectInput.Items.Clear();
            foreach (String element in table) 
            {
                AddSelectIndex(selectInput, element);
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
                AntdUI.StackPanel targetPanel = null;
                int dayDiff = (toDoTask.deadline.Date - DateTime.Today).Days;
                showRangeMode = jsonManager.Get_showRangeMode();
                if (tableShowRange[showRangeMode] - 1 >= dayDiff || tableShowRange[showRangeMode] == -1)
                {
                    if (0 > dayDiff && !toDoTask.finish)
                    {
                        targetPanel = find_pnaelinlanel(this.gridpanel_calendar, "FL_0") ?? throw new Exception("cant find panel");
                        toDoTask.add_to_panel(targetPanel);
                    }
                    else if (panelNum - 1 > dayDiff && dayDiff >= 0)
                    {
                        targetPanel = find_pnaelinlanel(this.gridpanel_calendar, $"FL_{dayDiff}") ?? throw new Exception("cant find panel");
                        toDoTask.add_to_panel(targetPanel);
                    }
                    else if (dayDiff >= panelNum - 1)
                    {
                        targetPanel = find_pnaelinlanel(this.gridpanel_calendar, $"FL_{panelNum - 1}") ?? throw new Exception("cant find panel");
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
            if (select_subject.Text == String.Empty)
            {
                tooltip_subject.Show();
            }
            if (select_classification.Text == String.Empty)
            {
                tooltip_class.Show();
            }
            if (select_subject.Text == String.Empty || select_classification.Text == String.Empty)
            {
                timer_toopTipShow.Enabled = false;
                timer_toopTipShow.Enabled = true;
                return;
            }
            else
            {
                if (!select_subject.Items.Contains(select_subject.Text))
                {
                    AddSelectIndex(select_subject, select_subject.Text);
                    tableSubject.Add(select_subject.Text);
                    //lbl_debug.Text += "select_subject：\n";
                    foreach (var item in select_subject.Items)
                    {
                        //lbl_debug.Text += item.ToString() + "\n";
                    }
                    this.jsonManager.Save_table_subject(tableSubject);
                }
                if (!select_classification.Items.Contains(select_classification.Text))
                {
                    AddSelectIndex(select_classification, select_classification.Text);
                    tableSubject.Add(select_classification.Text);
                    //lbl_debug.Text += "select_classification：\n";
                    foreach (var item in select_classification.Items)
                    {
                        //lbl_debug.Text += item.ToString() + "\n";
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
                //lbl_debug.Text = "";
                int dayDiff = (dateTime.Date - DateTime.Today).Days;
                if (!new_toDoTask.finish)
                {
                    StackPanel targetPanel;
                    showRangeMode = jsonManager.Get_showRangeMode();
                    if (tableShowRange[showRangeMode] - 1 >= dayDiff || tableShowRange[showRangeMode] == -1)
                    {
                        if (0 > dayDiff && !new_toDoTask.finish)
                        {
                            targetPanel = find_pnaelinlanel(this.gridpanel_calendar, "FL_0") ?? throw new Exception("cant find panel");
                            new_toDoTask.add_to_panel(targetPanel);
                        }
                        else if (panelNum - 1 > dayDiff && dayDiff >= 0)
                        {
                            targetPanel = find_pnaelinlanel(this.gridpanel_calendar, $"FL_{dayDiff}") ?? throw new Exception("cant find panel");
                            new_toDoTask.add_to_panel(targetPanel);
                        }
                        else if (dayDiff >= panelNum - 1)
                        {
                            targetPanel = find_pnaelinlanel(this.gridpanel_calendar, $"FL_{panelNum - 1}") ?? throw new Exception("cant find panel");
                            new_toDoTask.add_to_panel(targetPanel);
                        }
                    }
                }
            }
        }

        private AntdUI.StackPanel find_pnaelinlanel(AntdUI.GridPanel sourcePanel, String tag)
        {
            List<AntdUI.Panel> ContainerPanels = new List<AntdUI.Panel>();
            AntdUI.StackPanel targetPanel = null;
            foreach (Control control in sourcePanel.Controls)
            {
                if (control is AntdUI.Panel fl && control.Tag?.ToString() == "Container")
                {
                    ContainerPanels.Add(fl);
                }
            }
            foreach (AntdUI.Panel ContainerPanel in ContainerPanels)
            {
                foreach (Control control in ContainerPanel.Controls)
                {
                    if (control is AntdUI.StackPanel fl && control.Tag?.ToString() == tag)
                    {
                        targetPanel = fl;
                        break; // 找到就跳出
                    }
                }
            }
            if (targetPanel == null)
            {
                MessageBox.Show("找不到標記為 FL_0 的 FL_Panel");
                return null;
            }
            return targetPanel;
        }

        private void tabs_modifySet_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            if (tabs_modifySet.SelectedIndex == 0)
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
            else if (tabs_modifySet.SelectedIndex == 1)
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
                    select_controlSubject.ClearSelect();
                    select_controlSubject.Items.Remove(Item);
                    this.jsonManager.Save_table_subject(tableSubject);
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
                    select_controlClass.ClearSelect();
                    select_controlClass.Items.Remove(Item);
                    this.jsonManager.Save_table_subject(tableClassification);
                }
            }
        }

        private void btn_openPomo_Click(object sender, EventArgs e)
        {
            Form_pomodoro new_form = new Form_pomodoro(debug);
            new_form.ShowDialog();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            From_settings new_form = new From_settings();
            new_form.ShowDialog();
            
            gridpanel_calendar.Controls.Clear();
            JsonManager jsonManager = new JsonManager();
            panelNum = jsonManager.Get_showPanel();
            InitCalendarPanel(panelNum);
            loadToDoTask();
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

        private void select_subject_MouseEnter(object sender, EventArgs e)
        {
            tooltip_subject.Hide();
        }

        private void select_classification_MouseEnter(object sender, EventArgs e)
        {
            tooltip_class.Hide();
        }

        private void timer_toopTipShow_Tick(object sender, EventArgs e)
        {
            tooltip_subject.Hide();
            tooltip_class.Hide();
            timer_toopTipShow.Enabled = false;
        }
    }
}
