using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2_7.Classes
{
    class Hagi : Futbolcu, IOyunKurabilable,ISutCekebilable

    {
        public string CalimAt(float hiz)
        {
           return string.Format("{0} hızla çalım atıldı",hiz);
        }

        public string Oyunkur()
        {
            return "Oyun kuruldu";
        }

        public string SutCek(float hiz, float mesafe)
        {
            return string.Format("{0} hızı ile {1} mesafe ile şut çekildi", hiz, mesafe);
        }
    }
}
