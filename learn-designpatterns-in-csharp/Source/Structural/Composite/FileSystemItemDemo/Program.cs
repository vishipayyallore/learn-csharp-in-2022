using FileSystemItemDemo.Composites;
using FileSystemItemDemo.Leafs;
using static System.Console;

Title = "Design Pattern - Composite";

ForegroundColor = ConsoleColor.Cyan;

var root = new DirectoryItem("root", 0);
var topLevelFile = new FileItem("toplevel.txt", 100);
var topLevelDirectory1 = new DirectoryItem("topleveldirectory1", 4);
var topLevelDirectory2 = new DirectoryItem("topleveldirectory2", 4);

root.Add(topLevelFile);
root.Add(topLevelDirectory1);
root.Add(topLevelDirectory2);

var subLevelFile1 = new FileItem("sublevel1.txt", 200);
var subLevelFile2 = new FileItem("sublevel2.txt", 150);

topLevelDirectory1.Add(subLevelFile1);
topLevelDirectory1.Add(subLevelFile2);

var subLevelFile3 = new FileItem("sublevel3.txt", 300);
var subLevelFile4 = new FileItem("sublevel4.txt", 250);

topLevelDirectory2.Add(subLevelFile3);
topLevelDirectory2.Add(subLevelFile4);

WriteLine($"Size of topLevelDirectory1: {topLevelDirectory1.GetSize()}");
WriteLine($"Size of topLevelDirectory2: {topLevelDirectory2.GetSize()}");
WriteLine($"Size of root: {root.GetSize()}");

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();
