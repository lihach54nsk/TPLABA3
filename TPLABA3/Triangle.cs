using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLABA3
{
    public class Triangle
    {
        public static int IsTriange(double[] IN)
        {
            double Max = IN.Max();
            double Min = IN.Min();
            double last = 0;

            for (int i = 0; i < 3; i++)
            {
                if ((IN[i] != Min) && (IN[i] != Max)) last = IN[i];
            }

            if ((IN[0] == IN[1]) && (IN[0] == IN[2])) return 0; // равносторонний
            else if (((IN[0] == IN[1]) && (IN[1] != IN[2])) || ((IN[0] == IN[2]) && (IN[0] != IN[1])) || ((IN[1] == IN[2]) && (IN[0] != IN[1]))) return 1; // равнобедренный
            else if (Max * Max == last * last + Min * Min) return 2; // прямоугольный
            else return 3; // разносторонний
        }
    }
}