// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var services = new ServiceCollection();
services.AddSingleton<ServiceImpl>();

var serviceProvider = services.BuildServiceProvider();
var service = serviceProvider.GetService<ServiceImpl>();
service.Name = "Tom";
service.SayHello();