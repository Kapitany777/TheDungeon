using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Names
{
    public class PlayerName : INameGenerator
    {
        private readonly List<string> Syllables = new List<string>
        { "sen", "mat", "gem", "ha", "lod", "kim", "nek", "ler", "hod", "mak", "lis", "par", "tiz",
          "mok", "laf", "rak", "var", "ver", "vir", "vor", "mek", "nes", "mog", "tok", "fej", "suk",
          "sum", "lok", "bar", "ter", "mo", "le", "ti", "va", "ve", "li", "sa", "de", "ro", "li",
          "sa", "ko", "pi", "fa", "jil", "jak", "lok", "pi", "gu", "ra", "bon", "meg", "jel", "jak",
          "pus", "pal", "kar", "kat", "ruk", "jer", "mik", "kil", "pas", "der", "tug", "tek", "hes",
          "mes", "rag", "fat", "pos", "lag", "tad", "nel", "nek", "nik" };

        private readonly Random rnd;

        public PlayerName()
        {
            rnd = new Random();
        }

        public string NextName()
        {
            StringBuilder sb = new StringBuilder();

            string s = Syllables[rnd.Next(Syllables.Count)];
            
            sb.Append(s[0].ToString().ToUpper());
            sb.Append(s.Substring(1));

            for (int i = 0; i < rnd.Next(3) + 1; i++)
            {
                sb.Append(Syllables[rnd.Next(Syllables.Count)]);
            }

            return sb.ToString();
        }
    }
}
