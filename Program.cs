// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int[] NumbersFromString (string stringNumbers) // Метод берёт строку с числами и "вытаскивает" из этой строки числа и добавляет в массив
// {
//     int stringSize = stringNumbers.Length;
//     int arraySize = 1;
//     for (int i = 0; i < stringSize; i++)
//     {
//         if (stringNumbers[i] == ' ') arraySize++;
//     }
//     int[] arrayNumbers = new int[arraySize];               
//     int count = 0;
//     string temp = "";
//     for (int j = 0; j < arraySize; j++)
//     {
//         while (stringNumbers[count] != ' ')
//         {
//             temp += stringNumbers[count];
//             if (count < stringSize-1) count++;
//             else break;
//         }  
//         arrayNumbers[j] = Convert.ToInt32(temp);
//         temp = "";
//         count++;
//     }
//     return arrayNumbers;
// }


// Console.WriteLine("Введите нужные числа в одну строку, с одним пробелом между числами, без пробелов в начале и конце строки:");
// string numbers = Console.ReadLine(); 
// int[] array = NumbersFromString(numbers);
// int size = array.Length;
// int count = 0;
// Console.Write("[ ");
// for (int i = 0; i < size; i++)
// {
//     Console.Write($"{array[i]} ");
//     if (array[i] > 0) count++;
// }
// Console.WriteLine("]");
// Console.WriteLine($"Колличество чисел больше нуля = {count}");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите значение b1 ");
// float b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k1 ");
// float k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b2 ");
// float b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k2 ");
// float k2 = Convert.ToInt32(Console.ReadLine());
// float x = (b2 - b1)/(k1 - k2);
// float y = k1 * x + b1;
// System.Console.WriteLine($"Точка пересечения ( {x} , {y} )");


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string DecimalToBinary (int decimalNumber)       
{
    string temp = "";
    while (decimalNumber >= 1)
    {
        temp = temp + Convert.ToString(decimalNumber % 2);
        decimalNumber = decimalNumber / 2;
    }
    int stringSize = temp.Length;
    string reverseTemp = "";
    for (int i = 0; i < stringSize; i++)
    {
        reverseTemp += temp[stringSize - i - 1];   
    }
    return reverseTemp;
}


Console.WriteLine("Введите десятичное число");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Число {number} (десятичная) = {DecimalToBinary(number)} (двоичная)");

