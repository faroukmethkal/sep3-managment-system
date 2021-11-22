using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorSep3.model;

namespace BlazorSep3.Data
{
    public interface ITaskServices
    {
        Task AddTask(Taskk task);
        Task<IList<Taskk>> getTasks(DateTime? startTime, DateTime? deadLine, bool?isImportant, Status? statuss);
    }
}