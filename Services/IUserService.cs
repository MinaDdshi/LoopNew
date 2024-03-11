using LoopAcademyProject.Entities;

namespace LoopAcademyProject.Services
{
    public interface IUserService
    {
        Task<bool> Create(User create);
        Task<User> Read(string Id);
        Task<List<User>> ReadAll();
        Task Update(User update);
        Task Delete(string Id);
    }
}
