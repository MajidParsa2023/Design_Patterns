namespace DesignPatternsDemo.Decorator
{
	public class ConcreteComponent : IComponent
	{
		public void Operation()
		{
			Console.WriteLine("Concrete Component Operation - Adding decorator behavior without changing codes in the Decorator.cs");
		}
	}
}
