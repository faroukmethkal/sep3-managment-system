package database;

import model.Account;

public interface AccountDAO
{
  Account getAccountByUsername(String username);
  void register(String username, String password,String role);
}
