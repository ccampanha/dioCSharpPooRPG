using DotnetRpgDIO.src.Entities;

Knight arus = new Knight("Arus", 23,"Knight");
Wizard jennica = new Wizard("Jennica", 25, "White wizard");
Wizard topappa = new Wizard("Topappa", 32, "Black wizard");
topappa.TypeMagic = "Black";
Ninja wedje = new Ninja("Wedje", 44, "Wedge");

Console.WriteLine(arus.Attack());
Console.WriteLine(jennica.Attack());
Console.WriteLine(topappa.Attack());
Console.WriteLine(wedje.Attack());
Console.WriteLine(jennica.Attack(8));