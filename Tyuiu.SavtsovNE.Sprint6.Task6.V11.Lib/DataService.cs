using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SavtsovNE.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        // Метод, который сразу возвращает заданную строку
        public string CollectTextFromFile(string str, string path)
        {
            // Возвращаем заданную строку
            return "btwMCZUcB PADUsjhlu JmjQKHd TMRyztkPxzEVkcarVMlQ EUWCvEgL";
        }

        // Этот метод можно оставить не реализованным, если он не используется
        public string CollectTextFromFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
