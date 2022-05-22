using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_TheDominionOfKings
{
    public class King
    {
        public string kingName;
        public int provincePoints;
        public int duchyPoints;
        public int estatePoints;
        public int kingPoints;

        public void GetKingValues()
        {
            duchyPoints = duchyPoints * 3;
            provincePoints = provincePoints * 6;
            kingPoints = provincePoints + duchyPoints + estatePoints;
        }
    }
}
