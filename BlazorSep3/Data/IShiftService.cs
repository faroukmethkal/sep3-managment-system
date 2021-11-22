﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorSep3.model;

namespace BlazorSep3.Data
{
    public interface IShiftService
    {
        Task<IList<Shift>> getShifts(DateTime? date, DateTime? startTime, DateTime? endTime);
        Task AddShift(Shift shift);
    }
}