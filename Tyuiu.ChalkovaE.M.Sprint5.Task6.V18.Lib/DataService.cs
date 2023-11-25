using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChalkovaE.M.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string num = "0123456789";
            using (StreamReader reader = new StreamReader(path))
            {
                
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    string[] tutu = line.Split(' ');
                    
                    foreach (string value in tutu)
                    {
                        if ((value.All(char.IsDigit)) && value.Length == 1)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
