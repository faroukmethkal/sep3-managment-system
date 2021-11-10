package network;

import model.Account;
import model.Profile;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.List;

public interface ProfileModel extends Remote {
  Account login(String username) throws RemoteException;
  void createEmployee(Profile profile, Account account) throws RemoteException;
  List<Profile> getAllProfiles() throws RemoteException;
  List<Account> getAllAccounts() throws RemoteException;

}
