using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class ThemeColor
    {
        public Color PrimaryColor { get; set; } = ColorTranslator.FromHtml("#2ECC71");
        public Color BackgroundColor { get; set; } = ColorTranslator.FromHtml("#F0F2F5");
        public Color SurfaceColor { get; set; } = ColorTranslator.FromHtml("#FFFFFF");
        public Color AccentColor { get; set; } = ColorTranslator.FromHtml("#3498DB");
        public Color BorderColor { get; set; } = ColorTranslator.FromHtml("#DCDFE6");
    }

    public class ColorItem
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
}
