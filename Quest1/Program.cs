﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.Write(message);
    int result = int. Parse(Console.ReadLine()!);
    return result;
}

int[] InputArray(int size)
{
    int[] array = new int[size];
    for(int i=0; i<array.Length; i++)
    {
        array[i] = Prompt($"Введите {i+1}-й элемент: ");
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.WriteLine(($"Число[{i}] = {array[i]}"));
    }
}

int SearchNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int size = Prompt("Введите количество элементов массива: ");
int [] array = InputArray(size);
PrintArray(array);
Console.WriteLine($"Кол-во чисел больше 0 = {SearchNumber(array)}");
