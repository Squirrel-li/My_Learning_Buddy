using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;
using project;

namespace project.Component
{
    internal class main_page
    {
    }
    class TO_DO_TASK
    {
        // 任務
        public TO_DO_TASK(String suject, String classification, String task_describe, DateTime deadline)
        {
            this.suject = suject;
            this.classification = classification;
            this.task_describe = task_describe;
            this.deadline = deadline;
            //this.deadline = DateTime.Now;
        }

        public void add_to_panel(FlowLayoutPanel contain_flpanel)
        {
            TB_TASK current_task = new TB_TASK(contain_flpanel, this);
            current_task.add_to_panel();
        }

        public String suject;
        public String classification;
        public String task_describe = "";
        public DateTime deadline;
        public bool done = false;
    }

    //顯示的任務 text_box
    class TB_TASK : TextBox
    {
        private FlowLayoutPanel target_panel;
        public TB_TASK(FlowLayoutPanel contain_flpanel, TO_DO_TASK input)
        {
            this.target_panel = contain_flpanel;
            //.Width = contain_flpanel.Width - 20 - (contain_flpanel.Margin.Left + contain_flpanel.Margin.Right);
            this.BorderStyle = BorderStyle.None;

            //this.ScrollBars = ScrollBars.Vertical;
            this.Multiline = true;
            this.TextAlign = HorizontalAlignment.Center;
            this.Enabled = false;
            this.Cursor = Cursors.Default;
            this.ForeColor = Color.Black;

            String text_index = text_set(input);

            this.Font = new Font("標楷體", 16);
            this.ReadOnly = true;
            this.Text = text_index;
            this.Height = this.FontHeight * 3 + 2;
            this.Width = target_panel.Width - 12;
        }

        public void add_to_panel()
        {
            try
            {
                this.target_panel.Controls.Add(this);
            }
            catch (Exception ex)
            {
                throw new Exception($"add to form fail, {ex}");
            }
        }

        private String text_set(TO_DO_TASK input)
        {
            String result = "";
            result = $"{input.suject}\r\n" +
                        $"{input.classification}\r\n";
            result += (string.IsNullOrEmpty(input.task_describe)) ? "無敘述" : $"{input.task_describe}";
            return result;
        }
    }

    class FL_Panel : FlowLayoutPanel
    {
        FlowLayoutPanel target_FLPanel;
        public FL_Panel(FlowLayoutPanel target_FLPanel, String name, String show_text, UInt16 show_num)
        {
            this.Font = new Font("標楷體", 15);
            this.target_FLPanel = target_FLPanel;
            

            int usable = target_FLPanel.Width - 9;

            int margin = this.Margin.Left + this.Margin.Right;

            int finalWidth = (usable - (show_num - 1) * margin) / show_num;
            this.Width = finalWidth;

            this.FlowDirection = FlowDirection.TopDown;
            this.WrapContents = false;
            this.AutoScroll = true;
            this.AutoSize = false;


            this.Name = name;
            this.Height = target_FLPanel.Height - 9;
            this.Tag = name;
            this.BorderStyle = BorderStyle.FixedSingle;
            /*String debug_mess = "";
            debug_mess += $"this.Padding {this.Padding.Top}\n";
            debug_mess += $"this.Padding {this.Padding.Bottom}\n";
            debug_mess += $"this.Margin {this.Margin.Top}\n";
            debug_mess += $"this.Margin {this.Margin.Bottom}\n";
            debug_mess += $"target_FLPanel.Padding {target_FLPanel.Padding.Top}\n";
            debug_mess += $"target_FLPanel.Padding {target_FLPanel.Padding.Bottom}\n";
            debug_mess += $"target_FLPanel.Margin {target_FLPanel.Margin.Top}\n";
            debug_mess += $"target_FLPanel.Margin {target_FLPanel.Margin.Bottom}\n";
            Label lbl_debug = new Label()
            {
                Text = debug_mess,
                Height = 100,
                Width = this.Width - 20,
                Font = new Font("標楷體", 9),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lbl_debug);*/

            Label lbl_title = new Label()
            {
                Text = show_text,
                Height = 20,
                Width = this.Width - 12,
                Font = new Font("標楷體", 15),
                TextAlign = ContentAlignment.MiddleCenter
            };

            this.Controls.Add(lbl_title);
        }


        public void add_to_FLPanel()
        {
            this.target_FLPanel.Controls.Add(this);
        }
    }
}
