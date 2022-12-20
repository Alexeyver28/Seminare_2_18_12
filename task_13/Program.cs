// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Enter any number");
string number = Console.ReadLine();
if(number.Length < 3)
{
    Console.WriteLine("No third digit!");
    return;
}
Console.WriteLine(number[2]);
