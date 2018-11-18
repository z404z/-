using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class FormArray
    {
        public FormArray(string s)
        {
            string entered_list = s;// принимаю строку 
            string[] entered_ar = entered_list.Split();// создали буферный массив

            int full = 0;//кол-во цифровых значений, нужно для создания массива чисел в будущем

            for (int i = 0; i < entered_ar.Length; i++)//пока не кончится буфер...
            {
                if (entered_ar[i] != "")//...считаем кол-во того, что не пробел, а если...
                {                       // ...это пробел, то пропускаем его...
                    full++;             //...
                }                       //
            }            // нашли число элементов(не пустых строк)

            int[] arrayOfNums = new int[full];// создали числовой массив длины, равной выясненному кол-ву элементов

            int countTextArr = 0;// номер элемента текстового массива
            int countNumArr = 0;// номер элемента числового массива
            // перемещаем элементы текстового массива в числовой, проверяя на пустые символы
            // для этого нам нужна длина текстового массива (entered_ar.Length) и позиция входящего в него элемента
            while (countTextArr < entered_ar.Length)  //countTextArr должен быть меньше длины исходного массива на 1
            {
                if (entered_ar[countTextArr] != "")    // проверка на пустую строку 
                {
                    arrayOfNums[countNumArr] = Convert.ToInt16(entered_ar[countTextArr]); 
                    // помещаем элемент текстового в числовой массив
                    countTextArr += 1;  // указываем, откуда помещать далее
                    countNumArr += 1;   // указываем, куда помещать далее
                }
                else countTextArr += 1;//если наткнулись на пробел, просто идем к следующему элементу текстового
            }
            // результатом всех манипуляций должен быть числовой массив arrayOfNums[]
            // как в метод класса внести поля из конструктора.
            string result = "";
            for (int i = 0; i < full; i++)
            {
                result += arrayOfNums[i].ToString() + "/";
            }
            
        }
        // результатом всех манипуляций должен быть числовой массив arrayOfNums[]
        //public void print(int[] arrayOfNums, int full)// как в метод класса внести поля из конструктора.
        //{  
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