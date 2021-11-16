package network;

import database.TaskDAO;
import database.TaskDAOImpl;
import model.Specialties;
import model.Task;

import java.rmi.RemoteException;
import java.sql.SQLException;
import java.util.List;

public class RemoteTaskManager implements RemoteTask
{
  TaskDAO taskDB = TaskDAOImpl.getInstance();

  public RemoteTaskManager() throws SQLException
  {
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
}
