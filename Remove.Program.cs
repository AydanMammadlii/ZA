using Lab_taskı;

Console.WriteLine("Hello, World!");

Test<string> test = new Test<string>();
test.Add("Salam1");
test.Add("Salam");
test.Add("Salam1");
test.Add("Salam");
test.customRemove("Salam");
test.ShowAll();
