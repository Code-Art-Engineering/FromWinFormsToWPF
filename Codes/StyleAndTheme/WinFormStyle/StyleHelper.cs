using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormStyle
{
    internal static class StyleHelper
    {
        public static void ApplyButtonStyle(Button button)
        {
            button.BackColor = Color.LightBlue;
            button.ForeColor = Color.DarkBlue;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Arial", 10, FontStyle.Bold);
        }
    }
}
