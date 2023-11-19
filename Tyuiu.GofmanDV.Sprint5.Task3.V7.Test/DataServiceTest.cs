using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.GofmanDV.Sprint5.Task3.V7.Lib;

namespace Tyuiu.GofmanDV.Sprint5.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Task3()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.GofmanDV.Sprint5\Tyuiu.GofmanDV.Sprint5.Task3.V7\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}