
Console.Write("Bitte geben Sie ein Datum ein: ");

string date = Console.ReadLine() ?? String.Empty;

string[] dateStringArr = date.Split(".");





int day, month, year;
Int32.TryParse(dateStringArr[0], out day);
Int32.TryParse(dateStringArr[1], out month);
Int32.TryParse(dateStringArr[2], out year);

bool isLeapYear = ((year % 4 == 0 && year % 100 != 0) || (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)) ? true : false;




if (month < 1 || month > 12)
{
    ThrowErr("month");
}

if (day < 1)
{
    ThrowErr("day");
}

if (day > 31)
{
    ThrowErr("day");
}

if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
{
    ThrowErr("day");
}

if (month == 2 && isLeapYear && day > 29)
{
    ThrowErr("day");
}

if (month == 2 && !isLeapYear && day > 28)
{
    ThrowErr("day");
}

Console.WriteLine(day + "." + month + "." + year + " ist ein korrektes Datum!");
Console.ReadLine();

static void ThrowErr(string type)
{
    Console.WriteLine("Der " + type + " ist nicht korrekt!");
    Environment.Exit(1);
}
