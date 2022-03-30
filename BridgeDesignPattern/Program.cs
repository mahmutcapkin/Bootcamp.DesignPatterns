// See https://aka.ms/new-console-template for more information
using BridgeDesignPattern;


Tablet tablet = new(new Mp3(),new Voice());
tablet.Play();
tablet.Call();
Console.WriteLine("------------------");
Computer computer = new(new Mp4(), new Video());
computer.Play();
computer.Call();

Console.WriteLine("------------------");
Telephone telephone = new(new Mp4(), new Video());
telephone.Play();
telephone.Call();
