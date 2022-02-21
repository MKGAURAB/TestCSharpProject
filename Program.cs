using System.Collections.Immutable;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// var game = Game.Instance;

// game.Run_Game();

// var VendingMachine = new VendingMachine(new FakeRepo());

// while (VendingMachine.IsWaitingForUser())
// {
//     var data = Console.ReadLine().Split(" ");
//     if (data.Length > 1 && data[0] != null && data[1] != null) VendingMachine.RequestProduct(data[0], Convert.ToInt16(data[1]));
// }

var director = new ReportDirector();
var pdfreport = new PDFReport();

Console.WriteLine(director.PrepareReport(pdfreport).ToString());
