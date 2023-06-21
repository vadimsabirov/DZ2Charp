// 1.Задача. Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Enter your number: " );
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (secondNumber > 99 && secondNumber < 1000 || secondNumber < -99 && secondNumber > -1000)  
{
    int digit_2 = ((secondNumber / 10) % 10);
    Console.WriteLine("The second digit is " + digit_2);
}
else
{
    Console.Write("ERROR!");    
}
*/
// 2.Задача. Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

int FindthirdDigit(int num)
{
    int result;
    if(num > 99 && num < 1000 || num < -99 && num > -1000)
    int ed = num % 10
    result = ed;
}
Console.WriteLine("Input a two-digit num: ");
int num = Convert.ToInt32(Console.ReadLine());

int thirdDigit = FindthirdDigit(num);
Console.WriteLine($"third Digit of {num} is {thirddigit}");