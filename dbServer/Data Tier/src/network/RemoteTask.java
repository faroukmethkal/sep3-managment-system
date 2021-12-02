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
  Task getTaskById(int taskId) throws RemoteException;
  void editTask(Task task) throws RemoteException;
  void removeTask(int id) throws RemoteException;
  int getTeamIdByTask(int taskId) throws RemoteException;
  void assignEmployeeToTeam(String username, int teamId) throws RemoteException;
  List<Task> getMyTasks(String username) throws RemoteException;
  List<Task> getMyTasksWhereStatusIs(String username, Status status) throws RemoteException;
}