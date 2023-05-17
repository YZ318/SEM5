int[] array = new int[10];
Random random = new Random();

// заполнение массива случайными числами
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 10);
}

// вывод массива на экран
Console.WriteLine("Массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write("{0} ", array[i]);
}

// вычисление суммы элементов на нечётных позициях
int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}

Console.WriteLine("\nСумма элементов на нечётных позициях равна {0}", sum);