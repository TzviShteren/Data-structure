using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOfData
{
    internal class Sorting
    {
        static public void BubbleSors(int[] ints)
        {
            for (int j = ints.Length - 1; j < 0; j--)
            {
                bool isDon = false;
                for (int i = 0; i < j; i++)
                {
                    if (ints[i] > ints[i + 1])
                    {
                        int tamp = ints[i];
                        ints[i] = ints[i + 1];
                        ints[i + 1] = tamp;
                        isDon = true;
                    }
                    if (!isDon)
                    {
                        break;
                    }
                }
            }
        }
    }
}
