﻿// Программа для нахождения суммы элементов стоящих на четных позициях в массиве.
// Массив заполняется случайными двухзначными числами.
// Длина массива задается пользователем с клавиатуры
// Производится вывод созданного массива на экран

//Создать массив n - элементов
int n;
Console.Write("Введите количество элементов массива: ");
if (!int.TryParse(Console.ReadLine(), out n) || n<0)
{
Console.WriteLine("Введите верное значение длины массива ");
return;
}
int[] array = new int[n];
//заполнить массив случайными числами 
FillArray(array);
//вывод массива
PrintArr(array);
//Подсчет суммы элементов на четных позициях
int Chet = sumСhetEl(array);
Console.WriteLine($"сумма элементов четных позиций массива равна = {Chet}");
