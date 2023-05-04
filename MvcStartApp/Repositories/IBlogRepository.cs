using MvcStartApp.Models;

namespace MvcStartApp.Repositories
{
    public interface IBlogRepository
    {
        Task AddUser(User user);

        Task<User[]> GetUsers();
    }
}
