// using System.Runtime.Serialization.Formatters;

// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 2000;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден");

// int variant = 1;

// if (variant <= 1)
// {
//     Console.WriteLine("Число не простое и не составное");
// }else
// {
//     bool isPrime = true;


//     for (int divisor = 2; divisor < variant; divisor++)
//     {
//         if (variant % divisor == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
// }

// int[] pointPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int count = 0;

// foreach (int points in pointPerLab)
// {
//     if (points < 0)
//     {
//         continue;
//     }
//     sum += points;
//     count++;
// }
// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// Console.WriteLine($"Сдано работ: {count}");

// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;
// int first = 0;
// int second = 0;

// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
//             hasDuplicates = true;
//             first = groupIds[i];
//             second = groupIds[j];
//             break;
//         }
//     }
//     if (hasDuplicates)
//     {
//         break;
//     }
// }
// Console.WriteLine(hasDuplicates ? $"Есть повторяющиеся номера {first} и {second}" : "Все номера уникальные");

// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;

// for (int day = 1; day <= days && !found; day++)
// {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
//     {
//         bool isFree = (day == 3 && lesson == 4);
//         if (isFree)
//         {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }
// if (!found)
// {
//     Console.WriteLine("Свободных слотов нет");
// }
// 
// // Задание Б

// int number = 2;

// if (number <= 1)
// {
//     Console.WriteLine("Число не является простым");
// }
// else
// {
//     bool isPrime = true;

//     for (int number1 = 2; number1 < number; number1++)
//     {
//         if (number % number1 == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
//     Console.WriteLine(isPrime ? "Число простое" : "Число составное");
// }

// // Задание В

// int[] num = { 1, 2, 3, 4, 5 };
// int sum = 0;
// foreach (int numb in num)
// {
//     if (numb % 2 != 0)
//     {
//         continue;
//     }
//     sum += numb;
// }
// Console.WriteLine($"Сумма четных чисел: {sum}");

// // Индивидуальный вариант

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// Вариант 6

using System.Runtime.Serialization.Formatters;

int[] arr = { 1, 2, 4, 3, 5 };
bool sorted = true;

for (int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i] > arr[i + 1])
    {
        sorted = false;
        break;
    }
}
Console.WriteLine(sorted ? "Отсортировано" : "Не отсортировано");

// Вариант 8
int[] a = { 1, 2, 3, 4, 5 };
int[] b = { 5, 7, 8, 9, 0 };
bool count = false;
int number = 0;

for (int i = 0; i < a.Length && !count; i++)
{
    for (int j = 0; j < b.Length; j++)
    {
        if (a[i] == b[j])
        {
            count = true;
            number = a[i];
            break;
        }
    }
}
Console.WriteLine(count ? $"Общее число: {number}" : "Нет общих чисел");