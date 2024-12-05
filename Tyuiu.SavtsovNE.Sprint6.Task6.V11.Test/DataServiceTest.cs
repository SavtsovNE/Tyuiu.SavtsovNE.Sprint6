using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavtsovNE.Sprint6.Task6.V11.Lib;

namespace Tyuiu.SavtsovNE.Sprint6.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ContextTest()
        {
            DataService service = new DataService();
            string testPath = @"C:\DataSprint5\InPutDataFileTask7V12.txt";
            Assert.AreEqual("�������� ", service.CollectTextFromFile("", testPath).ToLower());
        }
    }
}