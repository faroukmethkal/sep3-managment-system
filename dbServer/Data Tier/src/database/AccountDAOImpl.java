package database;

import model.Account;
import model.Profile;
import model.Specialties;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.*;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

public class AccountDAOImpl implements AccountDAO
{
  private static AccountDAOImpl instance;

  private AccountDAOImpl() throws SQLException
  {
    DriverManager.registerDriver(new org.postgresql.Driver());
  }

  public static synchronized AccountDAOImpl getInstance() throws SQLException
  {
    if (instance == null)
    {
      instance = new AccountDAOImpl();
    }
    return instance;
  }

  private Connection getConnection() throws SQLException
  {
    return DriverManager.getConnection(
        "jdbc:postgresql://hattie.db.elephantsql.com:5432/bzjrfgwn?currentSchema=sep", //change schema after db is done
        "bzjrfgwn", "ZPXdZD4hJLi7bjSr5foQeqn2ithW6iQV");
  }


  @Override public Account getAccountByUsername(String username)
  {
    try (Connection connection = getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT username,password,role FROM Account WHERE username = ?");

      statement.setString(1, username); //change according to db

      ResultSet resultSet = statement.executeQuery();

      while (resultSet.next())
      {
        String usernameDb = resultSet.getString("username");
        String password = resultSet.getString("password");
        String role = resultSet.getString("role");

        if(usernameDb == null) return null;
        else
        {
          Account toReturn = new Account(usernameDb, password, role);
          return toReturn;
        }
      }
    }
    catch(SQLException s){
      System.out.println(s);
    }
    return null;
  }

  @Override public void addAccount(Account account)
  {
    try(Connection connection = getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "INSERT INTO Account (username, password, role) VALUES (?,?,?)");
      statement.setString(1, account.getUsername());
      statement.setString(2, account.getPassword());
      statement.setString(3, account.getRole());


      statement.executeUpdate();
    }
    catch(SQLException s){}
  }

  @Override public List<Account> getAllAccounts()
  {
    try (Connection connection = getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("select * from account");

      ResultSet resultSet = statement.executeQuery();

      List<Account> accounts = new ArrayList<Account>();

      while (resultSet.next())
      {
        String username = resultSet.getString("username");
        String password = resultSet.getString("password");
        String role = resultSet.getString("role");
        Account a = new Account(username, password, role);
        System.out.println(a.toString());
        accounts.add(a);
      }
      return accounts;
    }
    catch (SQLException s)
    {
      System.out.println("SQLException - returned null");
      return null;
    }
  }
}
