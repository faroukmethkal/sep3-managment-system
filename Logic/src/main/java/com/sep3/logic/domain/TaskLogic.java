package com.sep3.logic.domain;

import model.Profile;
import model.Specialties;
import model.Status;
import model.Task;

import javax.annotation.Nullable;
import java.time.LocalDate;
import java.util.List;

public interface TaskLogic {
     void createNewTask(Task task);
    List<Task> getAllTask(@Nullable LocalDate startDate, @Nullable LocalDate deadline, @Nullable Boolean isImportant, @Nullable Status status);
    Task getTaskById(int taskId);
    void editTask(Task task);
    void removeTask(int id);


    /**
     TODO edit task's especialties
     */


    List<Profile> getAllTeamMemberForTask(int taskId);
    /**
     * full time employee
     */
     List<Task> getAllTaskForUsername(String username,@Nullable LocalDate startTime,@Nullable LocalDate deadLine,@Nullable Boolean isImportant,@Nullable Status status);
    Specialties getSpecialty(String username);
    void assignEmployeeToTask(String username, int taskId);
    List<Task> getMyTasksWhereStatus(String username, Status status);

    void setStatusOfTask(int taskId, Status status) ;
    void removeEmployeeFromTask(int taskId, String username);

    void increaseSpentHoursInTaskBy(int taskId, double spentHours) ;

    List<Task> getAvailableTask();





}
