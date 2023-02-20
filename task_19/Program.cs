// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


using System;

string Promt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

bool CheckPol(string PolCand)
{
    int len = PolCand.Length - 1;
    int index = 0;   

    while(index < len/2)
    {
        if(PolCand [index] != PolCand [len - index])
        {
            return false;
        }

        index++;
    }
    
    return true;
}

void AutorIdent()//проба пера по 3 лекции
{
    Console.WriteLine("Если этот автомобиль мешает вам, звоните на номер ...");
}

string number = Promt("Введите число ");
bool RealPol = CheckPol(number);

if(RealPol)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");  
}

AutorIdent();