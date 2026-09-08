using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data;

namespace RozumaticAlgorithmLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== РОЗУМАТИК // ЛАБОРАТОРНИЙ ПРАКТИКУМ №1 ==");
            Console.WriteLine("Тема: Практична робота №1 (2 год): Емпіричний аналіз часової складності алгоритмів та заміри часу виконання \n");

            Stopwatch timer = Stopwatch.StartNew();
            
            //1. Тестові вхідні дані
            int[] dataset = new int[] {42};
            Console.WriteLine($"Вхідні дані ({dataset.Length} елементів): [ " + string.Join(", ", dataset) + " ]");

            //2. Логіка алгоритму
            Array.Sort(dataset); //Алгоритмічна обробка

            timer.Stop();

            //3. Результати 
            Console.WriteLine("\nОброблений результат: [ " + string.Join(", ", dataset)+ "]");
            Console.WriteLine($"\n Точний час роботи процесора: {timer.Elapsed.TotalMilliseconds:F4} ms");
            Console.WriteLine(" Тестування завершено успішно!");

        }
    }
}