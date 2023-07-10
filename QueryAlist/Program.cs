
var random = new Random();
var range = Enumerable.Range(0, 1000).Select(number=>random.Next(0,2000)).ToList();

printAll(GetEvenNumbers(range));
void printAll(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        Console.WriteLine(number + " ");
    }
    Console.WriteLine();
}
foreach (var item in range)
{
    Console.WriteLine(item);
}
 IEnumerable<int>GetEvenNumbers(IEnumerable<int> numbers)
{
    var evenNumbers = new List<int>();
    foreach (var number in numbers)
    {
        if (number % 2==0)
        {
            evenNumbers.Add(number);

        }
    }
    return evenNumbers;
}