 using Domain;


namespace Infrastructure;

public class StudentService
{
    List<Student> _students = new List<Student>();

    public List<Student> GetStudents()
    {
        return _students;
    }

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public void UpdateStudent(Student student)
    {
        foreach (var item in _students)
        {
            if (item.ID == student.ID)
            {
                item.FirstName = student.FirstName;
                item.LastName = student.LastName;
                item.Address = student.Address;
                item.BirthDate = student.BirthDate;
            }

        }

    }

    public void DeleteStudent(int id)
    {

        foreach (var item in _students)
        {
            if (item.ID == id)
            {
                _students.Remove(item);
                break;
            }

        }
    }
}
