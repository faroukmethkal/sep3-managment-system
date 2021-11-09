package network;



import database.AccountDAO;
import database.AccountDAOImpl;
import database.ProfileDAO;
import database.ProfileDAOImpl;
import model.Account;
import model.Profile;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;
import java.sql.SQLException;

public class RemoteModelManager implements RemoteModel{
    private AccountDAO accountDB;
    private ProfileDAO profileDB;

    public RemoteModelManager()
        throws RemoteException, MalformedURLException, SQLException
    {
         startRegistry();
         startServer();
         accountDB = AccountDAOImpl.getInstance();
         profileDB = ProfileDAOImpl.getInstance();
    }
    private void startRegistry() throws RemoteException {
        try {
            Registry reg = LocateRegistry.createRegistry(1099);
            System.out.println("Registry started...");
        } catch (java.rmi.server.ExportException e) {
            System.out.println("Registry already started? " + e.getMessage());
        }
    }

    private void startServer() throws RemoteException, MalformedURLException {
        UnicastRemoteObject.exportObject(this, 0);
        Naming.rebind("Server", this);
        System.out.println("Server started...");
    }

    @Override
    public Account login(String username) throws RemoteException{
        Account account =  accountDB.getAccountByUsername(username);
        if(account == null){
            throw new IllegalArgumentException("user not exist");
        }

        return account;
    }

    @Override public void addProfile(Profile profile)
    {
        profileDB.AddProfile(profile);
    }

}
