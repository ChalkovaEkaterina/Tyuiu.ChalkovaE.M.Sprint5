using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ChalkovaE.M.Sprint5.Task0.V15.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint5.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\ekaterinachalkova\source\repos\Tyuiu.ChalkovaE.M.Sprint5\Tyuiu.ChalkovaE.M.Sprint5.Task0.V15\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
