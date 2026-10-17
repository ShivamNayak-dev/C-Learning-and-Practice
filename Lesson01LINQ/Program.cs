//Console.WriteLine("Hello, World!");
/*int[] marks = { 45, 90, 67, 85, 32, 95, 78 };

List<int> result = new List<int>();

foreach(int mark in marks){
    if(mark > 80){
        result.Add(mark);
    }
}

Console.Write("Marks Greater than  = ");

foreach(int res in result){
    Console.Write(res + " ");
}

*/


// with LINQ

using System.Linq;

int[] marks = { 45, 90, 67, 85, 32, 95, 78 };

var result = marks.Where(marks=>marks>=80);

Console.WriteLine("Qualified marks:");

foreach (int mark in result)
{
    Console.WriteLine(mark);
}