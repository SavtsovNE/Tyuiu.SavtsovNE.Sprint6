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
            string testPath = @"C:\Users\Admin\Desktop\InPutDataFileTask6V11.txt";
            Assert.AreEqual("заглавых ", service.CollectTextFromFile("", testPath).ToLower());
        }
    }
}