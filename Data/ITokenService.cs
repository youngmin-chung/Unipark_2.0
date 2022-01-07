using System.Threading.Tasks;
using serverapp.Models;

namespace serverapp.Data
{
    public interface ITokenService
    {
        Task<string> GenerateJSONWebToken(AppUser user);
    }
}
