package com.example.loginspring.controller;

import com.example.loginspring.domain.TaskLogic;
import model.Specialties;
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
@RequestMapping()
public class TaskController {
    private TaskLogic taskLogic;

    @Autowired
    public TaskController(TaskLogic taskLogic) {
        this.taskLogic = taskLogic;
    }

    @PostMapping("api/tasks")
    @PreAuthorize("hasAnyRole('ROLE_admin')")
    public void createNewTask(@RequestBody Task task){
        System.out.println(task.toString());
        taskLogic.createNewTask(task);
    }

    @PreAuthorize("hasAnyRole('ROLE_admin')")
    @GetMapping("api/tasks")
    public List<Task> getAllTask(@RequestParam("startTime") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") @Nullable LocalDate startTime,
                                 @RequestParam("deadLine") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") @Nullable LocalDate deadLine,
                                 @RequestParam("isImportant") @Nullable Boolean isImportant,
                                 @RequestParam("status") @Nullable Status status){

       return taskLogic.getAllTask(startTime, deadLine, isImportant,status);
    }
    @PreAuthorize("hasAnyRole('ROLE_admin')")
    @GetMapping("api/task")
    public Task getTask(@RequestParam("id")int id){
        return taskLogic.getTaskById(id);
    }

    @GetMapping("api/employee/tasks")
    @PreAuthorize("hasRole('ROLE_fullTimeEmployee')")
    public List<Task> getTaskWhereSpecialtiesIs(@RequestParam Specialties s){
        return taskLogic.getTaskWhereSpecialtiesIs(s);
    }
}
