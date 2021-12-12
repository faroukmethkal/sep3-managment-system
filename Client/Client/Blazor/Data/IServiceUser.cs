using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model;
using Syncfusion.Blazor;

namespace Blazor.Data
{
    public interface IServiceUser
    {
        Task<Account> ValidateUser(string username, string password);
        Task RegisterUser(Profile profile);
        Task<IList<Profile>> GetAllProfiles(Role? role);
        Task<Account> GetAccountByUsername(string username);
        Task<Profile> GetMyProfile();
        Task<List<DateTime>> GetAllMyDate();
        Task AddNewDateToCalendar(DateTime dateTime);
    }
}