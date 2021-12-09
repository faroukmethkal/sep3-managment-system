package network;



import database.*;
import model.Account;
import model.Profile;
import model.Role;
import model.Specialties;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;
import java.sql.SQLException;
import java.time.LocalDate;
import java.util.List;

public class RemoteProfileManager implements RemoteProfile
{
    private AccountDAO accountDB;
    private ProfileDAO profileDB;
    private CalendarDAO calendarDB;

    public RemoteProfileManager()
        throws RemoteException, MalformedURLException, SQLException
    {
         startRegistry();
         startServer();
         accountDB = new AccountDAOImpl();
         profileDB = new ProfileDAOImpl();
         calendarDB = new CalendarDAOImpl();
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

    @Override public void createEmployee(Profile profile, Account account)
        throws RemoteException
    {
        accountDB.addAccount(account);
        profileDB.AddProfile(profile);
    }

    @Override public List<Profile> getAllProfiles() throws RemoteException
    {
        return profileDB.getAllProfiles();
    }

    @Override public List<Account> getAllAccounts() throws RemoteException
    {
        return accountDB.getAllAccounts();
    }

    @Override public Specialties getSpecialty(String username)
        throws RemoteException
    {
        return profileDB.getSpecialtyByUsername(username);
    }

    @Override public List<Profile> getAllProfileByRole(Role role)
    {
        return profileDB.getProfilesByRole(role);
    }

    @Override public List<Profile> getProfilesBySpecialty(Specialties specialty)
        throws RemoteException
    {
        return profileDB.getProfilesBySpecialty(specialty);
    }

    @Override public void addEntryToCalendar(String username, LocalDate date)
        throws RemoteException
    {
        calendarDB.addEntryToCalendar(username, date);
    }

    @Override public List<LocalDate> getDatesOfEmployee(String username)
        throws RemoteException
    {
        return calendarDB.getDatesOfEmployee(username);
    }

}
