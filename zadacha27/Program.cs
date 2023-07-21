// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt (string? text)
{
System.Console.WriteLine(text);
string? StartNumber=System.Console.ReadLine();
int result=int.Parse(StartNumber);
return result;
}

int SumAll(int Number)
{
int result=0;
    while (Number>0)
    {
    result+=Number%10;
    Number=Number/10;
    }
return result;
}

int Number=Prompt("Введите число: ");
System.Console.WriteLine($"Сумма всех цифр в числе = {SumAll(Number)}");
