package com.example.loginspring.domain;

import model.Profile;
import model.Specialties;
import model.Status;
import model.Task;
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
                return remoteTask.getAllTaskBetween(startDate,deadline);
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
                return remoteTask.getAllTaskBetween(LocalDate.now().minusMonths(3),deadline);
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
                return remoteTask.getAllTaskBetween(LocalDate.now().minusMonths(3),LocalDate.now().plusDays(2));
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
    public Map<String, Integer> getSpecialtiesOfTask(int taskId) {
        try {
            return remoteTask.getSpecialtiesOfTask(taskId);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public void editSpecialtiesOfTask(int taskId, Map<String, Integer> specialties)  {
        try {
            remoteTask.editSpecialtiesOfTask(taskId, specialties);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public void removeSpecialtyFromTask(int taskId, Specialties specialty)  {
        try {
            remoteTask.removeSpecialtyFromTask(taskId,specialty);
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
     full time employee
     * */

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
        Specialties s = getSpecialty(username);
        int specialitiesRequired = -1;
        int specialitiesAssigned = -1;
        try {
            teamId =  remoteTask.getTeamIdByTask(taskId);
            specialitiesRequired = remoteTask.numberOfEmpWithSpecialtiesAreRequiredForTask(taskId,s);
            specialitiesAssigned = remoteTask.numberOfEmpAssignedToTaskWithSpecialties(taskId,s);
            if(teamId != -1 && specialitiesAssigned < specialitiesRequired){
                remoteTask.assignEmployeeToTeam(username,teamId);
            }
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }



    @Override
    public List<Task> getMyTasksWhereStatus(String username, @Nullable Status status) {
        if (status != null){
            try {
                return remoteTask.getMyTasksWhereStatusIs(username,status);
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


}
