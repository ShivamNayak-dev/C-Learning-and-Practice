Console.WriteLine("Hello, World!");



var n = 10000000;

for(int i=0; i<=n; i++){

   Console.WriteLine(i);
}

List<int> marks = new List<int> { 75, 82, 91, 68 };

foreach (int mark in marks)
{
    Console.WriteLine(mark);
}


for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 2; j++)
    {
        Console.WriteLine($"i = {i}, j = {j}");
    }
}

string[] fruits = { "Apple", "Banana", "Mango" };

for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine($"{i}: {fruits[i]}");
}


for (int row = 1; row <= 3; row++)
{
    for (int col = 1; col <= 5; col++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}


for (int row = 1; row <= 3; row++)
{
    for (int col = 1; col <= 4; col++)
    {
        Console.Write(col + " ");
    }

    Console.WriteLine();
}


for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.Write($"{i * j,4}");
    }

    Console.WriteLine();
}

int[] numbers = { 10, 20, 30, 40, 50 };
int target = 30;
bool found = false;

foreach (int number in numbers)
{
    if (number == target)
    {
        found = true;
        break;
    }
}

Console.WriteLine(found ? "Found" : "Not found");


for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        if (j == 2)
        {
            break;
        }

        Console.WriteLine($"i={i}, j={j}");
    }
}

int[] marks = { 70, 80, 90, 60 };
int sum = 0;

foreach (int mark in marks)
{
    sum += mark;
}

double average = (double)sum / marks.Length;

Console.WriteLine($"Total: {sum}");
Console.WriteLine($"Average: {average:F2}");