 using Domain;

namespace Infrastructure;

public class CourseService
{
    List<Course> _courses = new List<Course>();
    public List<Course> GetCourse()
    {
        return _courses;
    }

    public void AddCourse(Course course)
    {
        _courses.Add(course);
    } 

    public void UpdateCourse(Course course)
    {
        foreach (var item in _courses)
        {
            if (item.ID == course.ID)
            {
                item.Title = course.Title;
                item.Description = course.Description;
                item.Fee = course.Fee;
                item.HasDiscount = course.HasDiscount;

            }
        }
    } 

    public void Delete(int id)
    {
        foreach (var item in _courses)
        {
            if (item.ID == id)
            {
                _courses.Remove(item); 
                break;
            }
        }
    }
}
