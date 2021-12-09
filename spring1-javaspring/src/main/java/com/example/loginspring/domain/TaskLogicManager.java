package com.example.loginspring.domain;

import com.example.loginspring.exception.ApiRequestException;
import model.*;
import network.RemoteProfile;
import network.RemoteProfileManager;
import network.RemoteTask;
import network.RemoteTaskManager;
import org.springframework.stereotype.Service;

import javax.annotation.Nullable;
import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@Service
public class TaskLogicManager implements TaskLogic {
    private RemoteTask remoteTask;
    private RemoteProfile remoteProfile;

    public TaskLogicManager() throws MalformedURLException, NotBoundException, RemoteException {
        this.remoteTask = new RemoteTaskManager();
        this.remoteProfile = new RemoteProfileManager();
    }

    @Override
    public void createNewTask(Task task) {
        try {
            remoteTask.createNewTask(task);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }


    @Override
    public List<Task> getAllTask(@Nullable LocalDate startDate, @Nullable LocalDate deadline, @Nullable Boolean isImportant, @Nullable Status status) {

        if (startDate != null && deadline != null) {
            try {
                return remoteTask.getAllTaskBetween(startDate, deadline);
            } catch (RemoteException e) {
                e.printStackTrace();
            }
        }

        if (startDate != null) {
            try {
                return remoteTask.getAllTaskBetween(startDate, LocalDate.now().plusMonths(3));
            } catch (RemoteException e) {
                e.printStackTrace();
            }
        }
        if (deadline != null) {
            try {
                return remoteTask.getAllTaskBetween(LocalDate.now().minusMonths(3), deadline);
            } catch (RemoteException e) {
                e.printStackTrace();
            }
        }
        if (status != null) {
            try {
                return remoteTask.getAllTaskWithStatus(status);
            } catch (RemoteException e) {
                e.printStackTrace();
            }
        }
        if (isImportant != null) {

            try {
                return remoteTask.getAllTaskBetween(LocalDate.now().minusMonths(3), LocalDate.now().plusDays(2));
            } catch (RemoteException e) {
                e.printStackTrace();
            }
        }
        try {
            return remoteTask.getAllTask();
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public Task getTaskById(int taskId) {
        try {
            return remoteTask.getTaskById(taskId);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public void editTask(Task task) {

        try {
            remoteTask.editTask(task);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public void removeTask(int id) {
        try {
            remoteTask.removeTask(id);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }


    @Override
    public List<Profile> getAllTeamMemberForTask(int taskId) {
        try {
            return remoteTask.getAllTeamMemberForTask(taskId);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    /**
     * full time employee
     */

    @Override
    public List<Task> getAllTaskForUsername(String username) {
        try {
            Specialties s = getSpecialty(username);
            return remoteTask.getTaskWhereSpecialtiesIs(s);
        } catch (Exception e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public Specialties getSpecialty(String username) {
        try {
            return remoteProfile.getSpecialty(username);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }


    @Override
    public void assignEmployeeToTask(String username, int taskId) {
        int teamId = -1;
        Specialties userSpecialty = getSpecialty(username);
        int specialitiesRequired = -1;
        int specialitiesAssigned = -1;
        Role role = null;
        boolean flag = false;
        try {
            /**
             * check if the employee's spec among task spec
             * */
            try {
                role = remoteProfile.login(username).getRole();
            }catch (Exception e){
                throw new IllegalArgumentException(e.getMessage());
            }
            if (!role.equals(Role.fullTimeEmployee)){
                throw new IllegalArgumentException("Only full time employee can be assigned to task");
            }

            teamId = remoteTask.getTeamIdByTask(taskId);
            if (teamId == -1){
                throw new IllegalArgumentException("No team has been found for task");
            }

            specialitiesRequired = remoteTask.numberOfEmpWithSpecialtiesAreRequiredForTask(taskId, userSpecialty);
            specialitiesAssigned = remoteTask.numberOfEmpAssignedToTaskWithSpecialties(taskId, userSpecialty);
            List<Task> tasks = remoteTask.getTaskWhereSpecialtiesIs(userSpecialty);
            for (Task task : tasks) {
                if (task.getId() == taskId) {
                  flag = true;
                }
            }
            if (!flag){
                throw new IllegalArgumentException("Employee specialties isn't required for this task");
            }

            if(specialitiesAssigned >= specialitiesRequired){
                    throw new IllegalArgumentException("Task has all required number of Employee Specialty: "+userSpecialty);
                }
               if(!remoteTask.assignEmployeeToTeam(username, teamId)){
                   throw new IllegalArgumentException("Couldn't assign employee to task");
               }


        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }


    @Override
    public List<Task> getMyTasksWhereStatus(String username, @Nullable Status status) {
        if (status != null) {
            try {
                return remoteTask.getMyTasksWhereStatusIs(username, status);
            } catch (RemoteException e) {
                e.printStackTrace();
            }
        }

        try {
            return remoteTask.getMyTasks(username);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public void setStatusOfTask(int taskId, Status status) {
        try {
            remoteTask.setStatusOfTask(taskId, status);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public void removeEmployeeFromTask(int taskId, String username) {
        try {
            remoteTask.removeEmployeeFromTask(taskId, username);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public void increaseSpentHoursInTaskBy(int taskId, double spentHours) {
        try {
            remoteTask.increaseSpentHoursInTaskBy(taskId, spentHours);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public List<Task> getAvailableTask() {
        List<Task> list = new ArrayList<>();
        List<Task> criticalTasks = new ArrayList<>();
        try {
            list = remoteTask.getAvailableTasks();
        } catch (Exception e) {
           throw new ApiRequestException(e.getMessage());
        }

        for (Task task : list) {
            if (task.getDeadline().isBefore(LocalDate.now().plusDays(5))) criticalTasks.add(task);
        }

        return criticalTasks;
    }


}
