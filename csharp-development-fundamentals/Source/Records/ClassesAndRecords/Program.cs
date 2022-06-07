// See https://aka.ms/new-console-template for more information

using ClassesAndRecords.Entities;

using static System.Console;

var pluralsightCourse = new Course();
pluralsightCourse.Name = "Working with C# Records";
pluralsightCourse.Author = "Some Author";

var classroomCourse = new CourseRecord(
    "Working with C# Records",
    "Some Author"
    );

// Not Allowed
// classroomCourse.Name = "Another title";

WriteLine("\nPress any key ...");
