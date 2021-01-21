using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYERS;
using FACADELAYERS;

namespace BUSINESSLOGICLAYER
{
    public class BLLOGRENCI
    {
        public static int EKLE(ENTITYOGRENCI deger)
        {
            if(deger.AD!=null && deger.SOYAD!=null && deger.KULUPID!=null && deger.FOTOGRAF!=null && deger.KULUPID > 0)
            {
                return FACADEOGRENCI.EKLE(deger);
            }
            return -1;
        }

        public static bool GUNCELLE(ENTITYOGRENCI deger)
        {
            if (deger.AD != null && deger.SOYAD != null && deger.KULUPID != null && deger.FOTOGRAF != null && deger.KULUPID > 0 && deger.ID!=null)
            {
                return FACADEOGRENCI.GUNCELLE(deger);
            }
            return false;
        }

        public static bool SIL(int deger)
        {
            if(deger!=null && deger > 1)
            {
                return FACADEOGRENCI.SIL(deger);
            }
            return false;
        }

        public static List<ENTITYOGRENCI> LISTELE()
        {
            return FACADEOGRENCI.OGRENCILISTESI();
        }

    }
}
