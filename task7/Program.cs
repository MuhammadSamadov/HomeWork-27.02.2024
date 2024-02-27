

List<int> numbers= new List<int>(){1,2,3,4,5,6,7,8,9};
numbers.RemoveAt(4);
foreach (var item in numbers)
{
    System.Console.WriteLine(item);
}