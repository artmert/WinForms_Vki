using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Util
{
    public class TxtCleaner
    {
        public static void Temizle(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i].GetType().ToString().ToLower() == "system.windows.forms.textbox")
                {
                    control.Controls[i].Text = "";
                }
            }
        }
    }
}
