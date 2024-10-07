using System.Threading.Tasks;

namespace EduHubAPI.CA.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}
