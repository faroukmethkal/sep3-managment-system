package network;



import model.Account;
import model.Profile;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.util.List;

public class RemoteProfileManager implements RemoteProfile {


    private RemoteProfile server;

    public RemoteProfileManager() throws MalformedURLException, NotBoundException, RemoteException {
        this.server = (RemoteProfile) Naming.lookup("rmi://localhost:1099/Server");

    }

    @Override
    public Account login(String username) throws RemoteException {

        try {
            return server.login(username);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public void createEmployee(Profile IProfile, Account account) {
        try {
            server.createEmployee(IProfile,account);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public List<Account> getAllAccount() {
        try {
            return server.getAllAccount();
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

}
