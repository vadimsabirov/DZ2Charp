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
/*
int ThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
return result; 
}

Console.Write("Input three-digit number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
 
if (ThirdDigit(number1) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"Third digit is {ThirdDigit(number1)}");
*/
//Напишите программу, 
//которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
/*
Console.WriteLine ("Введите день недели...");
int dayofweek = Convert.ToInt32(Console.ReadLine());
if (dayofweek == 6 || dayofweek == 7) 
Console.WriteLine ("Ответ: Выходной день.");
else if (dayofweek <= 5) 
Console.WriteLine ("Ответ: Будний день.");
else if (dayofweek > 7) 
Console.WriteLine ("Ошибка: В неделе всего 7 дней!");
*/