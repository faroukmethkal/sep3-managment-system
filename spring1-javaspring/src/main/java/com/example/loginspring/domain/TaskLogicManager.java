package com.example.loginspring.domain;

import model.Specialties;
import model.Status;
import model.Task;
import network.RemoteTask;
import network.RemoteTaskManager;
import org.springframework.stereotype.Service;

import javax.annotation.Nullable;
import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.time.LocalDate;
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
    public List<Task> getAllTask(@Nullable LocalDate startDate, @Nullable LocalDate deadline, @Nullable Boolean isImportant, @Nullable Status status) {

        if (startDate != null && deadline != null) {
            try {
                return server.getAllTaskBetween(startDate,deadline);
            } catch (RemoteException e) {
                e.printStackTrace();
            }
        }

        if (startDate != null) {
            try {
                return server.getAllTaskBetween(startDate, LocalDate.now().plusMonths(3));
            } catch (RemoteException e) {
                e.printStackTrace();
            }
        }
        if (deadline != null) {
            try {
                return server.getAllTaskBetween(LocalDate.now().minusMonths(3),deadline);
            } catch (RemoteException e) {
                e.printStackTrace();
            }
        }
        if (status != null) {
            try {
                return server.getAllTaskWithStatus(status);
            } catch (RemoteException e) {
                e.printStackTrace();
            }
        }
        if (isImportant != null) {

            try {
                return server.getAllTaskBetween(LocalDate.now().minusMonths(3),LocalDate.now().plusDays(2));
            } catch (RemoteException e) {
                e.printStackTrace();
            }
        }
        try {
            return server.getAllTask();
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public Task getTaskById(int taskId) {
        try {
            return server.getTaskById(taskId);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }


}
