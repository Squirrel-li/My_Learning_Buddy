using project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using AntdUI;

namespace project.Component
{
    public class ToDoTask
    {
        public ToDoTask() { }
        public ToDoTask(String subject, String classification, String task_describe, DateTime deadline, String themeColor)
        {
            this.subject = subject;
            this.classification = classification;
            this.taskDescribe = task_describe;
            this.deadline = deadline;
            this.themeColor = themeColor;

            this.finish = false;
        }

        public void add_to_panel(FlowLayoutPanel contain_flpanel)
        {
            TB_TASK current_task = new TB_TASK(contain_flpanel, this);
            current_task.add_to_panel();
        }

        public String subject { get; set; }
        public String classification { get; set; }
        public String taskDescribe { get; set; }
        public DateTime deadline { get; set; }
        public bool finish { get; set; }
        public String themeColor { get; set; }
    }

    //顯示的任務 text_box
    class TB_TASK : System.Windows.Forms.TextBox
    {
        private FlowLayoutPanel target_panel;
        private ToDoTask task;
        public DateTime Deadline => task?.deadline ?? DateTime.MaxValue;
        public TB_TASK(FlowLayoutPanel contain_flpanel, ToDoTask input)
        {
            // 初始化
            this.target_panel = contain_flpanel;
            this.task = input;

            // 基本屬性設定
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Multiline = true;
            this.TextAlign = HorizontalAlignment.Center;
            this.Enabled = true;
            this.Cursor = Cursors.Default;
            this.ForeColor = Color.Black;
            this.BackColor = ColorTranslator.FromHtml(input.themeColor);
            this.Font = new Font("微軟正黑體", 12);
            this.ReadOnly = true;
            this.Text = text_set(input);
            this.Height = this.FontHeight * 4 + 2;
            this.Width = target_panel.Width - 12 - 15;

            // 右鍵選單
            System.Windows.Forms.ContextMenuStrip cms = new System.Windows.Forms.ContextMenuStrip();

            cms.Font = new Font("微軟正黑體", 12);

            ToolStripMenuItem editItem = new ToolStripMenuItem("編輯活動");
            ToolStripMenuItem finishItem = new ToolStripMenuItem("活動完成");
            ToolStripMenuItem delItem = new ToolStripMenuItem("刪除活動");

            editItem.Click += (s, e) => { this.ReadOnly = false; };
            finishItem.Click += (s, e) => 
            {
                JsonManager jsonManager = new JsonManager();
                int id = jsonManager.Find_ToDoTask_Id(this.task);
                this.task.finish = true;
                this.target_panel.Controls.Remove(this);
                jsonManager.Update_tableToDoTask(id, this.task);
            };

            delItem.Click += (s, e) =>
            {
                JsonManager jsonManager = new JsonManager();
                this.target_panel.Controls.Remove(this);
                jsonManager.Remove_tableToDoTask(this.task);
            };

            cms.Items.AddRange(new ToolStripItem[]
            {
                editItem,
                finishItem,
                new ToolStripSeparator(),
                delItem
            });

            this.ContextMenuStrip = cms;

            // 滑鼠移入移出效果
            this.MouseEnter += (s, e) => 
            {
                this.BackColor = ControlPaint.Light(ColorTranslator.FromHtml(input.themeColor));
                this.Width += 4;
                this.Height += 4;
            };
            this.MouseLeave += (s, e) =>
            {
                this.BackColor = ColorTranslator.FromHtml(input.themeColor);
                this.Width -= 4;
                this.Height -= 4;
            };

            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.ReadOnly = true;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };
        }

        public void add_to_panel()
        {
            try
            {
                // 依截止日期排序插入
                int insertionIndex = this.target_panel.Controls.Count;

                // 根據截止日期找到插入位置
                for (int i = 1; i < this.target_panel.Controls.Count; i++)
                {
                    var c = this.target_panel.Controls[i];
                    if (c is TB_TASK otherTask)
                    {
                        if (otherTask.Deadline > this.Deadline)
                        {
                            insertionIndex = i;
                            break;
                        }
                    }
                }

                // 確保索引不小於1，因為索引0可能是標題
                if (insertionIndex < 1)
                    insertionIndex = 1;

                // 插入控件
                this.target_panel.Controls.Add(this);
                // 調整控件順序
                this.target_panel.Controls.SetChildIndex(this, insertionIndex);
            }
            catch (Exception ex)
            {
                throw new Exception($"add to form fail, {ex}");
            }
        }

        private String text_set(ToDoTask input)
        {
            String result = "";
            result = $"{input.subject}\r\n";

            if (input.deadline.Date == DateTime.Now.Date)
                result += "今天 ";
            else
                result += $"{input.deadline:yyyy/MM/dd} ";

            result += $"{input.deadline:HH:mm}\r\n";
            result += $"{input.classification}\r\n";
            result += (string.IsNullOrEmpty(input.taskDescribe)) ? "無敘述" : $"{input.taskDescribe}";
            return result;
        }
    }

    class FL_Panel : FlowLayoutPanel
    {
        FlowLayoutPanel target_FLPanel;
        public FL_Panel(FlowLayoutPanel target_FLPanel, String name, String show_text, UInt16 show_num)
        {
            this.target_FLPanel = target_FLPanel;

            int usable = target_FLPanel.Width - 9;
            int margin = this.Margin.Left + this.Margin.Right;
            int finalWidth = (usable - (show_num - 1) * margin) / show_num;
            this.Width = finalWidth;

            this.AutoScroll = true;
            this.FlowDirection = FlowDirection.TopDown;
            this.WrapContents = false;
            this.AutoSize = false;

            this.Font = new Font("微軟正黑體", 15);
            this.Name = name;
            this.Height = target_FLPanel.Height - 9;
            this.Tag = name;

            System.Windows.Forms.Label lbl_title = new System.Windows.Forms.Label()
            {
                Text = show_text,
                Height = 25,
                Width = this.Width - 12 - 15,
                Font = new Font("微軟正黑體", 15),
                TextAlign = ContentAlignment.BottomCenter,
            };

            this.Controls.Add(lbl_title);
        }

        public void add_to_FLPanel()
        {
            this.target_FLPanel.Controls.Add(this);
        }
    }
}
