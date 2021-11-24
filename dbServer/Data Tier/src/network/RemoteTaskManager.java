package network;

import database.TaskDAO;
import database.TaskDAOImpl;
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
}
