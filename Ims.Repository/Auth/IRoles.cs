using System.Threading.Tasks;

namespace Ims.Repository.Auth
{
    public interface IRoles
    {
        Task GenerateRolesAsync();

        Task AddToRoles(string applicationUserId);
    }
}
