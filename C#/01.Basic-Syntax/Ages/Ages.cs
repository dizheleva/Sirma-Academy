int age = int.Parse(Console.ReadLine());
string result = "";

switch (age)
{
    case >= 0 and < 3:
        result = "baby";
        break;
    case <= 13:
        result = "child";
        break;
    case <= 19:
        result = "teenager";
        break;
    case <= 65:
        result = "adult";
        break;
    case > 65:
        result = "elder";
        break;
}

Console.WriteLine(result);
