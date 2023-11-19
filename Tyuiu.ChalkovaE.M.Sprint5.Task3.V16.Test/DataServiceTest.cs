using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ChalkovaE.M.Sprint5.Task3.V16.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint5.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\ekaterinachalkova\source\repos\Tyuiu.ChalkovaE.M.Sprint5\Tyuiu.ChalkovaE.M.Sprint5.Task3.V16\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
