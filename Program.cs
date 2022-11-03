// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if ((num > 7) || (num <1))
{
    Console.WriteLine("Неверный день недели");
    return;
}
if ((num > 5))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
