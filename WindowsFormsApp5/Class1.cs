using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class ClassQueue
    {
        string result;
        Queue<int> qu;
        int count;
        int[] a;

        public ClassQueue()
        {
            qu = new Queue<int>();  
            
        }

        public void MakeArr()
        {
            string[] sNum = result.Split();
            int ful = 0;
            // подсчёт чисел в набранной строке
            for (int i = 0; i < sNum.Length; i++)
                if (sNum[i] != "")
                    ful++;

            int dim = ful;
            a = new int[ful];

            //заполнение массива arr
            int indxArr = 0;
            for (int i = 0; i < sNum.Length; i++)
                if (sNum[i] != "")
                    a[indxArr++] = Convert.ToInt16(sNum[i]);
        } //MakeArr

        public  FormQueue()
        {
            count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)//n<0
                {
                    if()//очередь пуста
                    {


                    }
                    else//очередь не пуста
                    {


                    }
                }
                else // n>0[]
                {
                    if ()//счетчик равен нулю
                    {


                    }
                    else//счетчик не равен нулю
                    {


                    }
                }         
            }
        }
    }
}
