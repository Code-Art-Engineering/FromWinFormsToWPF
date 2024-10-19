using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormStyle
{
    public class ThemedButton : Button
    {
        public ThemedButton()
        {
            this.BackColor = Color.LightGreen;
            this.ForeColor = Color.DarkGreen;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Tahoma", 12, FontStyle.Bold);
            this.FlatAppearance.BorderColor = Color.DarkGreen;
            this.FlatAppearance.BorderSize = 2;
        }
    }
}
