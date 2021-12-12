package database;

import model.Account;
import model.Role;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class AccountDAOImpl implements AccountDAO
{


  @Override public Account getAccountByUsername(String username)
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "SELECT username,password,role FROM Account WHERE username = ?");

      statement.setString(1, username);

      ResultSet resultSet = statement.executeQuery();

      while (resultSet.next())
      {
        String usernameDb = resultSet.getString("username");
        String password = resultSet.getString("password");
        String role = resultSet.getString("role");

        if(usernameDb == null) return null;
        else
        {
          Account toReturn = new Account(usernameDb, password, Role.valueOf(role));
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
    try(Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement(
          "INSERT INTO Account (username, password, role) VALUES (?,?,?)");
      statement.setString(1, account.getUsername());
      statement.setString(2, account.getPassword());
      statement.setString(3, account.getRole().toString());


      statement.executeUpdate();
    }
    catch(SQLException s){
      System.out.println(s);
    }
  }

  @Override public List<Account> getAllAccounts()
  {
    try (Connection connection = ConnectionDB.getInstance().getConnection())
    {
      PreparedStatement statement = connection.prepareStatement("select * from account");

      ResultSet resultSet = statement.executeQuery();

      List<Account> accounts = new ArrayList<Account>();

      while (resultSet.next())
      {
        String username = resultSet.getString("username");
        String password = resultSet.getString("password");
        String role = resultSet.getString("role");
        Account a = new Account(username, password, Role.valueOf(role));
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
