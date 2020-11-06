using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoVigenere.Api
{
    public class CifradoVigenere
    {
        public static void Encriptar(ref StringBuilder text, string clave)
        {
            for (int i = 0; i < text.Length; i++) text[i] = char.ToUpper(text[i]);
            clave = clave.ToUpper();
            int c = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    text[i] = (char)(text[i] + clave[i] - 'A');
                    if (text[i] > 'Z') text[i] = (char)(text[i] - 'Z' + 'A' - 1);
                }
                c = c + 1 == clave.Length ? 0 : c + 1;
            }
        }
    }
}
