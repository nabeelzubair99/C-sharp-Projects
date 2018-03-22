using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zubair_Bingo
{
    class InternalBoard
    {
        // the internal board class
        int[] row;
        int[] column;
        int[] diagonalright;
        int[] diagonalleft;
        //constructor
        public InternalBoard( int BINGOCARDSIZE)
        {
            row =  new int [BINGOCARDSIZE];
            column = new int[BINGOCARDSIZE] ;
            diagonalright =new int [1];
            diagonalleft = new int[1];
            row[2] = 1;
            column[2] = 1;
            diagonalright[0] = 1;
            diagonalleft[0] = 1;

        }
        // x is rows
        //y is columns
        //this method record the called numbers and everytime the number matches 
        //it adds to the counter.
         public void recordCallednumber(int x, int y)
        {
                row[x] = row[x] + 1;
            
            
                column[y] = column[y] + 1;
            
            if (x == y)
            {
                diagonalright[0] = diagonalright[0] + 1;
            }
            if(x==4 && y== 0)
            {
                diagonalleft[0] = diagonalleft[0] + 1;
            }
            else if(x==3 && y == 1)
            {
                diagonalleft[0] = diagonalleft[0] + 1;
            }
            else if (x==1 && y == 3)
            {
                diagonalleft[0] = diagonalleft[0] + 1;
            }
            else if (x==0 && y == 4)
            {
                diagonalleft[0] = diagonalleft[0] + 1;
            }
        }   

        //the is winner method returns 1 if the counter passes 5.
        public int isWinner(int x, int y)
        {
            if (row[x] == 5)
            {
                return 1;
            }
            if (column[y] == 5)
            {
                return 1;
            }
            if (diagonalleft[0] == 5)
            {
                return 1;
            }
            if(diagonalright[0]==5){
                return 1;
            }
            else
            {
                return 0;
            }
        }
        



    }
}

        
    