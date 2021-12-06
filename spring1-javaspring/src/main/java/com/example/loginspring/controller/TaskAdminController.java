package com.example.loginspring.controller;

import com.example.loginspring.domain.TaskLogic;
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
public class TaskAdminController {
    private TaskLogic taskLogic;

    @Autowired
    public TaskAdminController(TaskLogic taskLogic) {
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

    @PreAuthorize("hasAnyRole('ROLE_admin')")
    @DeleteMapping("api/task")
    public void removeTask(@RequestParam("id")int id){
        System.out.println("Controller remove task with id--->>"+id);
        taskLogic.removeTask(id);
    }

    @PreAuthorize("hasAnyRole('ROLE_admin')")
    @PutMapping("api/task")
    public void editTask(@RequestBody Task task){
        System.out.println("task to edit contoller ->>>>>>>>"+task.toString());
        taskLogic.editTask(task);
    }


}
