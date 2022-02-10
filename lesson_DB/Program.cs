using System.Threading;
using System.Linq;

menu();
string menu()
{
    Console.WriteLine("Примеры Linq:");
    Console.WriteLine("0. Выход из программы");
    Console.WriteLine("1. Пример массива");
    Console.WriteLine("2. Пример метода расширения");
    Console.WriteLine("3. Пример метода расширения Count()");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 4)
    {
        Console.WriteLine("Такого пункта меню нет((");
        Console.WriteLine("Enter...");
        Console.ReadKey();
        Console.Clear();
    }
    else if (x == 1)
    {
        mass();
        Console.Clear();
    }
    else if (x == 2)
    {
        metod();
        Console.Clear();
    }
    else if (x == 3)
    {
        metod2();
        Console.Clear();
    }
    else if (x == 0)
    {
        Environment.Exit(0);
    }

    return menu();
}

void mass()
{
    string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

    var selectedTeams = from t in teams // определяем каждый объект из teams как t
                        where t.ToUpper().StartsWith("Б") //фильтрация по критерию
                        orderby t  // упорядочиваем по возрастанию
                        select t; // выбираем объект

    foreach (string s in selectedTeams)
        Console.WriteLine(s);
    Console.WriteLine("");
    Console.WriteLine("Сам код:");
    Console.WriteLine("");
    Console.WriteLine("string[] teams = { Бавария, Боруссия, Реал Мадрид, Манчестер Сити, ПСЖ, Барселона };");
    Console.WriteLine("");
    Console.WriteLine("var selectedTeams = from t in teams // определяем каждый объект из teams как t");
    Console.WriteLine("where t.ToUpper().StartsWith(Б) //фильтрация по критерию");
    Console.WriteLine("orderby t  // упорядочиваем по возрастанию");
    Console.WriteLine("select t; // выбираем объект");
    Console.WriteLine("");
    Console.WriteLine("foreach (string s in selectedTeams)");
    Console.WriteLine("Console.WriteLine(s); ");

    Console.ReadKey();
}

void metod()
{
    string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

    var selectedTeams = teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t);

    foreach (string s in selectedTeams)
        Console.WriteLine(s);

    Console.WriteLine("");
    Console.WriteLine("Сам код:");
    Console.WriteLine("");
    Console.WriteLine("string[] teams = { Бавария, Боруссия, Реал Мадрид, Манчестер Сити, ПСЖ, Барселона };");
    Console.WriteLine("var selectedTeams = teams.Where(t => t.ToUpper().StartsWith(Б)).OrderBy(t => t);");
    Console.WriteLine("foreach (string s in selectedTeams)");
    Console.WriteLine("Console.WriteLine(s);");

    Console.ReadKey();
}

void metod2()
{
    string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

    int number = (from t in teams where t.ToUpper().StartsWith("Б") select t).Count();
    Console.WriteLine("Сам код:");
    Console.WriteLine("");
    Console.WriteLine("string[] teams = { Бавария, Боруссия, Реал Мадрид, Манчестер Сити, ПСЖ, Барселона };");
    Console.WriteLine("int number = (from t in teams where t.ToUpper().StartsWith(Б) select t).Count();");

    Console.ReadKey();
}