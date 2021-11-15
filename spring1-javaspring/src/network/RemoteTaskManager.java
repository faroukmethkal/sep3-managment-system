package network;

import model.Specialties;
import model.Task;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.util.List;

public class RemoteTaskManager implements RemoteTask{
   private RemoteTask remoteTask;

    public RemoteTaskManager() throws MalformedURLException, NotBoundException, RemoteException {
        remoteTask = (RemoteTask) Naming.lookup("rmi://localhost:1099/Task");
    }

    @Override
    public void createNewTask(Task task) throws RemoteException {
        remoteTask.createNewTask(task);
    }

    @Override
    public List<Task> getTaskWhereSpecialtiesIs(Specialties s) throws RemoteException {
       return remoteTask.getTaskWhereSpecialtiesIs(s);
    }

    @Override
    public List<Task> getAllTask() throws RemoteException {
       return remoteTask.getAllTask();
    }
}
