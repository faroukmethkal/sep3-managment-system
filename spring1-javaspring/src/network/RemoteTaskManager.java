package network;

import model.Profile;
import model.Specialties;
import model.Status;
import model.Task;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.util.List;
import java.util.Map;

public class RemoteTaskManager implements RemoteTask{
   private RemoteTask remoteTask;

    public RemoteTaskManager() throws MalformedURLException, NotBoundException, RemoteException {
        remoteTask = (RemoteTask) Naming.lookup("rmi://localhost:1099/Task");
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
    public List<Task> getAllTask()  {
        try {
            return remoteTask.getAllTask();
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public List<Task> getAllTaskBetween(LocalDate start, LocalDate deadline){
        try {
            return remoteTask.getAllTaskBetween(start,deadline);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public List<Task> getAvailableTask() throws RemoteException {
        return remoteTask.getAvailableTask();
    }

    @Override
    public List<Task> getAllTaskWithStatus(Status status){
        try {
            return remoteTask.getAllTaskWithStatus(status);
        } catch (Exception e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public List<Task> getFinishedTasks() {
        try {
            return remoteTask.getFinishedTasks();
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

    /**
     full time employee
     **/

    @Override
    public List<Task> getTaskWhereSpecialtiesIs(Specialties s)  {
        try {
            return remoteTask.getTaskWhereSpecialtiesIs(s);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public int getTeamIdByTask(int id) {
        try {
            return remoteTask.getTeamIdByTask(id);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return -1;
    }

    @Override
    public void assignEmployeeToTeam(String username, int teamId){
        try {
            remoteTask.assignEmployeeToTeam(username,teamId);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public List<Task> getMyTasks(String username){
        try {
            return remoteTask.getMyTasks(username);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        return null;
    }

    @Override
    public List<Task> getMyTasksWhereStatusIs(String username, Status status){
        try {
            return remoteTask.getMyTasksWhereStatusIs(username,status);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public void setStatusOfTask(int taskId, Status status){
        try {
            remoteTask.setStatusOfTask(taskId, status);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public void removeEmployeeFromTask(int taskId, String username)  {
        try {
            remoteTask.removeEmployeeFromTask(taskId, username);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public void setSpentHoursForTask(int taskId, double spentHours) {
        try {
            remoteTask.setSpentHoursForTask(taskId, spentHours);
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
    public Map<String, Integer> getSpecialtiesOfTask(int taskId) {
        try {
            return remoteTask.getSpecialtiesOfTask(taskId);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
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

    @Override
    public int numberOfEmpAssignedToTaskWithSpecialties(int taskId, Specialties s)  {
        try {
            return remoteTask.numberOfEmpAssignedToTaskWithSpecialties(taskId, s);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return -1;
    }

    @Override
    public int numberOfEmpWithSpecialtiesAreRequiredForTask(int taskId, Specialties s)  {
        try {
            return remoteTask.numberOfEmpWithSpecialtiesAreRequiredForTask(taskId, s);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return -1;
    }


}
