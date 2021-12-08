package network;

import database.TaskDAO;
import database.TaskDAOImpl;
import model.Profile;
import model.Specialties;
import model.Status;
import model.Task;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.SQLException;
import java.time.LocalDate;
import java.util.List;
import java.util.Map;

public class RemoteTaskManager implements RemoteTask
{
  private TaskDAO taskDB;


  public RemoteTaskManager()
      throws SQLException, MalformedURLException, RemoteException
  {
    startServer();
    taskDB = new TaskDAOImpl();
  }

  private void startServer() throws RemoteException, MalformedURLException
  {
    UnicastRemoteObject.exportObject(this, 0);
    Naming.rebind("Task", this);
    System.out.println("Task Server started...");
  }

  @Override public void createNewTask(Task task) throws RemoteException //change to addNewTask ?
  {
    taskDB.addTask(task);
  }

  @Override public List<Task> getTaskWhereSpecialtiesIs(Specialties s)// change to get TasksWhereSpecialtyIs ?
      throws RemoteException
  {
    return taskDB.getTasksWhereSpecialtiesIs(s);
  }

  @Override public List<Task> getAllTask() throws RemoteException //change to getAllTasks ?
  {
    return taskDB.getAllTasks();
  }

  @Override
  public List<Task> getAllTaskBetween(LocalDate start, LocalDate deadline) throws RemoteException {
    return taskDB.getTasksBetweenDates(start, deadline);
  }

  @Override
  public List<Task> getAllTaskWithStatus(Status status) throws RemoteException {
    return taskDB.getTasksWhereStatusIs(status);
  }

  @Override public List<Task> getAvailableTasks() throws RemoteException
  {
    return taskDB.getAvailableTasks();
  }

  @Override public List<Task> getFinishedTasks() throws RemoteException
  {
    return taskDB.getFinishedTasks();
  }

  @Override
  public Task getTaskById(int taskId) throws RemoteException {
    return taskDB.getTaskById(taskId);
  }

  @Override
  public void editTask(Task task) throws RemoteException {
    taskDB.editTask(task);
  }

  @Override
  public void removeTask(int id) throws RemoteException {
    taskDB.removeTask(id);
  }

  @Override public int getTeamIdByTask(int taskId) throws RemoteException
  {
    return taskDB.getTeamIdByTask(taskId);
  }

  @Override public boolean assignEmployeeToTeam(String username, int teamId)
      throws RemoteException
  {
    return taskDB.assignEmployeeToTeam(username, teamId);
  }

  @Override public List<Task> getMyTasks(String username) throws RemoteException
  {
    return taskDB.getTasksOfEmployee(username);
  }

  @Override public List<Task> getMyTasksWhereStatusIs(String username, Status status)
      throws RemoteException
  {
    return taskDB.getTasksOfEmployeeWithStatus(username, status);
  }

  @Override public void setStatusOfTask(int taskId, Status status)
      throws RemoteException
  {
    taskDB.setStatusOfTask(taskId, status);
  }

  @Override public void removeEmployeeFromTask(int taskId, String username)
      throws RemoteException
  {
    taskDB.removeEmployeeFromTask(taskId, username);
  }

  @Override public void setSpentHoursForTask(int taskId, double spentHours)
      throws RemoteException
  {
    taskDB.setSpentHoursForTask(taskId, spentHours);
  }

  @Override public void increaseSpentHoursInTaskBy(int taskId, double spentHours)
  {
    double setTo = taskDB.getTaskById(taskId).getSpentHours() + spentHours;
    taskDB.setSpentHoursForTask(taskId, setTo);
  }

  @Override
  public Map<String, Integer> getSpecialtiesOfTask(int taskId) throws RemoteException {
    return taskDB.getSpecialtiesOfTask(taskId);
  }

  /*@Override
  public void editSpecialtiesOfTask(int taskId, Map<String, Integer> specialties) throws RemoteException {
    taskDB.editSpecialtiesOfTask(taskId, specialties);
  }*/

  @Override
  public void removeSpecialtyFromTask(int taskId,  Specialties specialty) throws RemoteException {
    taskDB.removeSpecialtyFromTask(taskId, specialty);
  }

  @Override
  public List<Profile> getAllTeamMemberForTask(int taskId) throws RemoteException {
    return taskDB.getAllTeamMembersOfTask(taskId);
  }

  @Override
  public int numberOfEmpAssignedToTaskWithSpecialties(int taskId, Specialties s) throws RemoteException {
    return taskDB.getNumberOfEmpAssignedToTaskWithSpecialties(taskId, s);
  }

  @Override
  public int numberOfEmpWithSpecialtiesAreRequiredForTask(int taskId, Specialties s) throws RemoteException {
    return taskDB.getNumberOfEmpWithSpecialtiesAreRequiredForTask(taskId, s);
  }


}
