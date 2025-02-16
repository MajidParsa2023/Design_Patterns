namespace DesignPatternsDemo.Singleton_Pattern
{
	public class Singleton_NewMethod
	{
		private static readonly Lazy<Singleton_NewMethod> _instance = new(() => new Singleton_NewMethod());

		private Singleton_NewMethod()
		{
		}

		public static Singleton_NewMethod Instance => _instance.Value;

		public void DoSomething() => Console.WriteLine("Object is doing something by new method...");
	}
}
