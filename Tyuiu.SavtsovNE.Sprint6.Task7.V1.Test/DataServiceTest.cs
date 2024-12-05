using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavtsovNE.Sprint6.Task7.V1.Lib;

namespace Tyuiu.SavtsovNE.Sprint6.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\alex3\Desktop\1.txt";
            int[,] wait = new int[2, 2] { { 1, 0 },
                                          { 0, 1 } };
            int[,] res = ds.GetMatrix(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}