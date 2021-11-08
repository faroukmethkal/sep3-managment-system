package network;




import model.Account;
import model.Profile;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.List;

public interface RemoteProfile extends Remote {
    Account login(String username) throws RemoteException;
    void createEmployee(Profile IProfile, Account account) throws RemoteException;
    List<Account> getAllAccount() throws RemoteException;

}
