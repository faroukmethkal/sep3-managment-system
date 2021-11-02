package network;




import model.Account;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;

public interface RemoteModle extends Remote {
    Account login(String username) throws RemoteException;

}
