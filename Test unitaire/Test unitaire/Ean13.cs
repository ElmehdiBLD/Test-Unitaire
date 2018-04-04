using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_unitaire
{
    class Ean13
    {
        private int[] ean13;
        
        public Ean13(int[] ean13)
        {
            this.ean13 = new int[12];
            int k = 0;
            foreach (int i in ean13)
            {
                this.ean13[k] = i;
                k++;
            }
        }
        public int poidspair()
        {
            int cumul = 1;
            for (int i = 0; i < 12; i = i + 2)
            {
                cumul = cumul + this.ean13[i];
            }
            return cumul;
        }
        public int poidsimpair()
        {
            int cumul = 0;
            for (int i = 0; i < 12; i = i + 2)
            {
                cumul = cumul + this.ean13[i];
            }
            return cumul;
        }
        public int reste()
        {
            return 0;
        }
        public int cle()
        {
            return 0;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
