// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Enter the day odf the week!");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 8 || number < 1)
{
    Console.WriteLine("You entered an invalid value!");
    return;
}
if (number > 5)
{
    Console.WriteLine("Weekend");
}
else
{
    Console.WriteLine("Working day");
}