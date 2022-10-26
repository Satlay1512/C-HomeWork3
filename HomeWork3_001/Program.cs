// Задача 1
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. Без использования строк

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
 
bool ValidateNunber(int number)
{
    if(number < 10000 || number >= 100000)
    {
        System.Console.WriteLine("Это число не пятизначное");
        return false;
        }
        return true;
}
int number = Prompt("Введите пятизначное число: ");
if (ValidateNunber(number));
int FifthDigit = (number / 10000) % 10;
int FourthDigit = (number / 1000) % 10;
int ThirdDigit = (number / 100) % 10;
int SecondDigit = (number / 10) % 10;
int FirstDigit =  number % 10;

if (FifthDigit == FirstDigit && FourthDigit == SecondDigit)
{
System.Console.WriteLine($"{number} ==> является палиндромом");
}
else
{
    System.Console.WriteLine($"{number} ==> не является палиндромом"); 
}
