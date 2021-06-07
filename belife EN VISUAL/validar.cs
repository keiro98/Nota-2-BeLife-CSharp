using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace metrowpf
{
    class validar
    {
        public static void Solonumeros(TextCompositionEventArgs e)
        {
            int result;

            if (!(int.TryParse(e.Text, out result) || e.Text == "."))
            {
                e.Handled = true;
            }
        }

        public static void Sololetras(TextCompositionEventArgs v)
        {
            int character = Convert.ToInt32(Convert.ToChar(v.Text));
            if ((character >= 65 && character <= 90) || (character >= 97 && character <= 122))
                v.Handled = false;
            else
                v.Handled = true;

        }

        
    }
        }
    



