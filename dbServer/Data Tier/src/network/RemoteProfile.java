package network;

import model.Account;
import model.Profile;
import model.Role;
import model.Specialties;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.List;

public interface RemoteProfile extends Remote {
  Account login(String username) throws RemoteException;
  void createEmployee(Profile profile, Account account) throws RemoteException;
  List<Profile> getAllProfiles() throws RemoteException;
  List<Account> getAllAccounts() throws RemoteException;
  Specialties getSpecialty(String username) throws RemoteException;
  List<Profile> getAllProfileByRole(Role role) throws RemoteException;
}
