using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fileorganizationproject
{
    static internal class Zar
    {
        static public int gelenZar;
        static public int zarAt()
        {
            Random random = new Random();
            int sayı = random.Next(1, 7);
            return sayı;
        }
    }
}
