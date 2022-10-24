
int a;
int b;
int c;
int d;
int x;
int y;


Console.Title = "The defense of Consolas";
Console.Write("Target Row? ");
y = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
x = Convert.ToInt32(Console.ReadLine());



a = x + 1;
b = x - 1;
c = y + 1;
d = y - 1;


Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Deploy to:");
Console.WriteLine($"{a}" + ", " + y);
Console.WriteLine($"{b}" + ", " + y);
Console.WriteLine($"{c}" + ", " + x);
Console.WriteLine($"{d}" + ", " + x);
Console.Beep();

Console.ReadLine();