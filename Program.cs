using System;

namespace TextProcessor // Додана назва простору імен для організації коду
{
    /// <summary>
    /// Основна програма для роботи з текстом.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входу в програму.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Введіть текст:"); // Запит тексту у користувача
            string userInput = Console.ReadLine(); // Зчитування введеного тексту

            // Виклик методу для додавання "ОК" після кожної літери "о"
            string processedText = TextModifier.AddOkAfterO(userInput);

            Console.WriteLine("Результат:");
            Console.WriteLine(processedText); // Виведення результату
        }
    }

    /// <summary>
    /// Клас для модифікації тексту.
    /// </summary>
    public static class TextModifier
    {
        /// <summary>
        /// Метод для додавання "ОК" після кожної літери "о" (незалежно від регістру).
        /// </summary>
        /// <param name="input">Вхідний текст.</param>
        /// <returns>Модифікований текст.</returns>
        public static string AddOkAfterO(string input)
        {
            // Використання регулярного виразу для пошуку букв "о" (українська "о" або латинська "o")
            Regex letterORegex = new Regex("[оo]", RegexOptions.IgnoreCase);

            // Пошук усіх збігів у тексті
            MatchCollection matches = letterORegex.Matches(input);

            // Зсув для коректного вставлення додаткового тексту
            int offset = 0;

            // Проходження по всіх знайдених збігах
            foreach (Match match in matches)
            {
                int currentIndex = match.Index + offset; // Актуальний індекс у тексті
                input = input.Substring(0, currentIndex) + match.Value + "ОК" + input.Substring(currentIndex + match.Length);
                offset += 2; // Зсув збільшується на довжину доданого тексту ("ОК" має 2 символи)
            }

            return input; // Повернення модифікованого тексту
        }
namespace LabWork
{
    // Даний проект є шаблоном для виконання лабораторних робіт
    // з курсу "Об'єктно-орієнтоване програмування та патерни проектування"
    // Необхідно змінювати і дописувати код лише в цьому проекті
    // Відео-інструкції щодо роботи з github можна переглянути 
    // за посиланням https://www.youtube.com/@ViktorZhukovskyy/videos 
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
    }
}
