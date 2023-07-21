// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt (string text)
{
System.Console.WriteLine(text);
string? StartNumber=System.Console.ReadLine();
int result=int.Parse(StartNumber);
return result;
}
int Power(int counter, int exponent)
{
    int power = 1;
    for (int i=0; 1<exponent; i++)
    {
    power*=counter;
    }
    return power;
}

bool Proverka (int exponent)
{
if (exponent<0)
    {
    System.Console.WriteLine("Натуральные числа >0");
    return false;
    }
return true;
}
int counter=Prompt("Введите число:");
int exponent=Prompt("Введите степень:");
if (Proverka(exponent))
{
System.Console.WriteLine($"Число {counter} в степени {exponent} = {Power (counter, exponent)}");
}

//Console.WriteLine("Натуральная степень введенных чисел: " + exponentiation);