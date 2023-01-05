namespace CourseSchedule;
using System.ComponentModel.DataAnnotations;

public class Course
{
    [Required]
    public int CourseId{get;set;}

    public string? CourseName{get;set;}

    public string? CourseFaculty{get;set;}

    public int CourseDuration{get;set;}

    public Course()
    {
        this.CourseId = 101;
        this.CourseName = "PGDAC";
        this.CourseFaculty = "JACK";
        this.CourseDuration = 900;
    }

    public Course(int id,string cname,string fname,int duration)
    {
        this.CourseId = id;
        this.CourseName = cname;
        this.CourseFaculty = fname;
        this.CourseDuration = duration;
    }

    public override string ToString()
    {
        return "Course Id : "+this.CourseId+"\n"+"Course Name : "+this.CourseName+"\n"+"Faculty Name : "+this.CourseFaculty+"\n"+"Duration : "+this.CourseDuration;
    }
}
