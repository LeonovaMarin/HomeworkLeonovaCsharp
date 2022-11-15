Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number2 > max)
{
    Console.WriteLine("Число 2 является максимальным");

}
else 
{
    Console.WriteLine("Число 1 является максимальным");
}