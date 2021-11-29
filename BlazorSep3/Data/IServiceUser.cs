using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorSep3.model;

namespace BlazorSep3.Data
{
    public interface IServiceUser
    {
        Task<Account> ValidateUser(string username, string password);
        Task RegisterUser(Profile profile);
        Task<IList<Profile>> GetAllProfiles(Specialities? specialities);
        Task<Account> GetAccountByUsername(string username);
    }
}