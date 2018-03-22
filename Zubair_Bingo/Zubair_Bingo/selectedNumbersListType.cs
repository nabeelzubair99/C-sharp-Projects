using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zubair_Bingo
{
    class selectedNumbersListType
    {
        int[] calledNumbers;

        public selectedNumbersListType()
        {
            calledNumbers = new int[76];
        }

        //resets the array once all the numbers have been called

        public void reset()
        {for(int i = 0; i < 76; i++)
            {
                calledNumbers[i] = 0;
            }

        }
        public bool isNumberUsed(int x)
        {
            if (calledNumbers[x] == x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void setUsedNumber(int n)
        {
            calledNumbers[n] = n; 
        }

    }
}