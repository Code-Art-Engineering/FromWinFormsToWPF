using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace WinFormStyle
{
    public class GlobalStyles
    {
        public static Color DefaultBackColor;
        public static Color DefaultForeColor;
        public static Font DefaultFont;
        public static Font HeaderFont;
        public static Color ButtonBackColor;
        public static Color ButtonForeColor;

        public static void LoadStyles(string jsonFilePath)
        {
            var json = File.ReadAllText(jsonFilePath);
            dynamic styles = JsonConvert.DeserializeObject(json);

            DefaultBackColor = ColorTranslator.FromHtml(styles.DefaultBackColor.ToString());
            DefaultForeColor = ColorTranslator.FromHtml(styles.DefaultForeColor.ToString());
            DefaultFont = new Font("Verdana", 10); // You can extend this to parse the font from JSON
            HeaderFont = new Font("Arial", 14, FontStyle.Bold);
            ButtonBackColor = ColorTranslator.FromHtml(styles.ButtonBackColor.ToString());
            ButtonForeColor = ColorTranslator.FromHtml(styles.ButtonForeColor.ToString());
        }
    }
}
