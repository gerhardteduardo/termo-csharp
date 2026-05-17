Console.WriteLine("Hello, World!");

string target = "GREMIO";

while (true)
{
    string word = Console.ReadLine() ?? "";

    if (word.Equals(target, StringComparison.CurrentCultureIgnoreCase))
    {
        break;
    }
}
