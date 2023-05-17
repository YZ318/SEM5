const int ARRAY_SIZE = 10; // Размер массива
int[] arr = new int[ARRAY_SIZE]; // Создаём массив

Random rnd = new Random(); // Создаём генератор случайных чисел

// Заполняем массив случайными трёхзначными числами
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);
}

int evenCount = 0; // Счётчик чётных чисел

// Проходим по массиву и проверяем каждый элемент на чётность
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0) // Если число чётное
    {
        evenCount++; // Увеличиваем счётчик
    }
}
// Выводим количество чётных чисел
Console.WriteLine($"Количество чётных чисел: {evenCount}");