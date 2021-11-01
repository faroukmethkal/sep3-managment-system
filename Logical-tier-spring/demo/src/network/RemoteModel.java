package network;




import model.Account;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface RemoteModel extends Remote {
    Account login(String username) throws RemoteException;

}
