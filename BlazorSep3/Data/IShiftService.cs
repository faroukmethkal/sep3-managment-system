using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorSep3.model;

namespace BlazorSep3.Data
{
    public interface IShiftService
    {
        Task<IList<Shift>> GetShifts(DateTime? date, DateTime? startTime, DateTime? endTime);
        Task<IList<Shift>> GetCriticalShifts();
        Task AddShift(Shift shift);
        Task RemoveShift(int id);
        Task<Shift> GetShiftById(int id);
        Task EditShift(Shift shift);
        Task TakeShift(int id);
        Task AddParttimerToShift(int shiftId, string username);
        Task UnassignFromShift(int id);
        Task<IList<Shift>> GetMyShifts(DateTime? date);
        Task<IList<Shift>> GetAllAvailableShift(DateTime? date, DateTime? startTime, DateTime? endTime);
    }
}