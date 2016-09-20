using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{

    public enum ETipoDeDato
    {
  Entero,
        Doble,
        Binario,
        Octal,
        Hexadecimal
    }

    class txtSoloNumerosMejorado : TextBox
    {
        private ETipoDeDato _dato;

        public ETipoDeDato DatoAUsar 
        {
            get { return _dato; } 
            set {_dato = value; }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;
            switch (this._dato)
            {
                case ETipoDeDato.Entero:
                    if (!char.IsDigit(tecla) && !char.IsControl(tecla))
                        e.Handled = true;
                    break;
                case ETipoDeDato.Doble:
                    if (!char.IsDigit(tecla) && !char.IsControl(tecla))
                        e.Handled = true;
                    break;
                case ETipoDeDato.Binario:
                    if (tecla != '1' && tecla != '0' && !char.IsControl(tecla))
                        e.Handled = true;
                    break;
                case ETipoDeDato.Octal:
                    if(!(tecla >= '0' && tecla <= '8') && !char.IsControl(tecla))
                        e.Handled = true;
                    break;
                case ETipoDeDato.Hexadecimal:
                    if (char.IsLetter(tecla))
                    {
                       tecla = char.ToUpper(tecla);
                       e.KeyChar = char.ToUpper(tecla);
                    }
                   if (!char.IsDigit(tecla) && !char.IsControl(tecla) && !(tecla >= 'A' && tecla <= 'F'))
            
                        e.Handled = true;   

                    break;
           
            }
        }
    }
}
