package database;

import model.Account;
import model.Profile;
import model.Role;
import model.Specialties;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.*;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

public class ProfileDAOImpl implements ProfileDAO
{

/*  private static ProfileDAOImpl instance;

  private ProfileDAOImpl() throws SQLException
  {
    DriverManager.registerDriver(new org.postgresql.Driver());
  }

  public static synchronized ProfileDAOImpl getInstance() throws SQLException
  {
    if (instance == null)
    {
      return instance = new ProfileDAOImpl();
    }
    return instance;
  }

  private Connection getConnection() throws SQLException
  {
    return DriverManager.getConnection(
        "jdbc:postgresql://hattie.db.elephantsql.com:5432/bzjrfgwn?currentSchema=sep", //change schema after db is done
        "bzjrfgwn", "ZPXdZD4hJLi7bjSr5foQeqn2ithW6iQV");
  }*/

  @Override public void AddProfile(Profile profile)
  {

      try(Connection connection = ConnectionDB.getInstance().getConnection())
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
      catch(SQLException s){
        System.out.println("SQLException - Nothing was added to database");
      }

  }

  @Override public List<Profile> getAllProfiles()
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("SELECT * FROM profile JOIN account a on a.username = profile.username");

      ResultSet resultSet = statement.executeQuery();

      List<Profile> profiles = new ArrayList<Profile>();

          while (resultSet.next())
          {
            String username = resultSet.getString("username");
            String firstname = resultSet.getString("firstname");
            String lastname = resultSet.getString("lastname");
            LocalDate birthday = resultSet.getDate("birthday").toLocalDate();
            Specialties specialties = Specialties.valueOf(resultSet.getString("Speciality"));
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
      System.out.println("SQLException - returned null");
      return null;
    }
  }

  @Override public Specialties getSpecialtyByUsername(String username)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT speciality FROM profile WHERE username = ?");

      statement.setString(1, username);

      ResultSet resultSet = statement.executeQuery();

      while (resultSet.next())
      {
        String specialty = resultSet.getString("Speciality");

        if(specialty == null) return null;
        else
        {
          return Specialties.valueOf(specialty);
        }
      }
    }
    catch(SQLException s){
      System.out.println(s);
    }
    return null;
  }

  @Override public List<Profile> getProfilesByRole(Role role)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      //first - get accounts by role
      PreparedStatement statement = connection.prepareStatement(
          "SELECT * FROM profile JOIN account a on a.username = profile.username WHERE role = ?");

      statement.setString(1,role.toString());

      ResultSet resultSet = statement.executeQuery();

      List<Profile> profiles = new ArrayList<Profile>();

      while (resultSet.next())
      {
        String username = resultSet.getString("username");
        String firstname = resultSet.getString("firstname");
        String lastname = resultSet.getString("lastname");
        LocalDate birthday = resultSet.getDate("birthday").toLocalDate();
        Specialties specialties = Specialties.valueOf(resultSet.getString("Speciality"));
        Role role1 = Role.valueOf(resultSet.getString("role"));
        Profile p = new Profile(username,firstname,lastname,specialties,birthday);
        p.setRole(role1);
        System.out.println("fromDB---->>"+ p.toString());
        profiles.add(p);
      }
      System.out.println("############################");
      return profiles;
    }
    catch (SQLException s)
    {
      System.out.println(s+" - returned null");
      return null;
    }
  }
  
}
