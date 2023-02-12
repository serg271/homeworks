/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/


Console.Write("Какое количество строк нужно ввести? ");// ввод размера массива с консоли
int size = Convert.ToInt32(Console.ReadLine());

string[] ArrayStrings = new string[size];// ввод элеменов исходного массива с консоли
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-ю строку: ");
    ArrayStrings[i] = Console.ReadLine();
}

string[] arrayFinal = new string[size]; // формирование нового массива с строками длиной меньше 3
Console.Write("Массив строк длинной меньше 3 символов ->");
int len = 3;
int poz = 0;

for (int j = 0; j < size; j++)
{
    if (ArrayStrings[j].Length <= len)
    {
        arrayFinal[poz] = ArrayStrings[j];
       Console.Write(arrayFinal[poz] + " " );//поэлементный вывод массива
        poz++;
    }
}

Console.WriteLine();




