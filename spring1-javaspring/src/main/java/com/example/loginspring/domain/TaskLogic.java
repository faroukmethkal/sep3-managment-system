package com.example.loginspring.domain;

import model.Specialties;
import model.Status;
import model.Task;

import javax.annotation.Nullable;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.util.List;

public interface TaskLogic {
     void createNewTask(Task task);
    //For Employee
     List<Task> getTaskWhereSpecialtiesIs(Specialties s);
     List<Task> getAllTask(@Nullable LocalDate startDate, @Nullable LocalDate deadline, @Nullable Boolean isImportant, @Nullable Status status);
    Task getTaskById(int taskId);

}
