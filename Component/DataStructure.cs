using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public static class ThemeColor
    {
        public static Color BackHeader { get; set; } = ColorTranslator.FromHtml("#423832");    // 全域背景
        public static Color BackPrimary { get; set; } = ColorTranslator.FromHtml("#F9F7F5");    // 全域背景
        public static Color BackSurface { get; set; } = ColorTranslator.FromHtml("#EFEDE8");   // 側邊欄/區塊底色
        public static Color BackButtonAccent { get; set; } = ColorTranslator.FromHtml("#C69C6D");    // 強調色 (主按鈕)
        public static Color BackBorder { get; set; } = ColorTranslator.FromHtml("#C69C6D");    // 輔助色 (分隔線)
        public static Color BackInput { get; set; } = ColorTranslator.FromHtml("#FFFFFF");    // 元件背景 (Input、Select)
        public static Color TextPrimary { get; set; } = ColorTranslator.FromHtml("#423832");    // 主要文字
        public static Color TextSecondary { get; set; } = ColorTranslator.FromHtml("#8C8279");    // 次要文字
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
