System.Diagnostics.Stopwatch timer = new Stopwatch();
timer.Start();
//...
timer.Stop();
Console.WriteLine((timer.ElapsedMilliseconds / 100.0).ToString());
