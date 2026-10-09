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

int[] pointPerLab = { 8, -1, 10, 9, -1, 7 };
int sum = 0;
int count = 0;

foreach (int points in pointPerLab)
{
    if (points < 0)
    {
        continue;
    }
    sum += points;
    count++;
}
Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
Console.WriteLine($"Сдано работ: {count}");

int[] groupIds = { 101, 104, 107, 104, 110 };
bool hasDuplicates = false;
int first = 0;
int second = 0;

for (int i = 0; i < groupIds.Length; i++)
{
    for (int j = i + 1; j < groupIds.Length; j++)
    {
        if (groupIds[i] == groupIds[j])
        {
            hasDuplicates = true;
            first = groupIds[i];
            second = groupIds[j];
            break;
        }
    }
    if (hasDuplicates)
    {
        break;
    }
}
Console.WriteLine(hasDuplicates ? $"Есть повторяющиеся номера {first} и {second}" : "Все номера уникальные");