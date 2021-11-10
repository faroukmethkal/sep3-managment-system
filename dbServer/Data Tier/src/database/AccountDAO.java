package database;

import model.Account;
import model.Profile;

import java.util.List;

public interface AccountDAO
{
  Account getAccountByUsername(String username);
  void addAccount(Account account);
  List<Account> getAllAccounts();

}
