using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.util
{
    internal class backColorSet
    {
        static public void SetPanelBackItemColor(AntdUI.Panel panel)
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
                if (Item is AntdUI.Tooltip)
                {
                    AntdUI.Tooltip item = (AntdUI.Tooltip)Item;
                    item.BackColor = Color.FromArgb(255, 230, 230, 230);
                }
            }
        }
    }
}
