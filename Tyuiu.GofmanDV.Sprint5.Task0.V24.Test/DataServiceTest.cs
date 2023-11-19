using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GofmanDV.Sprint5.Task0.V24.Lib;

namespace Tyuiu.GofmanDV.Sprint5.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string pathh = @"C:\Users\user\source\repos\Tyuiu.GofmanDV.Sprint5\Tyuiu.GofmanDV.Sprint5.Task0.V24\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(pathh);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
