Console.WriteLine(@$"
----------------------
|      Programa      |
|       media        |
----------------------
");

Console.WriteLine($"Informe sua n1: ");
int n1 = int.Parse (Console.ReadLine());

Console.WriteLine($"Informe sua n2: ");
int n2 = int.Parse (Console.ReadLine());

Console.WriteLine($"Informe sua n3: ");
int n3 = int.Parse (Console.ReadLine());

Console.WriteLine($"Informe sua n4: ");
int n4 = int.Parse (Console.ReadLine());

Console.WriteLine($"Informe sua n5: ");
int n5 = int.Parse (Console.ReadLine());

int media = (n1 + n2 + n3 + n4 + n5) / 5;


Console.WriteLine($"Sua media e {media}");

