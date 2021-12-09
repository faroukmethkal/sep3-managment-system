package network;
import model.Account;
import model.Profile;
import model.Role;
import model.Specialties;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.util.List;

public class RemoteProfileManager implements RemoteProfile {


    private RemoteProfile server;

    public RemoteProfileManager() throws MalformedURLException, NotBoundException, RemoteException {
        this.server = (RemoteProfile) Naming.lookup("rmi://localhost:1099/Server");

    }

    @Override
    public Account login(String username)  {

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
    public List<Profile> getAllProfiles()  {

        try {
            return server.getAllProfiles();
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public List<Profile> getAllProfileByRole(Role role) {
        try {
            return server.getAllProfileByRole(role) ;
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public void addDateToCalendar(LocalDate date) {
        try {
            server.addDateToCalendar(date);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public List<Account> getAllAccounts(){
        try {
            return server.getAllAccounts();
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public Specialties getSpecialty(String username){
        try {
            return server.getSpecialty(username);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }


}
