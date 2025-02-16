namespace DesignPatternsDemo.Singleton_Pattern
{
	public class Singleton_OldMethod
	{
		private static Singleton_OldMethod? _instance;
		private static readonly object _lock = new();

		private Singleton_OldMethod()
		{
		}

		public static Singleton_OldMethod Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (_lock)
					{
						_instance ??= new Singleton_OldMethod();

					}
				}

				return _instance;
			}
		}

		public void DoSomething() => Console.WriteLine("Object is doing something by old method...");
	}
}
