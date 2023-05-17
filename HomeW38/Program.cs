double[] array = new double[] { 1.2, 3.4, 5.6, 7.8, 9.0 };

// вывод массива на экран
Console.WriteLine("Массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write("{0} ", array[i]);
}

// нахождение минимального элемента
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}

// нахождение максимального элемента
double max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}

// нахождение разницы
double difference = max - min;

Console.WriteLine("\nРазница между максимальным и минимальным элементом равна {0}", difference);