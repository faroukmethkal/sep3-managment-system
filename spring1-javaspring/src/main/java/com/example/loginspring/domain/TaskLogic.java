package com.example.loginspring.domain;

import model.Profile;
import model.Specialties;
import model.Status;
import model.Task;

import javax.annotation.Nullable;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.util.List;
import java.util.Map;

public interface TaskLogic {
     void createNewTask(Task task);
    List<Task> getAllTask(@Nullable LocalDate startDate, @Nullable LocalDate deadline, @Nullable Boolean isImportant, @Nullable Status status);
    Task getTaskById(int taskId);
    void editTask(Task task);
    void removeTask(int id);

    /**
     TODO edit task's especialties
     */
    Map<String,Integer> getSpecialtiesOfTask(int taskId);
    void editSpecialtiesOfTask(int taskId, Map<String, Integer> specialties);
    void removeSpecialtyFromTask(int taskId, Specialties specialty);
    List<Profile> getAllTeamMemberForTask(int taskId);
    /**
     * full time employee
     */
     List<Task> getAllTaskForUsername(String username);
    Specialties getSpecialty(String username);
    void assignEmployeeToTask(String username, int taskId);
    List<Task> getMyTasksWhereStatus(String username, Status status);






}
