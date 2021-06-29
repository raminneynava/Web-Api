
using Infrastructure.Entities;
using System.Threading.Tasks;

namespace Services.Jwt
{
    public interface IJwtService
    {
        Task<AccessToken> GenerateAsync(User user);
    }
}