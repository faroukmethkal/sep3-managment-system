package network;



import model.Account;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;

public class RemoteModelManager implements RemoteModle {

    private RemoteModle server;

    public RemoteModelManager() throws MalformedURLException, NotBoundException, RemoteException {
        this.server = (RemoteModle) Naming.lookup("rmi://localhost:1099/Server");

    }

    @Override
    public Account login(String username) throws RemoteException {
        return server.login(username);
    }

}
