using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorSep3.model;

namespace BlazorSep3.Data
{
    public interface IShiftService
    {
        Task<IList<Shift>> getShifts(DateTime? date, DateTime? startTime, DateTime? endTime);
        Task AddShift(Shift shift);
        Task RemoveShift(int id);
        Task<Shift> GetShiftById(int id);
        Task EditShift(Shift shift);
        Task TakeShift(int id);
    }
}