using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
   // basic bulding block for all Components at runtime
	interface IComponent
	{
		string Get();
	}

	class ConcreteComponent : IComponent
	{
		public string Get()
		{
			return "1";
		}
	}

	// create abstract decorator all 'decorating classes' will inherit from
	abstract class ComponentDecorator : IComponent
	{
		// private reference to ConcreteComponent being decorated
		private readonly IComponent _component;

		public ComponentDecorator(IComponent component)
		{
			_component = component;
		}

		public virtual string Get()
		{
			return _component.Get();
		}
	}

	class ConcreteComponentDecoratorA : ComponentDecorator
	{
		public ConcreteComponentDecoratorA(IComponent component) : base(component)
		{
		}

		public string Decorate(string result)
		{
			return "2" + result;
		}

		public override string Get()
		{
			var result = base.Get();
			return Decorate(result);
		}
	}

	class ConcreteComponentDecoratorB : ComponentDecorator
	{
		public ConcreteComponentDecoratorB(IComponent page) : base(page)
		{
		}

		public string Decorate(string result)
		{
			return "3" + result;
		}

		public override string Get()
		{
			var result = base.Get();
			return Decorate(result);
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			IComponent component = new ConcreteComponent();
			component = new ConcreteComponentDecoratorA(component);
			component = new ConcreteComponentDecoratorB(component);
			var result = component.Get();

			Console.WriteLine(result);
		}
	}
}
