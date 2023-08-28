using WhyUseIsNull;

TestClass? nullObject = null;

Console.WriteLine($"nullObject == null -> {nullObject == null}");
Console.WriteLine($"nullObject is null -> {nullObject is null}");

TestClass A = new TestClass("TEST");
TestClass B = new TestClass("TEST");

Console.WriteLine($"nullObject == A -> {nullObject == B}");
Console.WriteLine($"nullObject == B -> {nullObject == B}");

Console.WriteLine($"A == B -> {A == B}");
Console.WriteLine($"A.Equals(B) -> {A.Equals(B)}");

Console.Read();