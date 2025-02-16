using DesignPatternsDemo.Decorator;
using DesignPatternsDemo.Singleton_Pattern;

Console.WriteLine("Start Demo ...!!!");

Console.WriteLine();
Console.WriteLine("*** SINGLETON ***");
Singleton_NewMethod.Instance.DoSomething();
Singleton_OldMethod.Instance.DoSomething();

Console.WriteLine();
Console.WriteLine("*** DECORATOR ***");
new Decorator(new ConcreteComponent()).Operation();

Console.WriteLine();
Console.WriteLine("End Demo ...!!!");
