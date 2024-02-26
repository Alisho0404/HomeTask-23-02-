 using Domain;
using Infrastructure;

var student1 = new Student();
student1.ID = 1;
student1.FirstName = "Bob";
student1.LastName = "Marli";
student1.BirthDate = new DateTime(1998,10,20);
student1.Address = "Dushanbe dis.Sino";


var student2 = new Student();
student2.ID = 2;
student2.FirstName = "Sam";
student2.LastName = "Johnson";
student2.BirthDate = new DateTime(1996,02,15);
student2.Address = "Dushanbe dis.Firdavsi";

var student3 = new Student();
student3.ID = 3;
student3.FirstName = "Michael";
student3.LastName = "Johnson";
student3.BirthDate = new DateTime(1985,03,28);
student3.Address = "Dushanbe dis.Shohmansur";

var studentService = new StudentService();
studentService.AddStudent(student1);
studentService.AddStudent(student2);
studentService.AddStudent(student3);

foreach (var student in studentService.GetStudents())
{
    System.Console.WriteLine("Student " + student.ID);
    System.Console.WriteLine("FirstName: " + student.FirstName);
    System.Console.WriteLine("LastName: " + student.LastName);
    System.Console.WriteLine("Birthdate: " + student.BirthDate);
    System.Console.WriteLine("Adress: " + student.Address);
    System.Console.WriteLine("---------------------------------------");
}  
var student4 = new Student();
student2.ID = 2;
student2.FirstName = "Salam";
student2.LastName = "John";
student2.BirthDate = new DateTime(1996,02,15);
student2.Address = "Dushanbe dis.Somoni";  

System.Console.WriteLine("New Updated list of student");
System.Console.WriteLine();

studentService.UpdateStudent(student4); 

foreach (var student in studentService.GetStudents())
{
    System.Console.WriteLine("Student " + student.ID);
    System.Console.WriteLine("FirstName: " + student.FirstName);
    System.Console.WriteLine("LastName: " + student.LastName);
    System.Console.WriteLine("Birthdate: " + student.BirthDate);
    System.Console.WriteLine("Adress: " + student.Address);
    System.Console.WriteLine("---------------------------------------");
}   

studentService.DeleteStudent(2);  

System.Console.WriteLine("After deleting student with Id 2 "); 
System.Console.WriteLine();

foreach (var student in studentService.GetStudents())
{
    System.Console.WriteLine("Student " + student.ID);
    System.Console.WriteLine("FirstName: " + student.FirstName);
    System.Console.WriteLine("LastName: " + student.LastName);
    System.Console.WriteLine("Birthdate: " + student.BirthDate);
    System.Console.WriteLine("Adress: " + student.Address);
    System.Console.WriteLine("---------------------------------------");
}   

var teacher1=new Teacher();
teacher1.ID=1;
teacher1.FirstName="Shosafo"; 
teacher1.LastName="Shosafoev"; 
teacher1.Position="Full Stack"; 
teacher1.ExperienceAmount=8;  

var teacher2=new Teacher();
teacher2.ID=2;
teacher2.FirstName="Alisho"; 
teacher2.LastName="Sholangarov"; 
teacher2.Position="Back-end"; 
teacher2.ExperienceAmount=3;  

var teacherService=new TeacherService(); 
teacherService.AddTeacher(teacher1); 
teacherService.AddTeacher(teacher2);

foreach (var teacher in teacherService.GetTeacher())
{ 
 System.Console.WriteLine("Teacher "+teacher.ID);
 System.Console.WriteLine("Teacher name: "+teacher.FirstName);   
 System.Console.WriteLine("Teacher's last name: "+teacher.LastName); 
 System.Console.WriteLine("Teacher's position: "+teacher.Position); 
 System.Console.WriteLine("Teacher's experience (year): "+teacher.ExperienceAmount); 
 System.Console.WriteLine("____________________________________________"); 
} 

var teacher3=new Teacher();
teacher2.ID=2;
teacher2.FirstName="Alisho"; 
teacher2.LastName="Sholangarov"; 
teacher2.Position="Full Stack"; 
teacher2.ExperienceAmount=5; 

 teacherService.UpdateTeacher(teacher3);   
 System.Console.WriteLine("After updating teacher's list: ");

 foreach (var teacher in teacherService.GetTeacher())
{ 
 System.Console.WriteLine("Teacher "+teacher.ID);
 System.Console.WriteLine("Teacher name: "+teacher.FirstName);   
 System.Console.WriteLine("Teacher's last name: "+teacher.LastName); 
 System.Console.WriteLine("Teacher's position: "+teacher.Position); 
 System.Console.WriteLine("Teacher's experience (year): "+teacher.ExperienceAmount); 
 System.Console.WriteLine("____________________________________________"); 
}  

var course1=new Course(); 
course1.ID=1; 
course1.Title="C#"; 
course1.Description="the main learning language"; 
course1.Fee=1500; 
course1.HasDiscount=false; 

var course2=new Course(); 
course2.ID=2; 
course2.Title="JS"; 
course2.Description="second language"; 
course2.Fee=1500; 
course2.HasDiscount=true; 

var courseService=new CourseService(); 
courseService.AddCourse(course1); 
courseService.AddCourse(course2); 
foreach (var course in courseService.GetCourse())
{
    System.Console.WriteLine("Course ID: "+course.ID); 
    System.Console.WriteLine("Course name: "+course.Title); 
    System.Console.WriteLine("Course description: "+course.Description); 
    System.Console.WriteLine("Course fee: "+course.Fee); 
    System.Console.WriteLine("Course discount: "+course.HasDiscount); 
    System.Console.WriteLine("------------------------------------------------------");
}

var course3=new Course(); 
course2.ID=2; 
course2.Title="JS"; 
course2.Description="second language"; 
course2.Fee=1500; 
course2.HasDiscount=false; 

courseService.UpdateCourse(course3);  
System.Console.WriteLine("After update cours");

foreach (var course in courseService.GetCourse())
{
    System.Console.WriteLine("Course ID: "+course.ID); 
    System.Console.WriteLine("Course name: "+course.Title); 
    System.Console.WriteLine("Course description: "+course.Description); 
    System.Console.WriteLine("Course fee: "+course.Fee); 
    System.Console.WriteLine("Course discount: "+course.HasDiscount); 
    System.Console.WriteLine("------------------------------------------------------");
}

var post1=new Post(); 
post1.ID=1; 
post1.Title="Active students"; 
post1.Description="Student who are the best on studying"; 
post1.VoiceAmount=5; 
post1.CreatedAt=new DateTime(2024,02,24); 

var post2=new Post(); 
post2.ID=2; 
post2.Title="Creative students"; 
post2.Description="Student who are the best on innovation"; 
post2.VoiceAmount=15; 
post2.CreatedAt=new DateTime(2024,02,22);

var postService=new PostService(); 
postService.AddPost(post1); 
postService.AddPost(post2); 

foreach (var posts in postService.GetPost())
{
    System.Console.WriteLine("Post ID: "+posts.ID); 
    System.Console.WriteLine("Post title: "+posts.Title); 
    System.Console.WriteLine("Post description: "+posts .Description); 
    System.Console.WriteLine("Post voice amount: "+posts.VoiceAmount); 
    System.Console.WriteLine("Date of creating: "+posts.CreatedAt);  
    System.Console.WriteLine("----------------------------------------------");
} 

postService.Delete(1); 
System.Console.WriteLine("Result after deleting post with id 1");  
System.Console.WriteLine();
foreach (var posts in postService.GetPost())
{
    System.Console.WriteLine("Post ID: "+posts.ID); 
    System.Console.WriteLine("Post title: "+posts.Title); 
    System.Console.WriteLine("Post description: "+posts .Description); 
    System.Console.WriteLine("Post voice amount: "+posts.VoiceAmount); 
    System.Console.WriteLine("Date of creating: "+posts.CreatedAt);  
    System.Console.WriteLine("----------------------------------------------");
} 
