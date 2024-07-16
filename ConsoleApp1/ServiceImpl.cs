namespace ConsoleApp1;

public class ServiceImpl : IService
{
    public string Name { get; set; }
    public void SayHello()
    {
        Console.WriteLine($"Hello, {Name}!");
    }
}