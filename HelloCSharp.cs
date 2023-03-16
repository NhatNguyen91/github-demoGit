using System;

public class Class1
{
	public Class1()
	{
		Console.WriteLine("Hello World! I'm a developer!");

	}

	void addDick()
	{
		Console.WriteLine("Add more pussxxy!");

	}

	public void addMoreSource(Action callback , int a)
	{
		callback() ;
	}
	void Update()
	{
		int a=0 ;
		Console.WriteLine("Update availbe!");
		addMoreSource(() => Console.WriteLine("Call Back"), a);
	}

	void main()
	{
		addDick();
	}
}
