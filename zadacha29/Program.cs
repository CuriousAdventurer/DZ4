// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt (string? text)
{
System.Console.WriteLine(text);
string? StartNumber=System.Console.ReadLine();
int result=int.Parse(StartNumber);
return result;
}

int [] GeneratorA(int length, int min, int max)//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays
{
int [] array = new int [length]; //https://stackoverflow.com/questions/5746873/where-and-why-use-int-a-new-int
Random RandomNumbers = new Random();
    for(int i=0; i<length; i++)
    {
    array[i]=RandomNumbers.Next(min, max+1);
    }
return array;
}

void PrintA (int [] array)
{
System.Console.Write("(");
for (int i=0; i<array.Length-1; i++)
{
System.Console.Write($"{array[i]}, ");
}
System.Console.Write($"{array[array.Length-1]} ");
System.Console.WriteLine(")");
}

int razmer=Prompt("Длина массива: ");
int minNum=Prompt("Начальное значение: ");
int maxNum=Prompt("Конечное значение: ");
int[] array=GeneratorA(razmer, minNum, maxNum);
PrintA(array);