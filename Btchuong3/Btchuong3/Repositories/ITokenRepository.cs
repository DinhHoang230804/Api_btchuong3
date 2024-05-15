using Microsoft.AspNetCore.Identity;


namespace Btchuong3.Repositories
{
    public interface ITokenRepository
    {
            string CreateJWTToken(IdentityUser user, List<string> roles);

    }
}
