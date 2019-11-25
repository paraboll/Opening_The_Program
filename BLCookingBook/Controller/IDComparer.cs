using BLCookingBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCookingBook.Controller
{
    public class IDComparer : IComparer<Ingredient>
    {
        public int Compare(Ingredient o1, Ingredient o2)
        {
            int a = Convert.ToInt32(o1.Id);
            int b = Convert.ToInt32(o2.Id);

            if (a > b)
            {
                return 1;
            }
            else if (a < b)
            {
                return -1;
            }

            return 0;
        }
    }
}
