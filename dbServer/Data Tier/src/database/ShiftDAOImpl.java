package database;

import model.*;

import java.sql.*;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.ArrayList;
import java.util.List;

public class ShiftDAOImpl implements ShiftDAO
{

/*  private static ShiftDAOImpl instance;

  private ShiftDAOImpl() throws SQLException
  {
    DriverManager.registerDriver(new org.postgresql.Driver());
  }

  public static synchronized ShiftDAOImpl getInstance() throws SQLException
  {
    if (instance == null)
    {
      return instance = new ShiftDAOImpl();
    }
    return instance;
  }

  private Connection getConnection() throws SQLException
  {
    return DriverManager.getConnection(
        "jdbc:postgresql://hattie.db.elephantsql.com:5432/bzjrfgwn?currentSchema=sep", //change schema after db is done
        "bzjrfgwn", "ZPXdZD4hJLi7bjSr5foQeqn2ithW6iQV");
  }*/

  @Override public void addShift(Shift shift)
  {
    try(Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "INSERT INTO shift (name, starttime, endtime, description, numberofemployees, date) VALUES (?,?,?,?,?,?)");
      statement.setString(1, shift.getName());
      statement.setTime(2, java.sql.Time.valueOf(shift.getStartTime()));
      statement.setTime(3, java.sql.Time.valueOf(shift.getEndTime()));
      statement.setString(4, shift.getDescription());
      statement.setInt(5,shift.getNumberOfEmployees());
      statement.setDate(6, java.sql.Date.valueOf(shift.getDate()));

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

  @Override public void editShift(Shift shift)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "UPDATE shift set name = ?,starttime = ?, endtime = ?, description = ?, numberofemployees = ?, date = ?"
              + " WHERE shiftid = ?");
      //new data
      statement.setString(1, shift.getName());
      statement.setTime(2, java.sql.Time.valueOf(shift.getStartTime()));
      statement.setTime(3, java.sql.Time.valueOf(shift.getEndTime()));
      statement.setString(4,shift.getDescription());
      statement.setInt(5, shift.getNumberOfEmployees());
      statement.setDate(6,java.sql.Date.valueOf(shift.getDate()));
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
          "SELECT * from shift where date >= ? and "
              + "(SELECT count(username) from assigned_employees group by assigned_employees.shiftid) < numberofemployees");

      statement.setDate(1, java.sql.Date.valueOf(date));

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

  @Override public List<Shift> getShiftsStartingAtDate(LocalDate date) //exact date or date+later ?
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("select * from shift WHERE date = ?");

      statement.setDate(1, java.sql.Date.valueOf(date));

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

      statement.setTime(1, java.sql.Time.valueOf(startTime));
      statement.setTime(1, java.sql.Time.valueOf(endTime));

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
}

