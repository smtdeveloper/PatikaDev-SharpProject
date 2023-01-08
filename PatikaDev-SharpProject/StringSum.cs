using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev_SharpProject
{
    public class StringSum
    {
        

        // val1 : 25000000000000000000000000000000000000000000
        // val2 : 90000000000000000000000000000000000000000000
        public static string Sum(string val1, string val2)
        {
            if (val1.Length > val2.Length)
                val2 = val2.PadLeft(val1.Length, '0');
            else
                val1 = val1.PadLeft(val2.Length, '0');

            var sb = new StringBuilder();
            int leapVal = 0;

            for (int i = val1.Length - 1; i >= 0; i--)
            {
                var firstVal = int.Parse(val1[i].ToString());
                var lastVal = int.Parse(val2[i].ToString());

                var total = firstVal + lastVal + leapVal;

                leapVal = total > 9 ? 1 : 0;
                total %= 10;

                sb.Insert(0, total);
            }

            if (leapVal > 0)
                sb.Insert(0, 1);

            return sb.ToString();

        }

    }
}
