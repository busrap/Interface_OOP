using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2_7
{
    class Futbolcu
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public float Boy { get; set; }
        public float Kilo { get; set; }
        public int FormaNo { get; set; }
        public string Takimi { get; set; }

        public int Yas { get
            {
               
              int  yas =(int) (this.DogumTarihi - DateTime.Now).TotalDays / 365;
                return yas;
            }
                }
    }
}
