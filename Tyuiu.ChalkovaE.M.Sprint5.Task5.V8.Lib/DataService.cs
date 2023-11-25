using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChalkovaE.M.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {
            double min = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double s = Double.Parse(line);
                    if (s < min && (s - (int)s) != 0)
                    {
                        min = Convert.ToDouble(line);
                    }
                }

            }
            return Math.Round(min, 3);
        }
    }
}
