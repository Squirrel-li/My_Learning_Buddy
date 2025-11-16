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
    public partial class Form1 : Form
    {
        String[] table_suject;
        String[] table_classification;
        public Form1()
        {
            InitializeComponent();
            init_form();
        }
        class TASK_template
        {
            public TASK_template(UInt16 suject, UInt16 classification, String task_describe, int[] deadline)
            {
                this.suject = suject;
                this.classification = classification;
                this.task_describe = task_describe;
                //this.deadline = deadline;
                this.deadline = DateTime.Now;
            }
            public UInt16 suject;
            public UInt16 classification;
            public String task_describe = "";
            public DateTime deadline;
            public bool done = false;
        }
        class TB_TASK : TextBox
        {
            public TB_TASK(FlowLayoutPanel contain_flpanel, TASK_template input, String[] table_suject, String[] table_classification)
            {
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
                    this.Font = new Font("標楷體", (this.Width-7)/(str_long+2));
                }
                else
                {
                    this.Font = new Font("標楷體", 16);
                }
                this.ReadOnly = true;
                this.Text = text_index;
                this.Height = this.FontHeight * 3 + 2;
            }

            private String text_set(TASK_template input, String[] table_suject, String[] table_classification)
            {
                String result = "";
                result = $"{table_suject[input.suject]}\r\n{table_classification[input.classification]}\r\n{input.task_describe}";
                return result;
            }
        }

        private void init_form()
        {
            this.table_suject = new String[] { "計算機結構", "視窗程式設計" };
            this.table_classification = new String[] { "考試", "報告", "作業" };
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void gb_0_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(UInt16 i = 0; i < 10; i++)
            {
                String index = $"{i}\r\ntest {i}\r\ntest {i}";
                int[] task_deadline = new int[3] { 0, 1, 2 };
                TASK_template new_task = new TASK_template((ushort)((UInt16)i%2), (ushort)((UInt16)i % 3), "test", new int[3] { 0, 1, 2 });
                TB_TASK btn = new TB_TASK(flowLayoutPanel1, new_task, this.table_suject, this.table_classification);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
