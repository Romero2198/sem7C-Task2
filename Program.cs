int[,] numbers = new int[5, 5];
FillArray(numbers);
PrintArray(numbers);
int a = InputInt("Введите строку нужного числа: ");
int b = InputInt("Введите столбец нужного числа: ");
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (i == a && j == b)
        {
            Console.WriteLine(numbers[i, j]);
        }
    }
}
if(a > 4 || a < 0 || b > 4 || b < 0)
{
    Console.WriteLine("Такого элемента нет в массиве");
}


int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}