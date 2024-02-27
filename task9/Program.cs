


List<int> numbers=new List<int>(){1,2,3,4,5};
List<int> nums=new List<int>(){6,7,8,9};
numbers.AddRange(nums);
foreach (var item in numbers)
{
    System.Console.WriteLine(item);
}