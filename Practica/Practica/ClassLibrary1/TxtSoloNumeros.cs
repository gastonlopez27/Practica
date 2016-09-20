using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClassLibrary1
{
    public class TxtSoloNumeros : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;
            if (char.IsDigit(tecla) || char.IsControl(tecla))
            {
                base.OnKeyPress(e);

            }
            else
                e.Handled = true;
        }
    }
}
