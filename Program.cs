
/*****************************
*   Лабораторная работа №5   *
*   Выполнил: Земцев Д.Е     *
*   Дата: 19.03.2023         *
******************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Запрос директории у пользователя
        Console.Write("Введите директорию для работы программы (например, C:\\Test4Lab5): "); string directory = Console.ReadLine();
        // Если пользователь не ввел директорию, используем директорию по умолчанию
        if (string.IsNullOrEmpty(directory))
        {
            directory = @"C:\Test4Lab5";
        }

        // Получаем словарь из класса ErrorDictionary
        var dictionary = ErrorDictionary.GetDictionary();

        // Проходим по всем файлам в указанной директории
        foreach (string file in Directory.GetFiles(directory))
        {
            // Открываем файл для чтения
            using (StreamReader reader = new StreamReader(file))
            {
                // Считываем весь текст из файла
                string text = reader.ReadToEnd();

                // Исправляем ошибки в тексте
                foreach (var item in dictionary)
                {
                    foreach (string incorrectWord in item.Value)
                    {
                        text = text.Replace(incorrectWord, item.Key);
                    }
                }

                // Находим и заменяем номера телефонов в тексте
                text = Regex.Replace(text, @"\(0(\d{2})\)\s*(\d{3})-(\d{2})-(\d{2})", "+380 $1 $2 $3 $4");
                // Закрываем файл для чтения
                reader.Close();

                // Открываем файл для записи
                using (StreamWriter writer = new StreamWriter(file))
                {
                    // Записываем исправленный текст в файл
                    writer.Write(text);

                    // Закрываем файл для записи
                    writer.Close();
                }
            }

            // Выводим информацию о замене в файле
            Console.WriteLine($"Исправление в файле {file} завершено");
        }

        Console.WriteLine("Программа завершена.");
        Console.ReadLine();
    }
}