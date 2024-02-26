 using Domain;

namespace Infrastructure;

public class TeacherService
{
    List<Teacher> _teahcers = new List<Teacher>(); 

    public List<Teacher> GetTeacher()
    {
        return _teahcers;
    } 

    public void AddTeacher(Teacher teacher)
    {
        _teahcers.Add(teacher);
    } 

    public void UpdateTeacher(Teacher teacher)
    {
        foreach (var item in _teahcers)
        {
            if (item.ID == teacher.ID)
            {
                item.FirstName = teacher.FirstName;
                item.LastName = teacher.LastName;
                item.Position = teacher.Position;
                item.ExperienceAmount = teacher.ExperienceAmount;
            }
        }
    } 

    public void Delete(int id)
    {
        foreach (var item in _teahcers)
        {
            if (item.ID == id)
            {
                _teahcers.Remove(item); 
                break;
            }
        }
    }
}
