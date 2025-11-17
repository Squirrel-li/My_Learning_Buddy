using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.Component;

namespace project
{
    public partial class Form1 : Form
    {
        String[] table_suject;
        String[] table_classification;
        String[] table_fl_text;
        public Form1()
        {
            InitializeComponent();
            init_form();
        }
        

        private void init_form()
        {
            this.table_suject = new String[] { "計算機結構", "視窗程式設計" };
            this.table_classification = new String[] { "考試", "報告", "作業" };
            this.table_fl_text = new string[] { "今天", "明天", ""};
            for (int i = 0; i < 3; i++)
            {
                FL_Panel new_panel = new FL_Panel(flpanel_calendar, $"FL_{i}", $"test_test", 3);
                new_panel.add_to_FLPanel();

                for (UInt16 i = 0; i < 10; i++)
                {
                    String index = $"{i}\r\ntest {i}\r\ntest {i}";
                    int[] task_deadline = new int[3] { 0, 1, 2 };
                    TO_DO_TASK new_task = new TO_DO_TASK((ushort)((UInt16)i % 2), (ushort)((UInt16)i % 3), "test", new int[3] { 0, 1, 2 });
                    new_task.add_to_panel(new_panel, this.table_suject, this.table_classification);
                    /*TB_TASK current_task = new TB_TASK(flowLayoutPanel1, new_task, this.table_suject, this.table_classification);
                    current_task.add_to_form();*/
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(UInt16 i = 0; i < 10; i++)
            {
                String index = $"{i}\r\ntest {i}\r\ntest {i}";
                int[] task_deadline = new int[3] { 0, 1, 2 };
                TO_DO_TASK new_task = new TO_DO_TASK((ushort)((UInt16)i%2), (ushort)((UInt16)i % 3), "test", new int[3] { 0, 1, 2 });
                new_task.add_to_panel(flowLayoutPanel1, this.table_suject, this.table_classification);
                /*TB_TASK current_task = new TB_TASK(flowLayoutPanel1, new_task, this.table_suject, this.table_classification);
                current_task.add_to_form();*/
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
