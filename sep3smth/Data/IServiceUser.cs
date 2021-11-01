using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorSep3LoginExample.model;

namespace BlazorSep3LoginExample.Data
{
    public interface IServiceUser
    {
        Task<Dictionary<string, string>> ValidateUser(LoginUser user);
    }
}