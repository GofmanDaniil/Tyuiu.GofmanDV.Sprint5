using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.GofmanDV.Sprint5.Task2.V6.Lib;

namespace Tyuiu.GofmanDV.Sprint5.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.GofmanDV.Sprint5\Tyuiu.GofmanDV.Sprint5.Task2.V6\bin\Debug\OutPutFileTask2.csv";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            bool wait = false;
            Assert.AreEqual(wait, exists);
        }
    }
}
