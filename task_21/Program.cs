// 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int Promt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double Calc(int x1, int x2, int y1, int y2, int z1, int z2)
{
    int x = x1 - x2;
    int y = y1 - y2;
    int z = z1 - z2;
    double k = Math.Pow(x, 2)+ Math.Pow(y, 2)+ Math.Pow(z, 2);
    double v = Math.Sqrt(k);
    return Math.Round(v, 2);
}

int x1 = Promt("Введите координату х1 для точки X");
int y1 = Promt("Введите координату y1 для точки X");
int z1 = Promt("Введите координату z1 для точки X");
int x2 = Promt("Введите координату х2 для точки Y");
int y2 = Promt("Введите координату y2 для точки Y");
int z2 = Promt("Введите координату z2 для точки Y");

double result = Calc(x1, x2, y1, y2, z1, z2);
Console.WriteLine(result);