﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChalkovaE.M.Sprint5.Task4.V23.Lib
{
    public class DataService : ISprint5Task4V23
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round(Math.Pow(Convert.ToDouble(strX), -3) + 2 + Math.Cos(Convert.ToDouble(strX)), 3);
            return res;
        }
    }
}
