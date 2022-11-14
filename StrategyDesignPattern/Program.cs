using StrategyDesignPattern;

Beagle aBeagle1 = new Beagle();

Console.WriteLine("How does a Beagle fly?");
Console.WriteLine(aBeagle1.Fly());
Console.WriteLine();
Console.WriteLine("Now put a jetpack on the beagle");
Console.WriteLine("How does a beagle fly?");

aBeagle1.FlyingMethod = new FliesWithAJetpack();
Console.WriteLine(aBeagle1.Fly());
