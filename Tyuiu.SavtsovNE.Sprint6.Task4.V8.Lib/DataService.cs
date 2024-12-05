using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.SavtsovNE.Sprint6.Task4.V8.Lib
{
    public class DataService : ISprint6Task4V8
    {

        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; // объявляется пустой массив 
            int len = (stopValue - startValue) + 1; //вычисляем длинну массива
            valueArray = new double[len];//создаем массив с указанной длинной 
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((2 - x) == 0)
                {
                    y = 0;
                    valueArray[count] = y;
                    count++;
                }
                else
                {
                    y = Math.Round((Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x)) + (2 * x)), 2);// округлили до 2 знаков
                    valueArray[count] = y;// присваиваем значение в массив с индексом count 
                    count++;



                }
            }
            return valueArray;
        }
    }
}