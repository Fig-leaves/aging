
using System;

class HelloWorld {
	public int add(int a, int b) {
		return a+b;
	}
	public static void Main() {
		HelloWorld hw = new HelloWorld();
		int result = hw.add(1, 2);
		Console.WriteLine("{0:C}", result);
	}
}
