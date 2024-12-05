using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.SavtsovNE.Sprint6.Task7.V1.Lib
{
    public class DataService : ISprint6Task7V1
    {
        public int[,] GetMatrix(string path)
        {

            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int coll = lines[0].Split(';').Length;


            int[,] arr = new int[rows, coll];
            for (int r = 0; r < rows; r++)
            {
                string[] linr = lines[r].Split(';');
                for (int c = 0; c < coll; c++)
                {
                    if (c == 2)
                    {
                        if (Convert.ToInt32(linr[c]) < 0)
                        {
                            arr[r, c] = 1;
                        }
                        else
                        {
                            arr[r, c] = Convert.ToInt32(linr[c]);
                        }
                    }
                    else
                    {
                        arr[r, c] = Convert.ToInt32(linr[c]);
                    }
                }
            }
            return arr;

        }
    }
}