﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorSep3.model;

namespace BlazorSep3.Data
{
    public interface ITaskServices
    {
        Task AddTask(Taskk task);
        Task<IList<Taskk>> GetTasks(DateTime? startTime, DateTime? deadLine, bool?isImportant, Status? status);

        Task<IList<Taskk>> GetAllRelativeTasks(DateTime? startTime, DateTime? deadLine, bool? isImportant,
            Status? status);

        Task RemoveTask(int id);
        Task<Taskk> GetTaskById(int id);
        Task EditTask(Taskk task);

        Task TakeTask(int id);
        Task<IList<Taskk>> GetAllMyTasks(Status? status);

        Task<IList<Profile>> GetTeamWorkingOnTask(int taskId);

    }
}