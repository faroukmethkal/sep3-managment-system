package com.example.loginspring.controller;

import com.example.loginspring.domain.TaskLogic;
import model.Specialties;
import model.Task;
import org.springframework.beans.factory.annotation.Autowired;
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

    @GetMapping("api/tasks")
    @PreAuthorize("hasAnyRole('ROLE_admin')")
    public List<Task> getAllTask(@RequestParam @Nullable LocalDate startDate,
                                @RequestParam @Nullable LocalDate deadline,
                                @RequestParam @Nullable Boolean isImportant){
       return taskLogic.getAllTask(startDate, deadline, isImportant);
    }

    @GetMapping("api/employee/tasks")
    @PreAuthorize("hasRole('ROLE_fullTimeEmployee')")
    public List<Task> getTaskWhereSpecialtiesIs(@RequestParam("spec") Specialties specialties){
        return taskLogic.getTaskWhereSpecialtiesIs(specialties);
    }
}
