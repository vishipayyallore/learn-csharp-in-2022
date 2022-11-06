using PersonDemo.Aggregates;
using PersonDemo.Models;
using static System.Console;

Title = "Design Pattern - Iterator";

ForegroundColor = ConsoleColor.Cyan;

// create the collection
PeopleCollection people = new()
{
    new Person("Kevin Dockx", "Belgium"),
    new Person("Gill Cleeren", "Belgium"),
    new Person("Roland Guijt", "The Netherlands"),
    new Person("Thomas Claudius Huber", "Germany")
};

// create the interator
var peopleIterator = people.CreateIterator();

// use the iterator to run through the people in the collection; they should come out in alphabetical order
for (Person person = peopleIterator.First(); !peopleIterator.IsDone; person = peopleIterator.Next())
{
    WriteLine(person?.Name);
}

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();

