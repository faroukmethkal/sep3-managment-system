package network;

import model.Specialties;
import model.Status;
import model.Task;

import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.util.List;

public interface RemoteTask extends Remote {
    void createNewTask(Task task) throws RemoteException;
    List<Task> getTaskWhereSpecialtiesIs(Specialties s) throws RemoteException;
    List<Task> getAllTask()throws RemoteException;
    List<Task> getAllTaskBetween(LocalDate start, LocalDate deadline)throws RemoteException;
    List<Task> getAllTaskWithStatus(Status status)throws RemoteException;

}
