Console.Write("Enter Your Number: ");
string binaryInput = Console.ReadLine();

bool validBinary = true;
foreach (char c  in binaryInput)
{
    if (c != '0' && c != '1')
    {
        validBinary = false;
        break;
    }
}
if (validBinary)
{
    int decimalResult = Convert.ToInt32(binaryInput, 2);
    Console.WriteLine($"decimal : {decimalResult}");
}
else
{
    Console.WriteLine("invalid input");
}