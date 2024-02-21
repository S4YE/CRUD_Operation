using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation.Entities;

public class Course
{
    
    public int Id { get; set; }
    public string InstructorName { get; set; }
    public string CourseName { get; set; }
    public string CourseDescription { get; set; }
    public double Price { get; set; }
    public string Price2 {  get; set; }
}
