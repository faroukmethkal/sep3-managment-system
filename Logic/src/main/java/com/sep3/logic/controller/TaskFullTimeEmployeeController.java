package com.sep3.logic.controller;


import com.sep3.logic.domain.TaskLogic;
import com.sep3.logic.exception.ApiRequestException;
import model.Profile;
import model.Status;
import model.Task;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.format.annotation.DateTimeFormat;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.*;

import javax.annotation.Nullable;
import java.time.LocalDate;
import java.util.List;

@RestController
@RequestMapping("api/employee/")
public class TaskFullTimeEmployeeController {
    private TaskLogic taskLogic;

    @Autowired
    public TaskFullTimeEmployeeController(TaskLogic taskLogic) {
        this.taskLogic = taskLogic;
    }

    @GetMapping("tasks")
    @PreAuthorize("hasAnyRole('ROLE_fullTimeEmployee')")
    public List<Task> getAllRelatedTasksForEmployee(@RequestParam("username") String username,
                                                    @RequestParam("startTime") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") @Nullable LocalDate startTime,
                                                    @RequestParam("deadLine") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") @Nullable LocalDate deadLine,
                                                    @RequestParam("isImportant") @Nullable Boolean isImportant,
                                                    @RequestParam("status") @Nullable Status status
                                                    ){
        return taskLogic.getAllTaskForUsername(username,startTime,deadLine,isImportant,status);
    }

    @GetMapping("task")
    @PreAuthorize("hasAnyRole('ROLE_fullTimeEmployee','ROLE_admin')")
    public void assignEmployeeToTask(@RequestParam("username") String username, @RequestParam("taskId") int taskId){
        try {
            taskLogic.assignEmployeeToTask(username, taskId);
        } catch (Exception e) {
            throw new ApiRequestException(e.getMessage());
        }
    }

    @DeleteMapping("task")
    @PreAuthorize("hasAnyRole('ROLE_fullTimeEmployee', 'ROLE_admin')")
    public void unAssignEmployeeToTask(@RequestParam("username") String username, @RequestParam("taskId") int taskId){
        taskLogic.removeEmployeeFromTask(taskId, username);

    }


    @GetMapping("myTasks")
    @PreAuthorize("hasAnyRole('ROLE_fullTimeEmployee')")
    public List<Task> getMyTasks(@RequestParam("username") String username, @RequestParam("status") @Nullable Status status){
        return taskLogic.getMyTasksWhereStatus(username, status);
    }

    @GetMapping("team")
    @PreAuthorize("hasAnyRole('ROLE_fullTimeEmployee','ROLE_admin')")
    public List<Profile> getTeamWorkingOnTaks(@RequestParam("Id") int taskId){
        return taskLogic.getAllTeamMemberForTask(taskId);
    }

    @PutMapping("task")
    @PreAuthorize("hasAnyRole('ROLE_fullTimeEmployee')")
    public void increaseSpentHours(@RequestParam("taskId") int taskId, @RequestParam("spentHours") double spentHours){
        taskLogic.increaseSpentHoursInTaskBy(taskId, spentHours);
    }


}
