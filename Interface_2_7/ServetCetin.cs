using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2_7.Classes
{
    class ServetCetin : Futbolcu, ISavunaBilable
    {
        public string SavunmaYap()
        {
            return "Servet Çetin'den muhteşem savunma";
        }

       
    }
}
