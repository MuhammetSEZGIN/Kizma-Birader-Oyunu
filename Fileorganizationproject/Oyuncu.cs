using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fileorganizationproject
{
    public class Oyuncu
    {
        public int sıra;
        public int gelenZar;
        public string ısım;
        public bool[] piyon_ev = new bool[4] {true,true,true,true};
        public bool oyundaMı = true;
        public int[] piyon_kordinatları = new int[4];
        public string[] piyonIsimleri=new string[4];
        //52 tane ortak yol var
        // 4 tane yuva 
        // 5 tane de hedefyol
        //

    }
}
// 1 piyonu aldık 
// zar at 6 gelirse çık gelmezse diğer oyuncuya sıra gelsin
// linkedlist oluştur 