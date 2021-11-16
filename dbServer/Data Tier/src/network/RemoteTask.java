package network;

import model.Specialties;
import model.Task;

import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.List;

public interface RemoteTask extends Remote {
  public void createNewTask(Task task) throws RemoteException;
  List<Task> getTaskWhereSpecialtiesIs(Specialties s) throws RemoteException;
  List<Task> getAllTask()throws RemoteException;
}