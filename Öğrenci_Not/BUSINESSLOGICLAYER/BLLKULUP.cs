using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYERS;
using FACADELAYERS;

namespace BUSINESSLOGICLAYER
{
    public class BLLKULUP
    {
        public static int EKLE(ENTITYKULUP deger)
        {
            if (deger.KULUPAD != null)
            {
                return FACADEKULUP.EKLE(deger);
            }
            else
            {
                return -1;
            }
        }

        public static bool GUNCELLE(ENTITYKULUP deger)
        {
            if(deger.KULUPAD!=null && deger.KULUPID != null)
            {
                return FACADEKULUP.GUNCELLE(deger);
            }
            else
            {
                return false;
            }
        }
        public static bool SIL(int deger)
        {
            if (deger != null)
            {
                return FACADEKULUP.SIL(deger);
            }
            return false;
        }

        public static List<ENTITYKULUP> LISTELE()
        {
            return FACADEKULUP.KULUPLISTESI();
        }

    }
}
