package network;

import model.Specialties;
import model.Status;
import model.Task;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.util.List;

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
    public List<Task> getTaskWhereSpecialtiesIs(Specialties s)  {
        try {
            return remoteTask.getTaskWhereSpecialtiesIs(s);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
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
    public List<Task> getAllTaskWithStatus(Status status){
        try {
            return remoteTask.getAllTaskWithStatus(status);
        } catch (Exception e) {
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


}
