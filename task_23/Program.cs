// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int Promt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void Cub(int number)
{
    for(int i =1; i <= number; i++)
    {
        Console.WriteLine($"{i}-{Math.Pow(i, 3)}");
    }
}

int numcub = Promt("Введите число");
Cub(numcub);