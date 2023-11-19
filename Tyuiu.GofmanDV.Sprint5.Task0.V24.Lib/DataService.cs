using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GofmanDV.Sprint5.Task0.V24.Lib
{
    public class DataService : ISprint5Task0V24

    {
        public string SaveToFileTextData(int x)
        {
            string pathh = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double y = ( Math.Pow(x, 3) - 8) / 2 * Math.Pow(x, 2);

            y = Math.Round(y, 3);

            File.WriteAllText(pathh, y.ToString());
            return pathh;
        }
    }
}
