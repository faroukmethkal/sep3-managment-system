package network;

import model.Account;
import model.Profile;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface RemoteModel extends Remote {
  Account login(String username) throws RemoteException;
  void addProfile(Profile profile); //rename for the spring if needed

}
