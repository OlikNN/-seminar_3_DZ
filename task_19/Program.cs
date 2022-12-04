// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
char[] array = number.ToCharArray();
 int j = 4;
string message = "Да";

if (array.Length == 5)
{

    for (int i = 0; i < 2; i++)
    {

        if(array[i] != array[j]){
         
        message = "Нет";   
            
        };
        // Console.WriteLine(i);
        // Console.WriteLine(j);
        j--;
    }
    Console.WriteLine(message);
}
else
{
    Console.WriteLine("Введите пятизначное число");
}