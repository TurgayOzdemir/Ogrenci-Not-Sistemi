using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYERS;
using FACADELAYERS;

namespace BUSINESSLOGICLAYER
{
    class BLLNOTLAR
    {
        public static bool GUNCELLE(ENTITYNOTLAR deger)
        {
            if(deger.OGRENCIID!=null && deger.OGRENCIID>0 && deger.ORTALAMA!=null && deger.ORTALAMA>=0 && deger.ORTALAMA<=100 && deger.SINAV1 != null && deger.SINAV1 >= 0 && deger.SINAV1 <= 100 && deger.SINAV2 != null && deger.SINAV2 >= 0 && deger.SINAV2 <= 100 && deger.SINAV3 != null && deger.SINAV3 >= 0 && deger.SINAV3 <= 100 && deger.PROJE != null && deger.PROJE >= 0 && deger.PROJE <= 100 && deger.DURUM != null)
            {
                return FACADENOTLAR.GUNCELLE(deger);
            }
            return false;
        }
        public static List<ENTITYNOTLAR> LISTELE()
        {
            return FACADENOTLAR.NOTLISTESI();
        }
    }
}
