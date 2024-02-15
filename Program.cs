string[] startArray = { "Hello", "my", "teacher", "!", ":-)" };
PrintArray(startArray);
string[] resultArray = CalculateArray(startArray);
PrintArray(resultArray);

void PrintArray(string[] arr)
{
    string str = "[" + String.Join(", ", arr) + "]";
    Console.WriteLine(str);
}