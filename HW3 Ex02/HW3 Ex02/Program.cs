Console.Write("Please Enter Your Number: ");
string input = Console.ReadLine();

string[] inputNumbers = input.Split(',');
int[] numbers = new int[inputNumbers.Length];
for (int i = 0; i < inputNumbers.Length; i++)
{
    numbers[i] = int.Parse(inputNumbers[i]);
}
Array.Sort(numbers);
int count = 1;
string result = "";
for (int i = 1; i <= numbers.Length; i++)
{
    if (i < numbers.Length && numbers[i] == numbers[i - 1])
    {
        count++;
    }
    else
    {
        if (count > 1)
        {
            result += $"{numbers[i - 1]}^{count}";
        }
        else
        {
            result += $"{numbers[i - 1]}";
        }
        if (i < numbers.Length)
        {
            result += "*";
        }
        count = 1;
    }
}
Console.WriteLine(result);
