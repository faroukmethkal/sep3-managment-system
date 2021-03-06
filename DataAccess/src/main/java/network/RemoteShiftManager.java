package network;

import database.ShiftDAO;
import database.ShiftDAOImpl;
import model.Profile;
import model.Shift;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.SQLException;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.List;

public class RemoteShiftManager implements RemoteShift{

    private ShiftDAO shiftDB;

    public RemoteShiftManager()
        throws MalformedURLException, NotBoundException, RemoteException,
        SQLException
    {
        startServer();
        shiftDB = new ShiftDAOImpl();
    }

    private void startServer() throws RemoteException, MalformedURLException
    {
        UnicastRemoteObject.exportObject(this, 0);
        Naming.rebind("Shift", this);
        System.out.println("Shift Server started...");
    }

    @Override
    public void createShift(Shift shift) throws RemoteException {
        shiftDB.addShift(shift);
    }

    @Override
    public List<Shift> getAllShifts() throws RemoteException {
        return shiftDB.getAllShifts();
    }

    @Override public void removeShift(int shiftId) throws RemoteException
    {
        shiftDB.removeShift(shiftId);
    }

    @Override public void editShift(Shift shift) throws RemoteException
    {
        shiftDB.editShift(shift);
    }

    @Override
    public Shift getShiftById(int shiftId) throws RemoteException {
        return shiftDB.getShiftById(shiftId);
    }

    @Override
    public List<Shift> getAllAvailableShift(LocalDate date) throws RemoteException {
        return shiftDB.getAvailableShifts(date);
    }

    @Override public List<Shift> getAllShiftsStartAtDate(LocalDate date)
        throws RemoteException
    {
        return shiftDB.getShiftsStartingAtDate(date);
    }

    @Override public List<Shift> getAllShiftsStartAndEndAtTime(
        LocalTime startTime, LocalTime endTime) throws RemoteException
    {
        return shiftDB.getShiftsBetweenTime(startTime, endTime);
    }

    @Override public List<Shift> getAllShiftsStartAtTime(LocalTime startTime)
        throws RemoteException
    {
        return shiftDB.getShiftsStartingAtTime(startTime);
    }

    @Override public void assignEmployeeToShift(int shiftId, String username) throws RemoteException
    {
        shiftDB.assignEmployeeToShift(shiftId, username);
    }

    @Override public void removeEmployeeFromShift(int shiftId, String username) throws RemoteException
    {
        shiftDB.removeEmployeeFromShift(shiftId, username);
    }

    @Override public List<Shift> getShiftsOfEmployee(String username)
        throws RemoteException
    {
        return shiftDB.getShiftsOfEmployee(username);
    }

    @Override
    public List<Profile> getAssignedEmployeesToShift(int shiftId) throws RemoteException {
        return shiftDB.getAssignedEmployeesToShift(shiftId);
    }

    @Override
    public int getNumAssignedEmployeesToShift(int shiftId) {
        try {
            return shiftDB.getNumAssignedEmployeesToShift(shiftId);
        } catch (Exception e) {
            e.printStackTrace();
        }

        return -1;
    }

}
