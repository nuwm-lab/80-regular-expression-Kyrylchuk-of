using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DateExtractor // Простір імен для організації коду
{
    /// <summary>
    /// Основна програма для виділення дат із тексту.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входу в програму.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Введіть текст, який може містити дати:");
            string userInput = Console.ReadLine(); // Зчитування введеного тексту

            // Виклик методу для виділення дат
            var dates = DateFinder.ExtractDates(userInput);

            Console.WriteLine("Знайдені дати:");
            if (dates.Count > 0)
            {
                foreach (var date in dates)
                {
                    Console.WriteLine(date); // Виведення кожної знайденої дати
                }
            }
            else
            {
                Console.WriteLine("Дати не знайдено."); // Повідомлення, якщо дати відсутні
            }
        }
    }

    /// <summary>
    /// Клас для знаходження дат у тексті.
    /// </summary>
    public static class DateFinder
    {
        /// <summary>
        /// Метод для виділення дат у форматах dd/mm/yyyy або dd-mm-yyyy.
        /// </summary>
        /// <param name="input">Вхідний текст.</param>
        /// <returns>Список знайдених дат.</returns>
        public static List<string> ExtractDates(string input)
        {
            // Регулярний вираз для дат у форматах dd/mm/yyyy та dd-mm-yyyy
            string datePattern = @"\b\d{2}[/\-]\d{2}[/\-]\d{4}\b";

            // Використання Regex для пошуку дат
            Regex regex = new Regex(datePattern);
            MatchCollection matches = regex.Matches(input);

            // Збереження знайдених дат у список
            List<string> dates = new List<string>();
            foreach (Match match in matches)
            {
                dates.Add(match.Value);
            }

            return dates; // Повернення списку знайдених дат
        }
    }
}
