package database;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

public class CalendarDAOImpl implements CalendarDAO
{
  @Override public void addEntryToCalendar(String username, LocalDate date)
  {
    try(Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "INSERT INTO Calendar (username, date) VALUES (?,?)");
      statement.setString(1, username);
      statement.setDate(2, java.sql.Date.valueOf(date));

      statement.executeUpdate();
    }
    catch(SQLException s){
      System.out.println(s);
    }
  }

  @Override public List<LocalDate> getDatesOfEmployee(String username)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT date FROM calendar WHERE username = ?");

      statement.setString(1, username);

      ResultSet resultSet = statement.executeQuery();
      List<LocalDate> dates = new ArrayList<>();

      while (resultSet.next())
      {
        LocalDate date = resultSet.getDate("date").toLocalDate();
        dates.add(date);
      }
      return dates;
    }
    catch(SQLException s){
      System.out.println(s);
    }
    return null;
  }
}
