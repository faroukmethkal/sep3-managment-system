package com.example.loginspring.controller;

import com.example.loginspring.domain.TaskLogic;

import model.Profile;
import model.Status;
import model.Task;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.*;

import javax.annotation.Nullable;
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
    public List<Task> getAllRelatedTasksForEmployee(@RequestParam("username") String username){
        return taskLogic.getAllTaskForUsername(username);
    }

    @GetMapping("task")
    @PreAuthorize("hasAnyRole('ROLE_fullTimeEmployee','ROLE_admin')")
    public void assignEmployeeToTask(@RequestParam("username") String username, @RequestParam("taskId") int taskId){
        taskLogic.assignEmployeeToTask(username, taskId);
    }

    @DeleteMapping("task")
    @PreAuthorize("hasAnyRole('ROLE_fullTimeEmployee', 'ROLE_admin')")
    public void unAssignEmployeeToTask(@RequestParam("username") String username, @RequestParam("taskId") int taskId){
        taskLogic.removeEmployeeFromTask(taskId, username);
    }

   /* @PutMapping("task")
    @PreAuthorize("hasAnyRole('ROLE_fullTimeEmployee')")
    public void changeTaskStatus(@RequestParam("status") Status status, @RequestParam("taskId") int taskId){
        taskLogic.setStatusOfTask(taskId, status);
    }*/

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


    /**
     * employee to unassign
     */

}
