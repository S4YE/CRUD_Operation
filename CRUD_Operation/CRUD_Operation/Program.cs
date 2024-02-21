// See https://aka.ms/new-console-template for more information
using CRUD_Operation.Entities;

Console.WriteLine("Hello, World!");


Course course1 = new Course();  

course1.Id = 1;
course1.CourseName = "Senior Yazılım Geliştirme Kampı";
course1.CourseDescription = ".NET";
course1.InstructorName = "Engin Demirog";
course1.Price2 = "Ücretsiz";

Course course2 = new Course();

course2.Id = 2;
course2.CourseName = "Yazılım Geliştirici Yetiştirme Kampı";
course2.CourseDescription = "C# + Angular";
course2.InstructorName = "Engin Demirog";
course2.Price2 = "Ücretsiz";

Course course3 = new Course();

course3.Id = 3;
course3.CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı";
course3.CourseDescription = "Python & Selenium";
course3.InstructorName = "Halit Enes Kalaycı";
course3.Price2 = "Ücretsiz";

Course course4 = new Course();

course4.Id = 4;
course4.CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı";
course4.CourseDescription = "Java";
course4.InstructorName = "Engin Demirog";
course4.Price2 = "Ücretsiz";

Course course5 = new Course();

course5.Id = 5;
course5.CourseName = "Yazılım Geliştirici Yetiştirme Kampı";
course5.CourseDescription = "JavaScript";
course5.InstructorName = "Engin Demirog";
course5.Price2 = "Ücretsiz";

Course course6 = new Course();

course6.Id = 6;
course6.CourseName = "Yazılım Geliştirici Yetiştirme Kampı";
course6.CourseDescription = "Java + REACT";
course6.InstructorName = "Engin Demirog";
course6.Price2 = "Ücretsiz";

Course course7 = new Course();

course7.Id = 7;
course7.CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı";
course7.CourseDescription = "C#";
course7.InstructorName = "Engin Demirog";
course7.Price2 = "Ücretsiz";

Course course8 = new Course();

course8.Id = 8;
course8.CourseName = "Programlamaya Giriş için Temel Kurs";
course8.CourseDescription = " ";
course8.InstructorName = "Engin Demirog";
course8.Price2 = "Ücretsiz";

Course[] courses = { course1, course2, course3, course4, course5, course6, course7, course8 };
for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine("Kurs Adı: " +courses[i].CourseName);
    Console.WriteLine("Kurs Tanımı: " + courses[i].CourseDescription);
    Console.WriteLine("Eğitmen: " + courses[i].InstructorName);
    Console.WriteLine("Fiyatı: " + courses[i].Price2);
    Console.WriteLine(" ");
}