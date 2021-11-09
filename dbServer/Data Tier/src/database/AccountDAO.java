package database;

import model.Account;

public interface AccountDAO
{
  Account getAccountByUsername(String username);
  void addAccount(Account account);
}
