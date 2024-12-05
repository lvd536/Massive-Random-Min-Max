//Условие:
//Программа, которая:

//    Создает массив из 20 случайных чисел в диапазоне от 1 до 50.
 //   Находит и выводит:
//    Сумму всех чисел в массиве.
//    Максимальное и минимальное число.
//    Среднее значение всех чисел.

Random random = new Random();
int[] massive = new int [20];
int rnditem;

Console.WriteLine("Значения массивов: ");

for (int i = 0; i < massive.Length; i++)
{ 
  rnditem = random.Next(1, 50);
  massive[i] = rnditem;
  Console.Write(massive[i] + ", ");
}

if (massive.Min() != 0)
{
    Console.WriteLine($"\n\nМинимальное значение предмета из массива: {massive.Min()}");
}

if (massive.Max() != 0)
{
    Console.WriteLine($"Минимальное значение предмета из массива: {massive.Max()}");
}