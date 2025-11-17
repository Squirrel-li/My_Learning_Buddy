using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace project.Component
{
    internal class main_page
    {
    }
    class TO_DO_TASK
    {
        // 任務
        public TO_DO_TASK(UInt16 suject, UInt16 classification, String task_describe, int[] deadline)
        {
            this.suject = suject;
            this.classification = classification;
            this.task_describe = task_describe;
            //this.deadline = deadline;
            this.deadline = DateTime.Now;
        }

        public void add_to_panel(FlowLayoutPanel contain_flpanel, String[] table_suject, String[] table_classification)
        {
            TB_TASK current_task = new TB_TASK(contain_flpanel, this, table_suject, table_classification);
            current_task.add_to_panel();
        }

        public UInt16 suject;
        public UInt16 classification;
        public String task_describe = "";
        public DateTime deadline;
        public bool done = false;
    }

    //顯示的任務 text_box
    class TB_TASK : TextBox
    {
        private FlowLayoutPanel target_panel;
        public TB_TASK(FlowLayoutPanel contain_flpanel, TO_DO_TASK input, String[] table_suject, String[] table_classification)
        {
            this.target_panel = contain_flpanel;
            this.Width = contain_flpanel.Width - 20 - (contain_flpanel.Margin.Left + contain_flpanel.Margin.Right);
            this.BorderStyle = BorderStyle.None;

            //this.ScrollBars = ScrollBars.Vertical;
            this.Multiline = true;
            this.TextAlign = HorizontalAlignment.Center;
            this.Enabled = false;
            this.Cursor = Cursors.Default;
            this.ForeColor = Color.Black;

            String text_index = text_set(input, table_suject, table_classification);

            int str_long = table_suject[input.suject].Length;
            if (str_long > 5)
            {
                this.Font = new Font("標楷體", (this.Width - 7) / (str_long + 2));
            }
            else
            {
                this.Font = new Font("標楷體", 16);
            }
            this.ReadOnly = true;
            this.Text = text_index;
            this.Height = this.FontHeight * 3 + 2;
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

        private String text_set(TO_DO_TASK input, String[] table_suject, String[] table_classification)
        {
            String result = "";
            result = $"{table_suject[input.suject]}\r\n{table_classification[input.classification]}\r\n{input.task_describe}";
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
            this.Width = target_FLPanel.Width / show_num - (target_FLPanel.Padding.Left + target_FLPanel.Padding.Right);
            this.Name = name;
            this.Text = show_text;
            this.Height = target_FLPanel.Height - 27;
        }

        public void add_to_FLPanel()
        {
            this.target_FLPanel.Controls.Add(this);
        }
    }
}
