// See https://aka.ms/new-console-template for more information
var King1 = new Chapter_7_TheDominionOfKings.King();
var King2 = new Chapter_7_TheDominionOfKings.King();
var King3 = new Chapter_7_TheDominionOfKings.King();

Console.WriteLine("What is the name of the 1st King? ");
King1.kingName =  Console.ReadLine();
Console.WriteLine("How many provinces does {0} hold? ", King1.kingName);
King1.provincePoints = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("How many duchies does {0} hold? ", King1.kingName);
King1.duchyPoints = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("How many estates does {0} hold? ", King1.kingName);
King1.estatePoints = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("\nWhat is the name of the 2nd King? ");
King2.kingName = Console.ReadLine();
Console.WriteLine("How many provinces does {0} hold? ", King2.kingName);
King2.provincePoints = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("How many duchies does {0} hold? ", King2.kingName);
King2.duchyPoints = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("How many estates does {0} hold? ", King2.kingName);
King2.estatePoints = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("\nWhat is the name of the 3rd King? ");
King3.kingName = Console.ReadLine();
Console.WriteLine("How many provinces does {0} hold? ", King3.kingName);
King3.provincePoints = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("How many duchies does {0} hold? ", King3.kingName);
King3.duchyPoints = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("How many estates does {0} hold? ", King3.kingName);
King3.estatePoints = Convert.ToInt16(Console.ReadLine());

King1.GetKingValues();
King2.GetKingValues();
King3.GetKingValues();

Console.WriteLine("{0} has {1} points.", King1.kingName, King1.kingPoints);
Console.WriteLine("{0} has {1} points.", King2.kingName, King2.kingPoints);
Console.WriteLine("{0} has {1} points.", King3.kingName, King3.kingPoints);

Console.ReadKey();






