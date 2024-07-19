class Decimal
{
    static int BinaryToDecimal(string binary)
    {
        int decimalValue = Convert.ToInt32(binary, 2);
        return decimalValue;
    }

    static void Main()
    {
        string binaryString = "11100"; // Change this value as needed
        int decimalResult = BinaryToDecimal(binaryString);
        Console.WriteLine($"Decimal value of {binaryString} is {decimalResult}");
    }
}