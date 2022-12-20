// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Enter a three-digit number (from 100 to 999): ");
int number = Convert.ToInt32(Console.ReadLine());
    if ((number > 100) && (number < 1000))
    {
string stringNumber = Convert.ToString(number);
Console.WriteLine("The second digit this number: "+stringNumber[1]);
    }
    else 
    {
      Console.WriteLine("Введено не трехзначное число");
    }

