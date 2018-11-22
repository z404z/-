using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class FormArray
    {
        string result;
        int[] arrayOfNums;// могу ли я такое же поле создать для массива, который будет нужен в другом скрипте?
        // как к нему обратиться из другого класса?
        public FormArray(string s)
        {
            result = s;    
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
            arrayOfNums = new int[ful];

            //заполнение массива arr
            int indxArr = 0;
            for (int i = 0; i < sNum.Length; i++)
                if (sNum[i] != "")
                    arrayOfNums[indxArr++] = Convert.ToInt16(sNum[i]);
        } //MakeArr
        //public string print()
        //{
        //    string res = "";
        //    MakeArr();

        //    for (int i = 0; i < arrayOfNums.Length; i++)
        //        res += Convert.ToString(arrayOfNums[i]) + " ";
        //    return res;
        //}
    }
}       
        // установили размер численного массива, равный числу реальных элементов
                                      //второй массив теперь состоит только из чисел
                                             // цикл формирует массив arrayOfNums[count_second_array] 
                                             // организуем вывод

            //for (int i = 0; i < entered_ar.Length; i++)
            //{
            //    if (entered_ar[i] != "")                             //считывание только численных значений, если...
            //    {                                                     // ...это пробел, то пропускает его
            //        array[i] = Convert.ToInt16(entered_ar[i]);                                           //
            //    }
            //}