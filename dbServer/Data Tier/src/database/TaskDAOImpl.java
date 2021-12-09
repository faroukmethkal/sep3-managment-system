package database;

import model.*;

import java.sql.*;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Date;

public class TaskDAOImpl implements TaskDAO
{

/*  private static TaskDAOImpl instance;

  private TaskDAOImpl() throws SQLException
  {
    DriverManager.registerDriver(new org.postgresql.Driver());
  }

  public static synchronized TaskDAOImpl getInstance() throws SQLException
  {
    if (instance == null)
    {
      return instance = new TaskDAOImpl();
    }
    return instance;
  }

  private Connection getConnection() throws SQLException
  {
    return DriverManager.getConnection(
        "jdbc:postgresql://hattie.db.elephantsql.com:5432/bzjrfgwn?currentSchema=sep", //change schema after db is done
        "bzjrfgwn", "ZPXdZD4hJLi7bjSr5foQeqn2ithW6iQV");
  }*/

  @Override public void addTask(Task task)
  {
    try(Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "INSERT INTO task (title, description, startdate, estimatedtime, deadline, status) VALUES (?,?,?,?,?,?)");
      statement.setString(1, task.getTitle());
      statement.setString(2, task.getDescription());
      statement.setDate(3, java.sql.Date.valueOf(task.getStartDate()));
      statement.setDouble(4, task.getEstimatedTime());
      statement.setDate(5, java.sql.Date.valueOf(task.getDeadline()));
      statement.setString(6,task.getStatus().toString());

      statement.executeUpdate();
      task.setId(getLatestId(task.getTitle()));

      addSpecialtiesOfTask(task);

      //prints for test
      System.out.println(task.getTitle());
      System.out.println(task.getDescription());
      System.out.println(task.getStartDate());
      System.out.println(task.getEstimatedTime());
      System.out.println(task.getDeadline());
    }
    catch(SQLException s){
      System.out.println(s+" - Nothing was added to database");
    }
  }

  @Override public Task getTaskById(int id)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT taskid, title, description, startdate, estimatedtime, deadline, status, spenthours FROM task WHERE taskid = ?");

      statement.setInt(1, id);

      ResultSet resultSet = statement.executeQuery();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("taskid");
        String title = resultSet.getString("title");
        String description = resultSet.getString("description");
        LocalDate startDate = resultSet.getDate("startdate").toLocalDate();
        double estimatedTime = resultSet.getDouble("estimatedtime");
        LocalDate deadline = resultSet.getDate("deadline").toLocalDate();
        Status status = Status.valueOf(resultSet.getString("status"));
        double spentHours = resultSet.getDouble("spenthours");

        if(idDB == -1) return null;
        else
        {
          Task toReturn = new Task(title, description,getSpecialtiesOfTask(idDB), startDate, estimatedTime, deadline, status);
          toReturn.setId(idDB);
          toReturn.setSpentHours(spentHours);
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
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("select * from task");

      ResultSet resultSet = statement.executeQuery();

      List<Task> tasks = new ArrayList<Task>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("taskid");
        String title = resultSet.getString("title");
        String description = resultSet.getString("description");
        LocalDate startDate = resultSet.getDate("startdate").toLocalDate();
        double estimatedTime = resultSet.getDouble("estimatedtime");
        LocalDate deadline = resultSet.getDate("deadline").toLocalDate();
        Status status = Status.valueOf(resultSet.getString("status"));
        double spentHours = resultSet.getDouble("spenthours");

        Task task = new Task(title,description,getSpecialtiesOfTask(idDB),startDate,estimatedTime,deadline,status);
        task.setId(idDB);
        task.setSpentHours(spentHours);
        tasks.add(task);
      }
      System.out.println(tasks);
      return tasks;
    }
    catch (SQLException s)
    {
      System.out.println(s+" - returned null");
      return null;
    }
  }

  @Override public Map<String, Integer> getSpecialtiesOfTask(int taskId)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
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
      System.out.println(s+" - getSpecialtiesOfTask method");
    }
    return null;
  }

  /*@Override public void assignTeamToTask(int teamId, int taskId)
  {
    try(Connection connection = ConnectionDB.getInstance().getConnection())
    {
        PreparedStatement statement = connection.prepareStatement(
            "INSERT INTO team (teamid, taskid) VALUES (?,?)");

        statement.setInt(1, teamId);
        statement.setInt(2, taskId);

        statement.executeUpdate();
      }
      //prints for test

    catch(SQLException s){
      System.out.println("SQLException - Nothing was changed to database");
    }
  }*/

  @Override public List<Task> getTasksWhereSpecialtiesIs(Specialties specialty)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT taskid FROM task_speciality WHERE speciality = ?");

      statement.setString(1,specialty.toString());

      ResultSet resultSet = statement.executeQuery();
      List<Task> tasks = new ArrayList<>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("taskid");
        tasks.add(getTaskById(idDB));
      }
      System.out.println(tasks);
      return tasks;
    }
    catch(SQLException s){
      System.out.println(s+" - returned null");
      return null;
    }
  }

  @Override public void setStatusOfTask(int taskId, Status status)
  {
    try(Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "UPDATE task SET status = ? WHERE taskid = ?");

      statement.setString(1, status.toString());
      statement.setInt(2, taskId);

      statement.executeUpdate();
    }
    catch(SQLException s){
      System.out.println(s+" - Nothing was changed to database");
    }
  }

  @Override public List<Task> getTasksWhereStatusIs(Status status)
  {
    try (Connection connection =  ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT taskid FROM task WHERE status = ?");

      statement.setString(1,status.toString());

      ResultSet resultSet = statement.executeQuery();
      List<Task> tasks = new ArrayList<>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("taskid");
        tasks.add(getTaskById(idDB));
      }
      System.out.println(tasks);
      return tasks;
    }
    catch(SQLException s){
      System.out.println(s+" - returned null");
      return null;
    }
  }

  @Override public List<Task> getTasksBetweenDates(LocalDate startDate, LocalDate deadline)
  {
    try (Connection connection =  ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT * from task WHERE startdate >= ? and deadline <= ?");

      statement.setDate(1, java.sql.Date.valueOf(startDate));
      statement.setDate(2, java.sql.Date.valueOf(deadline));

      ResultSet resultSet = statement.executeQuery();
      List<Task> tasks = new ArrayList<>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("taskid");
        tasks.add(getTaskById(idDB));
      }
      System.out.println(tasks);
      return tasks;
    }
    catch(SQLException s){
      System.out.println(s+" - returned null");
      return null;
    }
  }

  @Override public List<Task> getAvailableTasks()
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT * from task t where status = ?");
      statement.setString(1, Status.Created.name()); //today and later

      ResultSet resultSet = statement.executeQuery();

      List<Task> tasks = new ArrayList<Task>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("taskid");
        if(getNumOfAssignedEmployees(idDB) < getNumberOfNeededEmployeesByTask(idDB))
        {
          tasks.add(getTaskById(idDB));
        }
      }
      System.out.println(tasks);
      return tasks;
    }
    catch (SQLException s)
    {
      System.out.println(s+" - returned null");
      return null;
    }
  }

  @Override public List<Task> getFinishedTasks()
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("SELECT * FROM task WHERE status = ?");
      statement.setString(1,Status.Finished.toString());

      ResultSet resultSet = statement.executeQuery();

      List<Task> tasks = new ArrayList<Task>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("taskid");
        String title = resultSet.getString("title");
        String description = resultSet.getString("description");
        LocalDate startDate = resultSet.getDate("startdate").toLocalDate();
        double estimatedTime = resultSet.getDouble("estimatedtime");
        LocalDate deadline = resultSet.getDate("deadline").toLocalDate();
        Status status = Status.valueOf(resultSet.getString("status"));
        double spentHours = resultSet.getDouble("spenthours");

        Task task = new Task(title,description,getSpecialtiesOfTask(idDB),startDate,estimatedTime,deadline,status);
        task.setId(idDB);
        task.setSpentHours(spentHours);
        tasks.add(task);
      }
      System.out.println(tasks);
      return tasks;
    }
    catch (SQLException s)
    {
      System.out.println(s+" - returned null");
      return null;
    }
  }

  @Override public void removeTask(int taskId)
  {
    removeSpecialtiesFromTask(taskId);


    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "DELETE FROM task WHERE taskid = ?");

      statement.setInt(1, taskId);

      statement.executeUpdate();

    }
    catch(SQLException s){
      System.out.println(s);
    }
  }

  @Override public void editTask(Task task) //also change specialties
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "UPDATE task set title = ?,description = ?, startdate = ?, estimatedtime = ?, deadline = ?, status = ?"
              + " WHERE taskid = ?");
      //new data
      statement.setString(1, task.getTitle());
      statement.setString(2, task.getDescription());
      statement.setDate(3, java.sql.Date.valueOf(task.getStartDate()));
      statement.setDouble(4, task.getEstimatedTime());
      statement.setDate(5, java.sql.Date.valueOf(task.getDeadline()));
      statement.setString(6, task.getStatus().toString());
      //old id
      statement.setInt(7, task.getId());

      statement.executeUpdate();

      editSpecialtiesOfTask(task);
    }
    catch(SQLException s){
      System.out.println(s);
    }
  }

  @Override public void editSpecialtiesOfTask(Task task)
  {
    //maybe just use these 2 methods to delete all specialties from task and then add new ones
    //
    removeSpecialtiesFromTask(task.getId());
    addSpecialtiesOfTask(task);
    //--------------------------------------------- or update statement method
    /*try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      for (Object key : specialties.keySet())
      {
        PreparedStatement statement = connection.prepareStatement(
            "UPDATE task_speciality SET speciality = ?, numberofemployees = ? where taskid = ?");
        System.out.println("edit s task ---->>>>"+ key.toString()+"  "+specialties.get(key));

        statement.setString(1, key.toString());
        statement.setInt(2,(int)specialties.get(key));
        statement.setInt(3, taskId);

        statement.executeUpdate();
      }
    }
    catch(SQLException s){
      System.out.println(s);
    }*/
  }

  @Override public void removeSpecialtyFromTask(int taskId, Specialties specialty)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "DELETE from task_speciality where taskid = ? and speciality = ?");

      statement.setInt(1, taskId);
      statement.setString(2, specialty.toString());

      statement.executeUpdate();
    }
    catch(SQLException s){
      System.out.println(s);
    }
  }

  @Override public int getTeamIdByTask(int taskId) //not needed anymore because taskId = teamId
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT teamid FROM team WHERE taskid = ?");

      statement.setInt(1, taskId);

      ResultSet resultSet = statement.executeQuery();

      while (resultSet.next())
      {
        int teamId = resultSet.getInt("teamid");
        return teamId;
      }

    }
    catch(SQLException s){
      System.out.println(s);
    }
    return -1;
  }

  @Override public boolean assignEmployeeToTeam(String username, int teamId)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "INSERT INTO team_mates (username, teamid) VALUES (?,?)");

      statement.setString(1,username);
      statement.setInt(2, teamId);

      statement.executeUpdate();
    }
    catch(SQLException s){
      System.out.println(s);
      return false;
    }
    return true;
  }

  @Override public List<Task> getTasksOfEmployee(String username)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT * from team_mates WHERE username = ?");

      statement.setString(1,username);

      ResultSet resultSet = statement.executeQuery();

      List<Task> tasks = new ArrayList<Task>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("teamid"); // teamId = taskId
        tasks.add(getTaskById(idDB));
      }
      System.out.println(tasks);
      return tasks;
    }
    catch (SQLException s)
    {
      System.out.println(s+" - returned null");
      return null;
    }
  }

  @Override public List<Task> getTasksOfEmployeeWithStatus(String username, Status status) //if not working use join tables
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT * from team_mates WHERE username = ?");

      statement.setString(1,username);
      statement.setString(2,status.toString());

      ResultSet resultSet = statement.executeQuery();

      List<Task> tasks = new ArrayList<Task>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("taskid");
       /* String title = resultSet.getString("title");
        String description = resultSet.getString("description");
        LocalDate startDate = resultSet.getDate("startdate").toLocalDate();
        double estimatedTime = resultSet.getDouble("estimatedtime");
        LocalDate deadline = resultSet.getDate("deadline").toLocalDate();
        Status status1 = Status.valueOf(resultSet.getString("status"));
        double spentHours = resultSet.getDouble("spenthours");

        Task task = new Task(title,description,getSpecialtiesOfTask(idDB),startDate,estimatedTime,deadline,status1);
        task.setId(idDB);
        task.setSpentHours(spentHours);*/
        Task task = getTaskById(idDB);
        if(task.getStatus().equals(status)) //not sure if .equals is correct
        tasks.add(task);
      }
      System.out.println(tasks);
      return tasks;
    }
    catch (SQLException s)
    {
      System.out.println(s+" - returned null");
      return null;
    }
  }

  @Override public boolean assignEmployeeToTask(String username, int taskId) //use this instead of assignEmployeeToTeam()
  {
    try(Connection connection =  ConnectionDB.getInstance().getConnection())
    {
        PreparedStatement statement = connection.prepareStatement(
            "INSERT INTO team_mates (username, teamid) VALUES (?,?)");

        statement.setString(1, username);
        statement.setInt(2, taskId); //teamId = taskId

        statement.executeUpdate();
        return true;
      //prints for test
    }
    catch(SQLException s){
      System.out.println(s+" - Nothing was added to database");
      return false;
    }
  }

  @Override public List<Profile> getAllTeamMembersOfTask(int taskId)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT * from team_mates join profile p on team_mates.username = p.username WHERE teamid = ?");
      statement.setInt(1, taskId); //taskId = teamId

      ResultSet resultSet = statement.executeQuery();

      List<Profile> profiles = new ArrayList<Profile>();

      while (resultSet.next())
      {
        String username = resultSet.getString("username"); //if not working change to "p.username"
        String firstname = resultSet.getString("firstname");
        String lastname = resultSet.getString("lastname");
        LocalDate birthday = resultSet.getDate("birthday").toLocalDate();
        Specialties specialties = Specialties.valueOf(resultSet.getString("speciality"));
        Role role1 = Role.valueOf(resultSet.getString("role"));

        Profile p = new Profile(username,firstname,lastname,specialties,birthday);
        p.setRole(role1);
        System.out.println("from db------->>>"+p.toString());
        profiles.add(p);
      }
      return profiles;
    }
    catch (SQLException s)
    {
      System.out.println(s+ " - returned null");
      return null;
    }
  }

  @Override public void removeEmployeeFromTask(int taskId, String username)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "DELETE FROM team_mates WHERE teamid = ? and username = ?");

      statement.setInt(1, getTeamIdByTask(taskId));
      statement.setString(2, username);

      statement.executeUpdate();
    }
    catch(SQLException s){
      System.out.println(s);
    }
  }

  @Override public void setSpentHoursForTask(int taskId, double spentHours)
  {
    {
      try (Connection connection = ConnectionDB.getInstance().getConnection())
      {
        PreparedStatement statement = connection.prepareStatement(
            "UPDATE task SET spentHours = ? WHERE taskid = ?");

        statement.setDouble(1, spentHours);
        statement.setInt(2, taskId);

        statement.executeUpdate();
      }
      catch (SQLException s)
      {
        System.out.println(s);
      }
    }}

  @Override
  public int getNumberOfEmpAssignedToTaskWithSpecialties(int taskId, Specialties specialty) //not tested
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT count(p.username) FROM team_mates join profile p on p.username = team_mates.username"
              + " WHERE teamid = ? and speciality = ?");

      statement.setInt(1, taskId); //teamId = taskId
      statement.setString(2, specialty.toString());

      ResultSet resultSet = statement.executeQuery();

      while (resultSet.next())
      {
        int numberOfEmployees = resultSet.getInt("count");
        return numberOfEmployees;
      }
    }
    catch (SQLException s)
    {
      System.out.println(s);
    }
    return -1;
  }

  @Override
  public int getNumberOfEmpWithSpecialtiesAreRequiredForTask(int taskId, Specialties specialty) // not tested
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT numberofemployees from task_speciality WHERE taskid = ? and speciality = ?");

      statement.setInt(1, taskId);
      statement.setString(2, specialty.toString());

      ResultSet resultSet = statement.executeQuery();

      while (resultSet.next())
      {
        int numberOfEmployees = resultSet.getInt("numberofemployees");
        return numberOfEmployees;
      }
    }
    catch (SQLException s)
    {
      System.out.println(s);
    }
    return -1;
  }

  private void addSpecialtiesOfTask(Task task)
  {
    try(Connection connection =  ConnectionDB.getInstance().getConnection())
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
      System.out.println(s+" - Nothing was added to database");
    }
  }

  public int getLatestId(String title)
  {
    {
      try (Connection connection =  ConnectionDB.getInstance().getConnection())
      {
        PreparedStatement statement = connection.prepareStatement("select taskid,title from task where title = ? order by taskid desc limit 1");
        statement.setString(1, title);


        ResultSet resultSet = statement.executeQuery();


        if (resultSet.next())
        {
          int id = resultSet.getInt("taskid");
          return id;
        }

      }
      catch (SQLException s)
      {
        System.out.println(s+"(get id method)");
      }
    }
    return -1;
  }

  private void removeSpecialtiesFromTask(int taskId)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "DELETE FROM task_speciality WHERE taskid = ?");

      statement.setInt(1, taskId);

      statement.executeUpdate();

    }
    catch(SQLException s){
      System.out.println(s);
    }
  }

  /*private void addTeam(int taskId)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "INSERT INTO team (taskid) VALUES (?)");

      statement.setInt(1, taskId);

      statement.executeUpdate();

    }
    catch(SQLException s){
      System.out.println(s);
    }
  }*/

  private int getNumberOfNeededEmployeesByTask(int taskId)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT SUM(numberofemployees) FROM task_speciality WHERE taskid = ?");

      statement.setInt(1, taskId);

      ResultSet resultSet = statement.executeQuery();


      while (resultSet.next())
      {
        int total = resultSet.getInt("sum");
        return total;
      }
    }
    catch(SQLException s){
      System.out.println(s);
    }
    return -1;
  }

  private int getNumOfAssignedEmployees(int taskId)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT count(username) from team_mates WHERE teamid = ?");

      statement.setInt(1, taskId);

      ResultSet resultSet = statement.executeQuery();

      while (resultSet.next())
      {
        int total = resultSet.getInt("count");
        return total;
      }
    }
    catch(SQLException s){
      System.out.println(s);
    }
    return -1;
  }
}
