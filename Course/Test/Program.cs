using CourseSchedule;
using System.Collections.Generic;

List<Course> CourseList = new List<Course>();
Course c1 = new Course{ CourseId=1, CourseName="JAVA", CourseFaculty="JONY", CourseDuration=300 };
Course c2 = new Course{ CourseId=2, CourseName="PYTHON", CourseFaculty="AMANDA", CourseDuration=310 };
Course c3 = new Course{ CourseId=3, CourseName=".NET", CourseFaculty="RON", CourseDuration=400 };
Course c4 = new Course{ CourseId=4, CourseName="DBT", CourseFaculty="SINCHAN", CourseDuration=250 };
CourseList.Add(c1);
CourseList.Add(c2);
CourseList.Add(c3);
CourseList.Add(c4);
Console.WriteLine("__MENU__");
Console.WriteLine("1.Add Course");
Console.WriteLine("2.Remove Course");
Console.WriteLine("3.Update Course");
Console.WriteLine("4.Display All Course");

bool flag = true;

while (flag)
{
    Console.WriteLine("Enter the choice : ");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1 :
            Console.WriteLine("Enter the Course Details : ");
            Course cs1 = new Course(int.Parse(Console.ReadLine()),Console.ReadLine(),
                                    Console.ReadLine(),int.Parse(Console.ReadLine()));
            Console.WriteLine("Course Added");                        
            break;

        case 2 :
            Console.WriteLine("Enter the Courseid : ");
            int cid = int.Parse(Console.ReadLine());
            foreach (var course in CourseList)
            {
                if (cid == course.CourseId)
                {
                    CourseList.Remove(course);
                    break;
                }
            } 
            break;

        case 3 :
            Console.WriteLine("Enter the Courseid : ");
            int cid1 = int.Parse(Console.ReadLine());
            foreach (var course in CourseList)
            {
                if (cid1 == course.CourseId)
                {
                    Console.WriteLine("Enter the new faculty name : ");
                    course.CourseFaculty = Console.ReadLine();
                    break;
                }
            }     
            break;

        case 4 : 
            Console.WriteLine("All Course avaible : ");
            foreach (var course in CourseList)
            {
                Console.WriteLine(course);
            } 
            break;

        case 5 :
            flag = false;
            break;                           


        default: Console.WriteLine("Please Enter Valid Choice :");
        break;
    }
}
