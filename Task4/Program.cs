// Задача: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Random rand = new Random();
int[] array = new int[8];

for (int i = 0; i <= 7; i++)
{
    array[i] = rand.Next(0, 2);
}

foreach (var i in array)
{
    Console.Write(i + " ");
}