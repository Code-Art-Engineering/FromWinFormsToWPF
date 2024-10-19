using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormStyle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StyleHelper.ApplyButtonStyle(myButton1);
            StyleHelper.ApplyButtonStyle(myButton2);
            
            ApplySystemStyle(button1);
            ApplySystemStyle(button2);

            GlobalStyles.LoadStyles("styles.json");
            ApplyGlobalStyle(button4);
            ApplyGlobalStyle(button5);
            
        }

        public void ApplySystemStyle(Control control)
        {
            control.BackColor = SystemColors.Control;
            control.ForeColor = SystemColors.ControlText;
            control.Font = SystemFonts.DefaultFont;
        }

        public void ApplyGlobalStyle(Control control)
        {
            control.BackColor = GlobalStyles.DefaultBackColor;
            control.ForeColor = GlobalStyles.DefaultForeColor;
            control.Font = GlobalStyles.DefaultFont;

            if(control.GetType() == typeof(Button))
            {
                control.BackColor = GlobalStyles.ButtonBackColor;
                control.ForeColor = GlobalStyles.ButtonForeColor;   
            }
        }

    }
}
