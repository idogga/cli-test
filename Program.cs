using Cocona;
using System;

var app = CoconaApp.Create();
app.AddCommand(([Argument] string path) => { var a = new ToHtml(path); a.Work(); });
app.Run();

// CoconaApp.Run((string? name, bool hey) =>
//     Console.WriteLine($"{(hey ? "Hey" :"Hello")} {(name ?? "Guest")}!"));

// namespace PdfToHtml
// {
// class Program
// {
//     static void Main(string[] args)
//     {
//         CoconaApp.Run<Program>(args);
//     }

//     [Command(Description = "This is a sample application")]
//     public void Hello([Option('u', Description = "Print a name converted to upper-case.")]bool toUpperCase, [Argument(Description = "Your name")]string name)
//     {
//         Console.WriteLine($"Hello {(toUpperCase ? name.ToUpper() : name)}!");
//     }
// }
// }