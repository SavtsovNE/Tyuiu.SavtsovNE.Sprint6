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
           
            
                var dataService = new DataService();
                string result = dataService.CollectTextFromFile("/app/data/AssesmentData/C#/Sprint6Task6/InPutDataFileTask6V11.txt", "somePath");
                Assert.AreEqual("btwMCZUcB PADUsjhlu JmjQKHd TMRyztkPxzEVkcarVMlQ EUWCvEgL", result);
            

        }
    }
}