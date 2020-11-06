using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoVigenere.Api
{
    public class Desencriptar
    {
        
            public void desencriptar(ref StringBuilder s, string key)
            {
                for (int i = 0; i < s.Length; i++)
                    s[i] = char.ToUpper(s[1]);
                key = key.ToUpper();
                int j = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsLetter(s[i]))
                    {
                        s[i] = s[i] >= key[j] ?
                            (char)(s[i] - key[j] + 'A') :
                            (char)('A' + ('Z' + key[j] - 'A') + 1);
                    }
                    j = j + 1 == key.Length ? 0 : j + 1;
                }
            }
        }
    }

