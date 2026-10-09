int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
int target = 2000;
bool found = false;

foreach (int number in recordBooks)
{
    if (number == target)
    {
        found = true;
        break;
    }
}
Console.WriteLine(found ? "Студент найден" : "Студент не найден");

int variant = 1;

if (variant <= 1)
{
    Console.WriteLine("Число не простое и не составное");
}else
{
    bool isPrime = true;


    for (int divisor = 2; divisor < variant; divisor++)
    {
        if (variant % divisor == 0)
        {
            isPrime = false;
            break;
        }
    }
Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
}
