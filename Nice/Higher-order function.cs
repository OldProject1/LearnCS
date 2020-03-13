var f = (Func<int, int>) ((x) => x + 3);
var g = (Func<Func<int, int>, int, int>) ((func, x) => func(x) * func(x));
Console.WriteLine(g(f, 7));
