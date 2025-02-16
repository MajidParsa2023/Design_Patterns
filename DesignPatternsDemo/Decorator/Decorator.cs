namespace DesignPatternsDemo.Decorator
{
	public class Decorator : IComponent
	{
		private IComponent _component;

		public Decorator(IComponent component)
		{
			_component = component;
		}

		public void Operation()
		{
			_component.Operation();
			Console.WriteLine("Decorator Operation - Executing base operation");
		}
	}
}
