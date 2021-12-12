package database;

import model.Profile;
import model.Role;
import model.Shift;
import model.Specialties;

import java.sql.*;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.ArrayList;
import java.util.List;

public class ShiftDAOImpl implements ShiftDAO
{



  @Override public void addShift(Shift shift)
  {
    try(Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "INSERT INTO shift (name, starttime, endtime, description, numberofemployees, date) VALUES (?,?,?,?,?,?)");
      statement.setString(1, shift.getName());
      statement.setTime(2, Time.valueOf(shift.getStartTime()));
      statement.setTime(3, Time.valueOf(shift.getEndTime()));
      statement.setString(4, shift.getDescription());
      statement.setInt(5,shift.getNumberOfEmployees());
      statement.setDate(6, Date.valueOf(shift.getDate()));

      statement.executeUpdate();

      //prints for test
      System.out.println(shift.getName());
      System.out.println(shift.getStartTime());
      System.out.println(shift.getEndTime());
      System.out.println(shift.getDescription());
      System.out.println(shift.getNumberOfEmployees());
      System.out.println(shift.getDate());
    }
    catch(SQLException s){
      System.out.println(s+" - Nothing was added to database");
    }
  }

  @Override public List<Shift> getAllShifts()
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("select * from shift");

      ResultSet resultSet = statement.executeQuery();

      List<Shift> shifts = new ArrayList<Shift>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("shiftid");
        String name = resultSet.getString("name");
        LocalTime startTime = resultSet.getTime("starttime").toLocalTime();
        LocalTime endTime = resultSet.getTime("endtime").toLocalTime();
        String description = resultSet.getString("description");
        int numberOfEmployees = resultSet.getInt("numberofemployees");
        LocalDate date = resultSet.getDate("date").toLocalDate();
        Shift shift = new Shift(name, date, startTime, endTime, description, numberOfEmployees);
        shift.setId(idDB);
        shifts.add(shift);
      }
      System.out.println(shifts);
      return shifts;
    }
    catch (SQLException s)
    {
      System.out.println(s+" - returned null");
      return null;
    }
  }

  @Override public void removeShift(int shiftId)
  {
    removeShiftIdFromAssignedEmployee(shiftId);
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "DELETE FROM shift WHERE shiftid = ?");

      statement.setInt(1, shiftId);

      statement.executeUpdate();

    }
    catch(SQLException s){
      System.out.println(s);
    }
  }
  private void removeShiftIdFromAssignedEmployee(int shiftId)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
              "DELETE FROM assigned_employees WHERE shiftID = ?");

      statement.setInt(1, shiftId);

      statement.executeUpdate();

    }
    catch(SQLException s){
      System.out.println(s);
    }
  }

  @Override public void editShift(Shift shift)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "UPDATE shift set name = ?,starttime = ?, endtime = ?, description = ?, numberofemployees = ?, date = ?"
              + " WHERE shiftid = ?");
      //new data
      statement.setString(1, shift.getName());
      statement.setTime(2, Time.valueOf(shift.getStartTime()));
      statement.setTime(3, Time.valueOf(shift.getEndTime()));
      statement.setString(4,shift.getDescription());
      statement.setInt(5, shift.getNumberOfEmployees());
      statement.setDate(6, Date.valueOf(shift.getDate()));
      //old id
      statement.setInt(7, shift.getId());

      statement.executeUpdate();
    }
    catch(SQLException s){
      System.out.println(s);
    }
  }

  @Override
  public Shift getShiftById(int shiftId) {
      try (Connection connection = ConnectionDB.getInstance().getConnection())
      {
        PreparedStatement statement = connection.prepareStatement(
                "SELECT * FROM shift WHERE shiftid = ?");

        statement.setInt(1, shiftId);

        ResultSet resultSet = statement.executeQuery();

        while (resultSet.next())
        {
          int idDB = resultSet.getInt("shiftid");
          String name = resultSet.getString("name");
          LocalTime startTime = resultSet.getTime("starttime").toLocalTime();
          LocalTime endTime = resultSet.getTime("endtime").toLocalTime();
          String description = resultSet.getString("description");
          int numberOfEmployees = resultSet.getInt("numberofemployees");
          LocalDate date = resultSet.getDate("date").toLocalDate();

          if(idDB == -1) return null;
          else
          {
            Shift shift = new Shift(name, date, startTime, endTime, description, numberOfEmployees);
            shift.setId(idDB);
            return shift;
          }
        }
      }
      catch(SQLException s){
        System.out.println(s);
      }
      return null;
    }

  @Override public List<Shift> getAvailableShifts(LocalDate date)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT * from shift s where date <= ? and "
              + "(SELECT count(username) from assigned_employees where shiftID = s.shiftID) < s.numberofemployees");

      statement.setDate(1, Date.valueOf(date));

      ResultSet resultSet = statement.executeQuery();

      List<Shift> shifts = new ArrayList<Shift>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("shiftid");
        String name = resultSet.getString("name");
        LocalTime startTime = resultSet.getTime("starttime").toLocalTime();
        LocalTime endTime = resultSet.getTime("endtime").toLocalTime();
        String description = resultSet.getString("description");
        int numberOfEmployees = resultSet.getInt("numberofemployees");
        LocalDate date1 = resultSet.getDate("date").toLocalDate();
        Shift shift = new Shift(name, date1, startTime, endTime, description, numberOfEmployees);
        shift.setId(idDB);
        shifts.add(shift);
      }
      System.out.println(shifts);
      return shifts;
    }
    catch (SQLException s)
    {
      System.out.println(s+" - returned null");
      return null;
    }
  }

  @Override public void assignEmployeeToShift(int shiftId, String username)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "INSERT INTO assigned_employees (shiftid, username) VALUES (?,?)");

      statement.setInt(1, shiftId);
      statement.setString(2, username);

      statement.executeUpdate();
    }
    catch(SQLException s){
      System.out.println(s);
    }
  }

  @Override public void removeEmployeeFromShift(int shiftId, String username)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "DELETE FROM assigned_employees where shiftid = ? and username = ?");

      statement.setInt(1, shiftId);
      statement.setString(2, username);

      statement.executeUpdate();
    }
    catch(SQLException s){
      System.out.println(s);
    }
  }
  /**
   PreparedStatement statement = connection.prepareStatement(
   "SELECT * from team_mates t join profile p on t.username = p.username join account a on a.username = t.username  WHERE teamid = ?");
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
   * */

  @Override public List<Profile> getAssignedEmployeesToShift(int shiftId)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("SELECT * from assigned_employees assignment join profile p on" +
              " assignment.username = p.username join account a on a.username = assignment.username  WHERE shiftid = ?");

      statement.setInt(1, shiftId);

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
        System.out.println("from db employee assigned to shift ------->>>"+p.toString());
        profiles.add(p);
      }
      return profiles;
    }
    catch (SQLException s)
    {
      System.out.println(s + " - returned null");
      return null;
    }
  }

  @Override
  public int getNumAssignedEmployeesToShift(int shiftId) {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("SELECT count(username) from assigned_employees WHERE shiftid = ?");

      statement.setInt(1, shiftId);

      ResultSet resultSet = statement.executeQuery();



      if (resultSet.next())
      {
        int count = resultSet.getInt("count");
        return count;
      }
    }
    catch (SQLException s)
    {
      System.out.println(s + " - returned null");
    }
    return -1;

  }

  @Override public List<Shift> getShiftsOfEmployee(String username)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("select * from assigned_employees WHERE username = ?");

      statement.setString(1, username);

      ResultSet resultSet = statement.executeQuery();

      List<Shift> shifts = new ArrayList<Shift>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("shiftid");
        shifts.add(getShiftById(idDB));
      }
      System.out.println(shifts);
      return shifts;
    }
    catch (SQLException s)
    {
      System.out.println(s + " - returned null");
      return null;
    }
  }

  @Override public List<Shift> getShiftsStartingAtDate(LocalDate date) //exact date or date+later ?
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("select * from shift WHERE date = ?");

      statement.setDate(1, Date.valueOf(date));

      ResultSet resultSet = statement.executeQuery();

      List<Shift> shifts = new ArrayList<Shift>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("shiftid");
        String name = resultSet.getString("name");
        LocalTime startTime = resultSet.getTime("starttime").toLocalTime();
        LocalTime endTime = resultSet.getTime("endtime").toLocalTime();
        String description = resultSet.getString("description");
        int numberOfEmployees = resultSet.getInt("numberofemployees");
        LocalDate date1 = resultSet.getDate("date").toLocalDate();
        Shift shift = new Shift(name, date1, startTime, endTime, description, numberOfEmployees);
        shift.setId(idDB);
        shifts.add(shift);
      }
      System.out.println(shifts);
      return shifts;
    }
    catch (SQLException s)
    {
      System.out.println(s + " - returned null");
      return null;
    }
  }

  @Override public List<Shift> getShiftsStartingAtTime(LocalTime time) //exact time or time+later ?
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("select * from shift WHERE starttime = ?");
      statement.setTime(1, Time.valueOf(time));

      ResultSet resultSet = statement.executeQuery();

      List<Shift> shifts = new ArrayList<Shift>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("shiftid");
        String name = resultSet.getString("name");
        LocalTime startTime = resultSet.getTime("starttime").toLocalTime();
        LocalTime endTime = resultSet.getTime("endtime").toLocalTime();
        String description = resultSet.getString("description");
        int numberOfEmployees = resultSet.getInt("numberofemployees");
        LocalDate date = resultSet.getDate("date").toLocalDate();
        Shift shift = new Shift(name, date, startTime, endTime, description, numberOfEmployees);
        shift.setId(idDB);
        shifts.add(shift);
      }
      System.out.println(shifts);
      return shifts;
    }
    catch (SQLException s)
    {
      System.out.println(s+" - returned null");
      return null;
    }
  }

  @Override public List<Shift> getShiftsBetweenTime(LocalTime startTime, LocalTime endTime)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("SELECT * from shift where starttime >= ? and endtime <= ?");

      statement.setTime(1, Time.valueOf(startTime));
      statement.setTime(1, Time.valueOf(endTime));

      ResultSet resultSet = statement.executeQuery();

      List<Shift> shifts = new ArrayList<Shift>();

      while (resultSet.next())
      {
        int idDB = resultSet.getInt("shiftid");
        String name = resultSet.getString("name");
        LocalTime startTime1 = resultSet.getTime("starttime").toLocalTime();
        LocalTime endTime1 = resultSet.getTime("endtime").toLocalTime();
        String description = resultSet.getString("description");
        int numberOfEmployees = resultSet.getInt("numberofemployees");
        LocalDate date = resultSet.getDate("date").toLocalDate();
        Shift shift = new Shift(name, date, startTime1, endTime1, description, numberOfEmployees);
        shift.setId(idDB);
        shifts.add(shift);
      }
      System.out.println(shifts);
      return shifts;
    }
    catch (SQLException s)
    {
      System.out.println(s + " - returned null");
      return null;
    }
  }
  @Override public int getLatestId(String shiftName)
  {
    {
      try (Connection connection =  ConnectionDB.getInstance().getConnection())
      {
        PreparedStatement statement = connection.prepareStatement("select * from shift where name = ? order by shiftid desc limit 1");
        statement.setString(1, shiftName);


        ResultSet resultSet = statement.executeQuery();


        if (resultSet.next())
        {
          int id = resultSet.getInt("shiftid");
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
}

