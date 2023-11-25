using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChalkovaE.M.Sprint5.Task7.V11.Lib
{
    public class DataService : ISprint5Task7V11
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V11.txt";

            FileInfo fileinfo = new FileInfo(pathSaveFile);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            List<string> alph = new List<string>();
            for (char sim = 'а'; sim <= 'я'; sim++)
            {
                alph.Add("" + sim);
            }
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string res = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!alph.Contains("" + line[i]))
                        {
                            res += line[i];
                        }
                    }

                    File.AppendAllText(pathSaveFile, res + Environment.NewLine);
                    
                }

            }
            return pathSaveFile;
        }
      
    }
}
