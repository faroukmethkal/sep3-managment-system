package database;

import model.Shift;
import model.Status;
import model.Task;

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
    }  }
}
