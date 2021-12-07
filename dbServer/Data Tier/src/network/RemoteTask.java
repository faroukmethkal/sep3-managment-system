package network;

import model.Profile;
import model.Specialties;
import model.Status;
import model.Task;

import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.util.List;
import java.util.Map;

public interface RemoteTask extends Remote {
  void createNewTask(Task task) throws RemoteException;
  List<Task> getTaskWhereSpecialtiesIs(Specialties s) throws RemoteException;
  List<Task> getAllTask()throws RemoteException;
  List<Task> getAllTaskBetween(LocalDate start, LocalDate deadline)throws RemoteException;
  List<Task> getAllTaskWithStatus(Status status)throws RemoteException;
  List<Task> getFinishedTasks() throws RemoteException;
  Task getTaskById(int taskId) throws RemoteException;
  void editTask(Task task) throws RemoteException;
  void removeTask(int id) throws RemoteException;
  int getTeamIdByTask(int taskId) throws RemoteException;
  void assignEmployeeToTeam(String username, int teamId) throws RemoteException;
  List<Task> getMyTasks(String username) throws RemoteException;
  List<Task> getMyTasksWhereStatusIs(String username, Status status) throws RemoteException;
  void setStatusOfTask(int taskId, Status status) throws RemoteException;
  void removeEmployeeFromTask(int taskId, String username) throws RemoteException;

  /**
   TODO edit task's especialties
   */
  Map<String,Integer> getSpecialtiesOfTask(int taskId) throws RemoteException;
  // maybe don't need editSpecialtiesOfTask() in remote because I edit specialties while calling method editTask()
 // void editSpecialtiesOfTask(int taskId, Map<String, Integer> specialties) throws RemoteException;
  //idk why we would ever just delete specialties from task
  void removeSpecialtyFromTask(int taskId, Specialties specialty) throws RemoteException;

  List<Profile> getAllTeamMemberForTask(int taskId) throws RemoteException;

  /**
   * these two method required to validate if user can be assigned to task or not
   * the validation done in logic tier
   * */
  int numberOfEmpAssignedToTaskWithSpecialties(int taskId, Specialties s) throws RemoteException;
  int numberOfEmpWithSpecialtiesAreRequiredForTask(int taskId, Specialties s) throws RemoteException;

}