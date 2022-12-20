// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Enter any three-digit number (from 100 to 999): ");
 int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
 string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("The second digit this number: "+stringNumber[1]);



