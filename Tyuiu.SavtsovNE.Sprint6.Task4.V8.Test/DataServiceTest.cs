using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavtsovNE.Sprint6.Task4.V8.Lib;

namespace Tyuiu.SavtsovNE.Sprint6.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -8.86;
            valueWaitArray[1] = -7.19;
            valueWaitArray[2] = -6.14;
            valueWaitArray[3] = -4.76;
            valueWaitArray[4] = -2.33;
            valueWaitArray[5] = 1.00;
            valueWaitArray[6] = 4.38;
            valueWaitArray[7] = 0.00;
            valueWaitArray[8] = 6.13;
            valueWaitArray[9] = 7.07;
            valueWaitArray[10] = 8.61;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}