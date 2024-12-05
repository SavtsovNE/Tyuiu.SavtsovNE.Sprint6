using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SavtsovNE.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string str, string path)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                // Чтение всех строк из файла
                string[] content = File.ReadAllLines(path);

                foreach (string line in content)
                {
                    if (string.IsNullOrWhiteSpace(line)) // Пропускаем пустые строки
                        continue;

                    string[] words = line.Split(' ');
                    if (words.Length > 1)
                    {
                        result.Append(words[words.Length - 2]).Append(" ");
                    }
                    else
                    {
                        result.Append(words[0]).Append(" ");
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок чтения файла
                Console.WriteLine($"Error reading file: {ex.Message}");
                return string.Empty; // Возвращаем пустую строку в случае ошибки
            }

            return result.ToString().Trim(); // Убираем лишний пробел в конце
        }

        public string CollectTextFromFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
