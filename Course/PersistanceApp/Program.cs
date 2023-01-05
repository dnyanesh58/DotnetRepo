using CourseSchedule;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

Course c1 = new Course{ CourseId=1, CourseName="JAVA", CourseFaculty="JONY", CourseDuration=300 };
Course c2 = new Course{ CourseId=2, CourseName="PYTHON", CourseFaculty="AMANDA", CourseDuration=310 };
Course c3 = new Course{ CourseId=3, CourseName=".NET", CourseFaculty="RON", CourseDuration=400 };
Course c4 = new Course{ CourseId=4, CourseName="DBT", CourseFaculty="SINCHAN", CourseDuration=250 };

List<Course> CourseList = new List<Course>();

CourseList.Add(c1);
CourseList.Add(c2);
CourseList.Add(c3);
CourseList.Add(c4);

try
{
    var options = new JsonSerializerOptions {IncludeFields = true};
    var CourseJson = JsonSerializer.Serialize<List<Course>>(CourseList,options);
    string fileName = @"H:\DAC\LAB SESSIONS\DOTNET_LAB\Day_3\courses.json";

    File.WriteAllText(fileName,CourseJson); 
    string jsonString = File.ReadAllText(fileName);
    List<Course> jsonCourses = JsonSerializer.Deserialize<List<Course>>(jsonString);
    Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
    foreach (Course cs in jsonCourses)
    {
        Console.WriteLine($"{cs.CourseFaculty} : {cs.CourseName}");   
    }
}
catch (Exception e)
{
    
    throw;
}