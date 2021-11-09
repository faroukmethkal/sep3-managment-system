package database;

import model.Account;
import model.Profile;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.*;
import java.time.LocalDate;

public class ProfileDAOImpl implements ProfileDAO
{
  private static ProfileDAOImpl instance;

  private ProfileDAOImpl() throws SQLException
  {
    DriverManager.registerDriver(new org.postgresql.Driver());
  }

  public static synchronized ProfileDAOImpl getInstance() throws SQLException
  {
    if (instance == null)
    {
      instance = new ProfileDAOImpl();
    }
    return instance;
  }

  private Connection getConnection() throws SQLException
  {
    return DriverManager.getConnection(
        "jdbc:postgresql://hattie.db.elephantsql.com:5432/bzjrfgwn?currentSchema=sep",
        "bzjrfgwn", "ZPXdZD4hJLi7bjSr5foQeqn2ithW6iQV");
  }

  @Override public void AddProfile(Profile profile)
  {
      try(Connection connection = getConnection())
      {
        PreparedStatement statement = connection.prepareStatement(
            "INSERT INTO Profile (username, firstname, lastname, birthday, speciality) VALUES (?,?,?,?,?)");
        statement.setString(1, profile.getUsername());
        statement.setString(2, profile.getFirstName());
        statement.setString(3, profile.getLastName());
        statement.setDate(4, java.sql.Date.valueOf(profile.getBirthday()));
        statement.setString(5, profile.getSpecialties().toString());

        statement.executeUpdate();

        //prints for test
        System.out.println(profile.getUsername());
        System.out.println(profile.getFirstName());
        System.out.println(profile.getLastName());
        System.out.println(java.sql.Date.valueOf(profile.getBirthday()));
        System.out.println(profile.getSpecialties().toString());
      }
      catch(SQLException s){}

  }
}
