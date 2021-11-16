package database;

import model.*;

import java.sql.*;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class TaskDAOImpl implements TaskDAO
{
  private static TaskDAOImpl instance;

  private TaskDAOImpl() throws SQLException
  {
    DriverManager.registerDriver(new org.postgresql.Driver());
  }

  public static synchronized TaskDAOImpl getInstance() throws SQLException
  {
    if (instance == null)
    {
      instance = new TaskDAOImpl();
    }
    return instance;
  }

  private Connection getConnection() throws SQLException
  {
    return DriverManager.getConnection(
        "jdbc:postgresql://hattie.db.elephantsql.com:5432/bzjrfgwn?currentSchema=sep",
        "bzjrfgwn", "ZPXdZD4hJLi7bjSr5foQeqn2ithW6iQV");
  }

  @Override public void addTask(Task task)
  {
    try(Connection connection = getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "INSERT INTO task (title, description, numberofteam, startdate, estimatedtime, deadline) VALUES (?,?,?,?,?,?)");
      statement.setString(1, task.getTitle());
      statement.setString(2, task.getDescription());
      statement.setInt(3, 0);
      // assuming numberOfTeam is teamId of the responsible team for the task (maybe better solution would be to set default 0 in th DB)
      statement.setDate(4, java.sql.Date.valueOf(task.getStartDate()));
      statement.setDouble(5, task.getEstimatedTime());
      statement.setDate(4, java.sql.Date.valueOf(task.getDeadline()));

      statement.executeUpdate();

      addSpecialtiesOfTask(task);

      //prints for test
      System.out.println(task.getTitle());
      System.out.println(task.getDescription());
      //System.out.println(task.getNumberOfTeam);
      System.out.println(task.getStartDate());
      System.out.println(task.getEstimatedTime());
      System.out.println(task.getDeadline());
    }
    catch(SQLException s){
      System.out.println("SQLException - Nothing was added to database");
    }
  }

  @Override public Task getTaskById(int id)
  {
    try (Connection connection = getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT taskid, title, description, numberofteam, startdate, estimatedtime, deadline FROM task WHERE taskid = ?");

      statement.setInt(1, id);

      ResultSet resultSet = statement.executeQuery();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("taskid");
        String title = resultSet.getString("title");
        String description = resultSet.getString("description");
        int numberOfTeam = resultSet.getInt("numberofteam");
        LocalDate startDate = resultSet.getDate("startdate").toLocalDate();
        double estimatedTime = resultSet.getDouble("estimatedtime");
        LocalDate deadline = resultSet.getDate("deadline").toLocalDate();

        if(idDB == -1) return null;
        else
        {
          Task toReturn = new Task(id, title, description,getSpecialtiesOfTask(idDB), startDate, estimatedTime, deadline);
          //need Map<String, Integer> GetSpecialties(int taskId)
          return toReturn;
        }
      }
    }
    catch(SQLException s){
      System.out.println(s);
    }
    return null;
  }

  @Override public List<Task> getAllTasks()
  {
    try (Connection connection = getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("select * from task");

      ResultSet resultSet = statement.executeQuery();

      List<Task> tasks = new ArrayList<Task>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("taskid");
        String title = resultSet.getString("title");
        String description = resultSet.getString("description");
        int numberOfTeam = resultSet.getInt("numberofteam");
        LocalDate startDate = resultSet.getDate("startdate").toLocalDate();
        double estimatedTime = resultSet.getDouble("estimatedtime");
        LocalDate deadline = resultSet.getDate("deadline").toLocalDate();
        Task task = new Task(idDB,title,description,getSpecialtiesOfTask(idDB),startDate,estimatedTime,deadline);
        tasks.add(task);
      }
      return tasks;
    }
    catch (SQLException s)
    {
      System.out.println("SQLException - returned null");
      return null;
    }
  }

  @Override public Map<String, Integer> getSpecialtiesOfTask(int taskId)
  {
    try (Connection connection = getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT taskid, speciality, numberofemployees FROM task_speciality WHERE taskid = ?");

      statement.setInt(1, taskId);

      ResultSet resultSet = statement.executeQuery();

      Map<String, Integer> specialties = new HashMap<>();

      while (resultSet.next())
      {
        String idDB = resultSet.getString("taskid");
        String specialty = resultSet.getString("speciality");
        int numberOfEmployees = resultSet.getInt("numberofemployees");
        specialties.put(specialty, numberOfEmployees);
      }
      return specialties;
    }
    catch(SQLException s){
      System.out.println(s);
    }
    return null;
  }

  @Override public void assignTeamToTask(int teamId, int taskId)
  {
    try(Connection connection = getConnection())
    {
        PreparedStatement statement = connection.prepareStatement(
            "UPDATE task SET numberofteam = ? where taskid = ?");

        statement.setInt(1, teamId);
        statement.setInt(2, taskId);

        statement.executeUpdate();
      }
      //prints for test

    catch(SQLException s){
      System.out.println("SQLException - Nothing was changed to database");
    }
  }

  @Override public List<Task> getTasksWhereSpecialtiesIs(Specialties specialty)
  {
    try (Connection connection = getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT taskid FROM task_speciality WHERE speciality = ?");

      statement.setString(2,specialty.toString()); //maybe index 1

      ResultSet resultSet = statement.executeQuery();
      List<Task> tasks = new ArrayList<>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("taskid");
        tasks.add(getTaskById(idDB));
      }
      return tasks;
    }
    catch(SQLException s){
      System.out.println(s);
      return null;
    }
  }

  private void addSpecialtiesOfTask(Task task)
  {
    try(Connection connection = getConnection())
    {
      Map map = task.getSpecialties();
      for (Object key: map.keySet())
      {
        PreparedStatement statement = connection.prepareStatement(
            "INSERT INTO task_speciality (taskid, speciality, numberofemployees) VALUES (?,?,?)");

        statement.setInt(1, task.getId());
        statement.setString(2, key.toString());
        statement.setInt(3,(int)map.get(key));

        statement.executeUpdate();
      }
      //prints for test
    }
    catch(SQLException s){
      System.out.println("SQLException - Nothing was added to database");
    }
  }
}
