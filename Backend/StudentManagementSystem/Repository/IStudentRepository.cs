using StudentManagementSystem.Models;

namespace StudentManagementSystem.Repository
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudents();

        Task<Student> GetStudentById(int id);

        Task<Student> AddStudent(Student student);

        Task<Student> UpdateStudent(Student student);

        Task<bool> DeleteStudent(int id);
    }
}