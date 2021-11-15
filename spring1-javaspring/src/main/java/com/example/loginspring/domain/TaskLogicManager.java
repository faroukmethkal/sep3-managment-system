package com.example.loginspring.domain;

import model.Specialties;
import model.Task;
import network.RemoteTask;
import network.RemoteTaskManager;
import org.springframework.stereotype.Service;

import javax.annotation.Nullable;
import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

@Service
public class TaskLogicManager implements TaskLogic {
    private RemoteTask server;

    public TaskLogicManager() throws MalformedURLException, NotBoundException, RemoteException {
        this.server = new RemoteTaskManager();
    }

    @Override
    public void createNewTask(Task task) {
        try {
            server.createNewTask(task);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public List<Task> getTaskWhereSpecialtiesIs(Specialties s) {
        try {
            return server.getTaskWhereSpecialtiesIs(s);
        } catch (Exception e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public List<Task> getAllTask(@Nullable LocalDate startDate, @Nullable LocalDate deadline, @Nullable Boolean isImportant) {
        List<Task> newTask = new ArrayList<>();
        List<Task> allTask = new ArrayList<>();

        try {
            allTask = server.getAllTask();

        } catch (Exception e) {
            e.printStackTrace();
        }
        if (startDate != null && deadline != null && isImportant != null) {
            for (Task task : allTask) {
                if (task.getDeadline().isBefore(deadline) && task.getStartDate().isAfter(startDate) && task.getEstimatedTime() >= 50) {
                    newTask.add(task);
                }
                return newTask;
            }
        }
        if (startDate != null && deadline != null) {
            for (Task task : allTask) {
                if (task.getDeadline().isBefore(deadline) && task.getStartDate().isAfter(startDate)) {
                    newTask.add(task);
                }
                return newTask;
            }
        }
        if (isImportant != null) {
            for (Task task : allTask) {
                if (task.getEstimatedTime() >= 50) {
                    newTask.add(task);
                }
                return newTask;
            }

        }
        return allTask;
    }
}
