using System;
/// <summary>
/// Класс, демонстрирующий работу с массивами символов и целых чисел, а также передачу данных в метод.
/// </summary>
class ArrayExample
{
    /// <summary>
    /// Точка входа в приложение: формирует строку из символов массива, заполняет числовой массив и выводит приветствия.
    /// </summary>
    static void Main()
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";
        int[] a = new int[10];
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }
    /// <summary>
    /// Выводит в консоль персонализированное приветствие с указанием имени и числа для счёта.
    /// </summary>
    /// <param name="name">Строка с именем, которое подставляется в приветствие.</param>
    /// <param name="msg">Целое число, указывающее верхнюю границу счёта в сообщении.</param>
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}